using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsStartProcessWaitEndProcess
{
    /// <summary>
    /// статический класс для работы с процессами
    /// </summary>
   public static class ProcessManagement
    {
        /// <summary>
        /// Метод открывает приложение и ожидает закрытие окна процесса.Как аргумент принимает название файла или путь к файлу
        /// Возвращает обьект Process или null если название программы или путь к файлу указан неверно
        /// <param name="FileNameOrPath"></param>
        ///  </summary>
        public static Process OpenProcessWaitExit(string FileNameOrPath)
        {
            Process process = null;

                try
                {
                ProcessStartInfo processStart = new ProcessStartInfo(FileNameOrPath);

                    process = Process.Start(processStart);
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                //в будующем сохранять логи ошибок
                   return null;
                }
         
                return process;
            
        }
       

    }
}
