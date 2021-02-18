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
using System.Collections;


//Задание №2
//Разработайте приложение, которое умеет запускать дочерний процесс. В
//зависимости от выбора пользователя родительское приложение должно ожидать
//завершения дочернего процесса и отображать код завершения либо принудительно
//завершать работу дочернего процесса.
namespace WindowsFormsStartProcessWaitEndProcess
{
    public partial class FormTask2 : Form
    {
    List<Process> processOpen;//для процесса открытия блокнота и принудительного его завершеня


        public FormTask2()
        {
            InitializeComponent();
            processOpen = new List<Process>();
        }

        /// <summary>
        /// Кнопка запуска блокнота с ожиданием конца работы блокнота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWaitEnd_Click(object sender, EventArgs e)
        {
            Process processOpenNotepad = ProcessManagement.OpenProcessWaitExit("notepad"); //созданый мною класс для работы с процессами
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

        /// <summary>
        /// Событе открытия блкнота без ожидания завершения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForcedStop_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("notepad");
            if (startInfo==null)
            {
                MessageBox.Show("Ошибка открытия приложения", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Process process = Process.Start(startInfo);
            processOpen.Add(process);
        

        }

        /// <summary>
        /// Событие закрытия процессов инициализированных кнопкой открыть блокнот
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            
            //если есть процесс то закрываем его
            if (processOpen.Count>0)
            {
                //так как есть возможность многократного нажатия кнопки открыть блокнот
                //то используем цикл и массив процессов для тогго что бы закрть все процессы
                foreach (var process in processOpen)
                {
                    //тут какой то косяк поэтому трай кетчим
                    try
                    {
                        process.CloseMainWindow();
                        process.Close();
                    }
                    catch (Exception)
                    {

                       
                    }
                   
                }
                //очищаем список для последующего использования
                processOpen.Clear();
            }
        }
    }
}
