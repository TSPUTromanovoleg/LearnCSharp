﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace LearnCSharp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }
            MessageBox.Show(counter.ToString() + " элементов массива {" + string.Join(", ", array) + "} больше своих соседей", "Результат");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 25)
                {
                    MessageBox.Show("Номер первого элемента массива {" + string.Join(", ", array) + "} большего 25 равен " + i, "Результат");
                    return;
                }
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            if (array[0] > array.Average())
            {
                MessageBox.Show("Первый элемент массива {" + string.Join(", ", array) + "} превосходит среднее значение (" + array.Average() + ") элементов этого массива", "Результат");
            }
            else
            {
                MessageBox.Show("Первый элемент массива {" + string.Join(", ", array) + "} не превосходит среднее (" + array.Average() + ") значение элементов этого массива", "Результат");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] >= 0 && array[i] < 0 || array[i - 1] < 0 && array[i] >= 0)
                {
                    counter++;
                }
            }
            MessageBox.Show("В массиве {" + string.Join(", ", array) + "} " + counter + " раз меняется знак у элементов", "Результат");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int sum = 0;
            foreach (int i in array)
            {
                if (i > array[1])
                {
                    sum += i;
                }
            }
            MessageBox.Show("Сумма элементов, больших чем 2 элемент массива {" + string.Join(", ", array) + "} равна " + sum, "Результат");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int counter = 0;
            foreach (int i in array)
            {
                if (i > array[3])
                {
                    counter++;
                }
            }
            MessageBox.Show(counter + " элементов больше, чем 4 элемент массива {" + string.Join(", ", array) + "}", "Результат");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            int sum = 0;
            foreach (int i in array)
            {
                if (i < 21)
                {
                    sum += i;
                }
            }
            MessageBox.Show("Сумма элементов, меньших чем 21 в массиве {" + string.Join(", ", array) + "} равна " + sum, "Результат");
        }


        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int[] array = Array.ConvertAll(System.IO.File.ReadAllLines(@"Arr.txt"), int.Parse);
            List<KeyValuePair<int, int>> valueList = new List<KeyValuePair<int, int>>();
            foreach (int i in array)
            {
                valueList.Add(new KeyValuePair<int, int>(i, i));
            }
            columnChart.DataContext = valueList;
        }
    }
}
