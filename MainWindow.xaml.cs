﻿using System;
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
using System.ComponentModel;
using EulerProject.EulerProblems;

namespace EulerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeTextBlock(cBox.SelectedIndex);          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn.IsEnabled = false; //disable button when solving an Euler problem.
            btn.Content = "Solving...";

            SolveAProblem(cBox.SelectedIndex);     
        }
        
        /// <summary>
        /// Launches the selected Euler problem in a new thread.
        /// </summary>        
        private void SolveAProblem(int Index)
        {            
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += delegate(object s, DoWorkEventArgs args)
            {
                switch (Index)
                {
                    case 0:
                        args.Result = EulerProblem1.solve();
                        break;
                    case 1:
                        args.Result = EulerProblem2.solve();
                        break;
                    case 2:
                        args.Result = EulerProblem3.solve();
                        break;
                    case 3:
                        args.Result = EulerProblem4.solve();
                        break;
                    case 4:
                        args.Result = EulerProblem5.solve();
                        break;
                    case 5:
                        args.Result = EulerProblem6.solve();
                        break;
                    case 6:
                        args.Result = EulerProblem7.solve();
                        break;
                    case 7:
                        args.Result = EulerProblem8.solve();
                        break;
                    case 8:
                        args.Result = EulerProblem17.solve();
                        break;
                    case 9:
                        args.Result = EulerProblem18.solve();
                        break;
                    case 10:
                        args.Result = EulerProblem20.solve();
                        break;
                }
            };
            worker.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args)
            {
                lbl2.Content = args.Result;
                btn.IsEnabled = true; //enable button after Euler problem is solved.
                btn.Content = "Solve";
            };
            worker.RunWorkerAsync();
        }

        /// <summary>
        /// Changes the textblock based on the selection from the combobox.
        /// </summary>        
        private void ChangeTextBlock(int Index)
        {
            switch (Index)
            {
                case 0:
                    txtBlk.Text = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.";
                    lbl2.Content = "";
                    break;
                case 1:
                    txtBlk.Text = "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
                    lbl2.Content = "";
                    break;
                case 2:
                    txtBlk.Text = "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?";
                    lbl2.Content = "";
                    break;
                case 3:
                    txtBlk.Text = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.";
                    lbl2.Content = "";
                    break;
                case 4:
                    txtBlk.Text = "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
                    lbl2.Content = "";                    
                    break;
                case 5:
                    txtBlk.Text = "The sum of the squares of the first ten natural numbers is, 12 + 22 + ... + 102 = 385 The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025 Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640. Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
                    lbl2.Content = "";
                    break;
                case 6:
                    txtBlk.Text = "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 10 001st prime number?";
                    lbl2.Content = "";
                    break;
                case 7:
                    txtBlk.Text = "Find the greatest product of five consecutive digits in the 1000-digit number. 7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
                    lbl2.Content = "";
                    break;

            }

        }     
    }
}