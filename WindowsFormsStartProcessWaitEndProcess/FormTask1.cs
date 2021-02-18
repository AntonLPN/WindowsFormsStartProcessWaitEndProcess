using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsStartProcessWaitEndProcess
{
    
    public partial class FormTask1 : Form
    {
//        Задание №1
//Разработайте приложение, которое умеет запускать дочерний процесс и
//ожидать его завершения.Когда дочерний процесс завершен, родительское
//приложение должно отобразить код завершения.
        public FormTask1()
        {
            InitializeComponent();
          
        }
        //событие открытие блокнота
        //Ожидает закрытие процесса и выводит окно ExitCode
        private void buttonOpenNotepad_Click(object sender, EventArgs e)
        {
           
           Process processOpenNotepad= ProcessManagement.OpenProcessWaitExit("notepad"); //созданый мною класс для работы с процессами
                                                                                         //выаодим сообщение  с закрывающим кодом
            if (processOpenNotepad!=null)
            {
                MessageBox.Show($"{ processOpenNotepad.ExitCode}", "Information Exit Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//если название програмы неправильно то выводим сообщение
            {
                MessageBox.Show("Ошибка открытия приложения", "Open Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
