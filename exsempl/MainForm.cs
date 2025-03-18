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
    public partial class MainForm: Form
    {
        BindingList<Student> B = new BindingList<Student>();
        public MainForm()
        {
            InitializeComponent();
            B.Add(new Student { Name = "ААА", Group = "П-10", Age = 18 });
            B.Add(new Student { Name = "БББ", Group = "П-20", Age = 19 });
            B.Add(new Student { Name = "ВВВ", Group = "П-30", Age = 20 });

            dataGridView1.DataSource = B;
        }
        private void КДобавить_Click(object sender, EventArgs e)
        {
            AddStusentForm Form2 = new AddStusentForm();
            DialogResult result = Form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                Student st = Form2.GetObject();
                B.Add(st);
            }
        }
        private void КУдалить_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            B.RemoveAt(rowIndex);
        }
        private int ReturnIndex()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return -1;
            }
            return dataGridView1.SelectedRows[0].Index;
        }
        private void КРедактировать_Click(object sender, EventArgs e)
        {
            int rowIndex = ReturnIndex();
            if (rowIndex == -1 || rowIndex >= B.Count)
            {
                return;
            }
            Student s1 = B[rowIndex];
            AddStusentForm form = new AddStusentForm();
            form.SetObject(s1);
            form.ShowDialog();
        }
    }
}