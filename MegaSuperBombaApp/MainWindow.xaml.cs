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

namespace MegaSuperBombaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // need to maximize and getting winodw back to normal 
        bool maximized = false;

        string value;

        // Used to clear gritting from textbox
        bool beenPressedAnyButton = false;


        double result;
        double currentNumber;

        bool beenAssigned = false;

        bool beenDoneOperations = false;

        char lastOperation;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(beenPressedAnyButton == false)
            {
                value = "";

                value = value + "1";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "1"; 
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "2";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "2";
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "3";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "3";
                TextNumbers.Text = value;
                beenAssigned = true;

            }
        }

        private void btnDevision_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '/';
                }
                else
                {

                    lastOperation = '/';
                    value = "";
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "4";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "4";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "5";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;

            }

            else
            {
                value = value + "5";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "6";
                TextNumbers.Text = value;
                beenAssigned = true;
                beenPressedAnyButton = true;
            }

            else
            {
                value = value + "6";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '*';
                }
                else
                {

                    lastOperation = '*';
                    value = "";
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "7";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "7";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "8";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "8";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "9";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
                beenAssigned = true;
            }

            else
            {
                value = value + "9";
                TextNumbers.Text = value;
                beenAssigned = true;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;
                
            }
            else
            {
                if(beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '+';
                }
                else
                {
                   
                    lastOperation = '+';
                    value = "";
                }
            }
        }

        private void btnDote_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton != false)
            {
              
                    value = value + ".";
                    TextNumbers.Text = value;
                
               
            }
            else{

                TextNumbers.Text = "Can't start frome dote";
            }

            
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (beenPressedAnyButton == false)
            {
                value = "";

                value = value + "0";
                TextNumbers.Text = value;
                beenPressedAnyButton = true;
            }

            else
            {
                value = value + "0";
                TextNumbers.Text = value;

            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
           switch (lastOperation)
            {
                case '+':
                    currentNumber = Double.Parse(value);
                    result = result + currentNumber;
                    TextNumbers.Text = result.ToString();
                    break;

                case '-':
                    currentNumber = Double.Parse(value);
                    result = result - currentNumber;
                    TextNumbers.Text = result.ToString();
                    break;

                case '*':
                    currentNumber = Double.Parse(value);
                    result = result * currentNumber;
                    TextNumbers.Text = result.ToString();
                    break;

                case '/':
                    currentNumber = Double.Parse(value);
                    if(currentNumber != 0)
                    {
                        result = result / currentNumber;
                        TextNumbers.Text = result.ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Can't devide by 0");
                        value = "";
                        TextNumbers.Text = "Input another value!";
                        beenPressedAnyButton = false;
                    }
                    break;

            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (beenAssigned == false)
            {
                value = "First input value you are adding to";
                TextNumbers.Text = value;

            }
            else
            {
                if (beenDoneOperations == false)
                {
                    result = Double.Parse(value);
                    beenDoneOperations = true;
                    value = "";
                    lastOperation = '-';
                }
                else
                {

                    lastOperation = '-';
                    value = "";
                }
            }
        }

        private void btnfullScreen_Click(object sender, RoutedEventArgs e)
        {
         
            if (maximized != true)
            {
                this.WindowState = WindowState.Maximized;
                
                
                maximized = !maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                maximized = !maximized;


            }




        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            
        }
    }
}
