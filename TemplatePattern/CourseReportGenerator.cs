using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class CourseReportGenerator : ReportGenerator
    {
        string _type;
        string _action;
        public CourseReportGenerator(string type, string action)
        {
            _type = type;
            _action = action;
        }

        protected override void ReportFormating()
        {
            Console.WriteLine($"Данные обработаны с помощью {_action}");
        }

        protected override void DataCollection()
        {
            Console.WriteLine($"Отчет отформатирован в формате: {_type}");
        }
    }
}
