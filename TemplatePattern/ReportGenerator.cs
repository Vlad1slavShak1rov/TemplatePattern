using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class ReportGenerator
    {
        Random rnd = new Random();
        public void GenerateReport()
        {
            DataCollection();
            DataProcessing();
            ReportFormating();
            ExportReport();
        }

        protected abstract void DataCollection();
        

        protected void DataProcessing()
        {
            Console.WriteLine("Обработка данных, ждите.");
            Random rnd = new Random();
            int load = 0;
            int i = 0;
            Console.Write("\rЗагрузка: ");
            while (load < 100)
            {
                load += rnd.Next(25, 30);
                if (load > 100) load = 100; 
                for (; i < load; i++)
                {
                    Console.Write("|");
                }

                System.Threading.Thread.Sleep(500); 
            }

            Console.WriteLine("\nОбработка завершена.");
        }

        protected abstract void ReportFormating();
        protected void ExportReport()
        {
            Console.WriteLine("Успешно!");
        }
    }
}
