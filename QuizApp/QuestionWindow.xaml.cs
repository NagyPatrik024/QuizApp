using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _2ora
{
    public partial class QuestionWindow : Window
    {
        private Random rnd;
        private Question q;
        private DispatcherTimer timer;
        private TimeSpan time;

        public QuestionWindow(Question q)
        {
            InitializeComponent();
            this.q = q;
            rnd = new Random();
            timer = new DispatcherTimer();
            time = TimeSpan.FromSeconds(59);

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                l_timer.Content = time.ToString("ss");
                if (time == TimeSpan.Zero && this.DialogResult == null)
                    this.DialogResult = false;
                time = time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            timer.Start();
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content == q.Correct)
            {
                this.DialogResult = true;
            }
            else
            {
                this.DialogResult = false;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.DialogResult == null)
            {
                MessageBoxResult result = MessageBox.Show("Biztos ki akarsz lépni?", "Kilépés", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    this.DialogResult = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int n = q.Answers.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                string temp = q.Answers[n];
                q.Answers[n] = q.Answers[k];
                q.Answers[k] = temp;
            }

            int i = 0;

            l_question.Content = q.QuestionProp;
            foreach (var item in sp.Children)
            {
                if (item is Button)
                {
                    (item as Button).Content = q.Answers[i];
                    i++;
                }
            }
        }
    }
}
