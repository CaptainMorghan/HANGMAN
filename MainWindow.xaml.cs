using System;
//Morghan Kiverago Hangman summitive 23/04/2019
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

namespace Unit_3_summitive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variables
        string wordToGuess = "";
        Random random = new Random();
        string output = "";
  




        public MainWindow()
        {
            InitializeComponent();

        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {

            // randomNumber = Random.Next(1, 11);//selects random number is selected between 1 and 10
            System.IO.StreamReader streamreader = new System.IO.StreamReader("Words.txt"); //reads from the txt file
            int myNumber = random.Next(1, 101);
            int countLines = 1;
            while (!streamreader.EndOfStream)
            {
                if (countLines == myNumber)
                {
                    wordToGuess = streamreader.ReadLine();
                    MessageBox.Show(wordToGuess);

                }
                else
                {
                    streamreader.ReadLine();
                }
                countLines++;
            }
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                output += "_" + " ";
            }
            lblOutput.Content = output;
            
            
           
        }//end of button

        private void LetterInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }