using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Lesson5.Model;

namespace WPF_Lesson5.DataContext
{
    class MobileDataContext
    {
        public MobilePhone MyMobilePhone { get; set; }

        public MobileDataContext()
        {
            MyMobilePhone = new MobilePhone
            {
                Model = "S10",
                Brand = "Samsung",
                Color = "Black"
            };
        }
    }
}
