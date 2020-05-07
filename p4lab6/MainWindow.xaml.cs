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

namespace p4lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Votes{get;set; }=0;
        public int VoteA { get; set; } = 0;
        public int VoteB { get; set; } = 0;
        public int VoteC { get; set; } = 0;
        public int VoteD { get; set; } = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            RectangleOne.Height += 5;
            Canvas.SetTop(RectangleOne, Canvas.GetTop(RectangleOne) - 5);
            Votes += 1;
            VoteA += 1;
            VoteOne.Text = VoteA.ToString();
            AllVotes.Text = "Votes: " + Votes;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            RectangleTwo.Height += 5;
            Canvas.SetTop(RectangleTwo, Canvas.GetTop(RectangleTwo) - 5);
            Votes += 1;
            VoteB += 1;
            VoteTwo.Text = VoteB.ToString();
            AllVotes.Text = "Votes: " + Votes;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            RectangleThree.Height += 5;
            Canvas.SetTop(RectangleThree, Canvas.GetTop(RectangleThree) - 5);
            Votes += 1;
            VoteC += 1;
            VoteThree.Text = VoteC.ToString();
            AllVotes.Text = "Votes: " + Votes;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            RectangleFour.Height += 5;
            Canvas.SetTop(RectangleFour, Canvas.GetTop(RectangleFour) - 5);
            Votes += 1;
            VoteD += 1;
            VoteFour.Text = VoteD.ToString();
            AllVotes.Text = "Votes: " + Votes;
        }
    }
}
