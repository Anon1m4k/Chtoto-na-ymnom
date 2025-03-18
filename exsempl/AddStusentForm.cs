using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exsempl
{
    public partial class AddStusentForm: Form
    {
        public AddStusentForm()
        {
            InitializeComponent();
        }
        public Student GetObject()
        {
            Student S = new Student();
            S.Name = textBoxName.Text;
            S.Group = textBoxGroup.Text;
            S.Age = (int)numericUpDownAge.Value;
            return S;
        }
        public void SetObject(Student stud)
        {  
            textBoxName.Text = stud.Name;
            textBoxGroup.Text = stud.Group;
            numericUpDownAge.Value = stud.Age;  
        }
    }
}