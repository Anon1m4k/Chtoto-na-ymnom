using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exsempl
{
    public partial class Form1: Form
    {
        BindingList<Student> B = new BindingList<Student>();
        public Form1()
        {
            InitializeComponent();
            B.Add(new Student { Name = "ААА", Group = "П-10", Age = 18 });
            B.Add(new Student { Name = "БББ", Group = "П-20", Age = 19 });
            B.Add(new Student { Name = "ВВВ", Group = "П-30", Age = 20 });
        }
        
    }
}
