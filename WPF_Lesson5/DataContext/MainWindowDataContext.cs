using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Lesson5.Model;

namespace WPF_Lesson5.DataContext
{
    public class MainWindowDataContext
    {
        private static Random random = new Random();

        public Numbers MyNumber { get; set; }

        public MainWindowDataContext()
        {
            MyNumber = new Numbers
            {
                Number = random.Next(100, 200),
                Number2 = random.Next(100, 200)
            };

        }
    }

}
