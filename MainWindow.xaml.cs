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

namespace GameBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Board board = new Board();
            Grid grid = this.Content as Grid;

            foreach (Button btn in board.GameBoard)
            {
                btn.Click += Button_Click;
                grid.Children.Add(btn);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
