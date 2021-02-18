using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание №3
//Разработайте приложение, которое умеет запускать дочерний процесс и
//передавать ему аргументы командной строки. В качестве аргументов должно быть
//два числа и операция, которую необходимо выполнить. Например, аргументы:
// 7;
// 3;
// +.
//Дочерний процесс должен отобразить аргументы и вывести результат
//сложения 10 на экран
namespace WindowsFormsStartProcessWaitEndProcess
{
    public partial class FormTask3 : Form
    {
        public FormTask3()
        {
            InitializeComponent();
        }

        private void v_Click(object sender, EventArgs e)
        {
            //передаю консолбное приложение которое находится в папке debug 
            //так же само решение задачи передачи аргументов находится в папке ConsoleApp2 в этом же решение
            //на всякий случай вод код консоли 
            //static void Main(string[] args)
            //{

            //    args = new string[3];

            //    args[0] = "3";
            //    args[1] = "7";
            //    args[2] = "+";

            //    double a = 0, b = 0, res = 0;
            //    string oper = string.Empty;


            //    foreach (var item in args)
            //    {
            //        Console.WriteLine(item);
            //    }


            //    foreach (var item in args)
            //    {
            //        switch (item.ToString())
            //        {
            //            case "3":
            //                {
            //                    double.TryParse(item.ToString(), out a);
            //                }
            //                break;

            //            case "7":
            //                {
            //                    double.TryParse(item.ToString(), out b);
            //                }
            //                break;
            //            case "+":
            //                {
            //                    oper = item.ToString();
            //                    res = a + b;
            //                }
            //                break;
            //        }
            //    }



            //    Console.WriteLine($"{a}{oper}{b}={res}");

            //    Console.ReadKey();

            //}
            Process processOpenNotepad = ProcessManagement.OpenProcessWaitExit("ConsoleApp2"); //созданый мною класс для работы с процессами
                                                                                           //выаодим сообщение  с закрывающим кодом
            if (processOpenNotepad != null)
            {
                MessageBox.Show($"{ processOpenNotepad.ExitCode}", "Information Exit Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//если название програмы неправильно то выводим сообщение
            {
                MessageBox.Show("Ошибка открытия приложения", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
