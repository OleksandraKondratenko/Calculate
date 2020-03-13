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

namespace Calculate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд
        string osnova = "DEC";
        int dotcount = 0;
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in Calc.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
                entryField.Text = "0";
                OCT.Text = "0";
                BIN.Text = "0";
                HEX.Text = "0";
            }
        }
        Calc c = new Calc();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (entryField.Text == "0")
                entryField.Text = " ";
            // Получаем текст кнопки
            string s = (string)((Button)e.OriginalSource).Content;
            
            switch (s)
            {
                case "cos" :
                case "sin":
                case "tg":
                case "Pi":
                case "√":
                case "n!":
                case "x²":
                case "%":
                case "log":
                    rightop = entryField.Text;
                    break;
                default :
                    if (dotcount > 0 && s.Contains("."))
                    {
                       
                        return;
                    }
                    else  entryField.Text += s;
                    break;
            }
            double num;
            // Пытаемся преобразовать его в число
            bool result;

           
            
            if (!s.Contains("."))
            {
                 result = (Double.TryParse(s, out num));
            }
            else
            {
                dotcount++;
                result = true;
            }
            // Если текст - это число
            if (result == true  )
            {
               
                if (operation == ""  )
                {
                    // Добавляем к левому операнду
                    leftop += s;

                        //OCT.Text = Convert.ToString(Convert.ToInt32(rightop), 8);
                        //BIN.Text = Convert.ToString(Convert.ToInt32(rightop), 2);
                        //HEX.Text = Convert.ToString(Convert.ToInt32(rightop), 16).ToUpper();
                   

                }
                else
                {
                   
                    dotcount = 0;
                    rightop += s;
                    //if(!s.Contains("+") )
                    
                   
                        //OCT.Text = Convert.ToString(Convert.ToInt32(rightop), 8);
                        //BIN.Text = Convert.ToString(Convert.ToInt32(rightop), 2);
                        //HEX.Text = Convert.ToString(Convert.ToInt32(rightop), 16).ToUpper();
                    
                }
            }
            // Если было введено не число
            else
            {
                // Если равно, то выводим результат операции
                if (s == "=")
                {
                    if (rightop == "0" && operation == "/")
                    {
                        Check();
                        return;
                    }
                    Update_RightOp();
                    entryField.Text = rightop;
                    //OCT.Text = Convert.ToString(Convert.ToInt32(rightop), 8);
                    //BIN.Text = Convert.ToString(Convert.ToInt32(rightop), 2);
                    //HEX.Text = Convert.ToString(Convert.ToInt32(rightop), 16).ToUpper();

                    operation = "";
                }
                else if (s == "CLEAR")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    entryField.Clear();
                    entryField.Text = "0";
                }
                // Получаем операцию
                else
                {
                    // Если правый операнд уже имеется, то присваиваем его значение левому
                    // операнду, а правый операнд очищаем
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                    if (operation != "" && rightop.Contains(s))
                    {
                        dotcount = 0;

                    }
                }
            }
        }
        // Обновляем значение правого операнда
        private void Update_RightOp()
        {
            if (osnova == "DEC")
            {
                double num1;
                double num2;
                if (double.TryParse(leftop, out num1) && double.TryParse(rightop, out num2))
                {
                  
                    switch (operation)
                    {
                        case "+":
                            rightop = c.Sum(num1,num2).ToString();
                            break;
                        case "-":
                            rightop = c.Minus(num1, num2).ToString();
                            break;
                        case "*":
                            rightop = c.Mult(num1, num2).ToString();
                            break;
                        case "/":
                            rightop = c.dev(num1, num2).ToString();
                            break;

                    }
                    
                    //if (dotcount > 0 && s.Contains("."))
                    //{

                    //    return;
                    //}
                }
                //entryField.Text  = rightop ;
            }
            if (osnova == "BIN")
            {
                int num1 = Convert.ToInt32(leftop, 2);
                int num2 = Convert.ToInt32(rightop, 2);
                // Convert.
                // И выполняем операцию
                switch (operation)
                {
                    case "+":
                        rightop = Convert.ToString((num1 + num2), 2);
                        break;
                    case "-":
                        rightop = Convert.ToString((num1 - num2), 2);
                        break;
                    case "*":
                        rightop = Convert.ToString((num1 * num2), 2);
                        break;
                    case "/":
                        //                      rightop = (num1 / num2).ToString();
                        break;
                }
            }
            if (osnova == "OCT")
            {
                int num1 = Convert.ToInt32(leftop, 8);
                int num2 = Convert.ToInt32(rightop, 8);
                // Convert.
                // И выполняем операцию
                switch (operation)
                {
                    case "+":
                        rightop = Convert.ToString((num1 + num2), 8);
                        break;
                    case "-":
                        rightop = Convert.ToString((num1 - num2), 8);
                        break;
                    case "*":
                        rightop = Convert.ToString((num1 * num2), 8);
                        break;
                    case "/":
                        //                      rightop = (num1 / num2).ToString();
                        break;
                }
              
            }
            
        }

        private void Radio_Dec_Checked(object sender, RoutedEventArgs e)
        {
            osnova = "DEC";
            leftop = "";
            rightop = "";
            operation = "";
            entryField.Text = "";
        }

        private void Radio_Hex_Checked(object sender, RoutedEventArgs e)
        {
            osnova = "HEX";
            leftop = "";
            rightop = "";
            operation = "";
            entryField.Text = Convert.ToString(Convert.ToInt32(entryField.Text), 16).ToUpper();
            
        }

        private void Radio_Oct_Checked(object sender, RoutedEventArgs e)
        {
            osnova = "OCT";
            leftop = "";
            rightop = "";
            operation = "";
            if ( ! (entryField.Text== ""))
            {
                entryField.Text = Convert.ToString(Convert.ToInt32(entryField.Text), 8);
                 
                leftop = entryField.Text;
            }
                
        }

        private void Radio_Bin_Checked(object sender, RoutedEventArgs e)
        {
            osnova = "BIN";
            leftop = "";
            rightop = "";
            operation = "";
            if (!(entryField.Text == ""))
            {
                entryField.Text = Convert.ToString(Convert.ToInt32(entryField.Text), 2);
                leftop = entryField.Text;
            }
        }

        private void Button_tg_Click(object sender, RoutedEventArgs e)
        {
            double n = Check_2();
           n = c.tg(Check_2());
            Check_overload(n);
        }

        private void Button_sin_Click(object sender, RoutedEventArgs e)
        {
            double n = Check_2();
            n = c.sin(Check_2());
            Check_overload(n);
        }

        private void Button_Pi_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            double n =c.log(Check_2());
            Check_overload(n);
        }

        private void Button_cos_Click(object sender, RoutedEventArgs e)
        {
            double n = Check_2();
            n= c.cos(Check_2());
            Check_overload(n);
        }

        private void Button_n_fakt_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            double n = Check_2();
           double temp= c.fakt(n);
            Check_overload(temp);
        }

        private void Button_koren_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
           double n =c.Xkoren2(Check_2());
            Check_overload(n);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            double n = c.X2(Check_2());
            Check_overload(n);

        }

        private void Button_Clickpr(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            double n = Check_2() /100;
            Check_overload(n);
        }
        private void Check()
        {
            entryField.Text = "Error";
        }
        private double Check_2()
        {
            double num;
            bool check = double.TryParse(entryField.Text, out num);
                if(check) { return num; }
                else { return 0; }
        }
        private void Check_overload(double num)
        {
            if (double.IsInfinity(num) )
            {
                Check();
            }
            else
            {
                entryField.Text = num.ToString();
            }
        }


    }
}
