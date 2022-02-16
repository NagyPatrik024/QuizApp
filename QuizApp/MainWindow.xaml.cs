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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2ora
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question("Mi a neve Dél-Korea legnagyobb technológiai vállalatának?", new string[] { "Samsung", "Xiaomi", "LG", "Sony" }, "Samsung"));
            questions.Add(new Question("Hány lélegzetet vesz az emberi test naponta?", new string[] { "20000", "200000", "1500", "1000000" }, "20000"));
            questions.Add(new Question("Melyik évben készült az első Tonka teherautó?", new string[] { "1947", "1949", "1950", "1945" }, "1947"));

            questions.ForEach(t =>
            {
                Label l = new Label();
                l.Tag = t;
                l.Background = Brushes.LightBlue;
                l.Margin = new Thickness(20);
                l.Width = this.ActualWidth / 6;
                l.Height = this.ActualHeight / 6;
                wrap.Children.Add(l);

                l.MouseLeftButtonDown += wrap_MouseLeftButtonDown;
            });
        }

        private void wrap_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label l = (sender as Label);
            Question q = (Question)(l.Tag);

            QuestionWindow qw = new QuestionWindow(q);
            if (qw.ShowDialog() == true)
            {
                l.Background = Brushes.LightGreen;
                l.IsEnabled = false;
            }
            else
            {
                l.Background = Brushes.LightPink;
                l.IsEnabled = false;
            }
        }
    }

    public class Question
    {
        private string question;
        private string[] answers;
        private string correct;


        public Question(string question, string[] answers, string correct)
        {
            this.question = question;
            this.answers = answers;
            this.correct = correct;
        }

        public string QuestionProp { get => question; set => question = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public string Correct { get => correct; set => correct = value; }
    }
}
