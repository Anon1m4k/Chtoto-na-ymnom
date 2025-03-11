using ClassLib;
using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_TreeView
{
    public partial class MainForm: Form
    {
        private List<TreeNodeModels> treeData_;
        private DrinksModel DrinksModel_;
        public MainForm()
        {
            InitializeComponent();
            treeData_ = new List<TreeNodeModels>();
            DrinksModel_ = new DrinksModel();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModels("Магнит"));
                var drinksNode = treeData_[0];

                var Негазированные = drinksNode.AddChildNode("Негазированные");
                Негазированные.AddChildNode("Яблочный сок из Магнита"); 
                Негазированные.AddChildNode("Вишнёвый сок из Магнита");

                var Газированные = drinksNode.AddChildNode("Газированные");
                Газированные.AddChildNode("Колла из Магнита"); 
                Газированные.AddChildNode("Спрайт из Магнита");

                var Алкогольные = drinksNode.AddChildNode("Алкогольные");
                Алкогольные.AddChildNode("Вино из Магнита");
                Алкогольные.AddChildNode("Водка из Магнита");
            }
                treeData_.Add(new TreeNodeModels("Пятёрочка"));
            var drinksNodee = treeData_[1];

            var Негазированныеe = drinksNodee.AddChildNode("Негазированные");
            Негазированныеe.AddChildNode("Яблочный сок из Пятёрочки");
            Негазированныеe.AddChildNode("Вишнёвый сок из Пятёрочки");

            var Газированныеe = drinksNodee.AddChildNode("Газированные");
            Газированныеe.AddChildNode("Колла из Пятёрочки");
            Газированныеe.AddChildNode("Спрайт из Пятёрочки");

            var Алкогольныеe = drinksNodee.AddChildNode("Алкогольные");
            Алкогольныеe.AddChildNode("Вино из Пятёрочки");
            Алкогольныеe.AddChildNode("Водка из Пятёрочки");

            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);
            MyTreeView.ExpandAll();
            Table.Columns.Add("Name", "Название");
            Table.Columns.Add("Volume", "Объём");
            Table.Columns.Add("Prise", "Цена");
            Table.Columns.Add("Group", "Группа");
                            
            FillTableAliases();
        }
        static private void FillTreeNodeCollection(List<TreeNodeModels> sourceData, TreeNodeCollection targetData)
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name);
                targetData.Add(treeNode);

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes);
                }
            }
        }
        private void FillTableAliases()
        {
            foreach (DataGridViewColumn column in Table.Columns)
            {
                if (Drink.Aliases.TryGetValue(column.Name, out string alias))
                {
                    column.HeaderText = alias;
                }
            }
            Table.Columns[Table.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void MyTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                
                Drink Dr = DrinksModel_.GetName(e.Node.Text);
                if (Dr != null)
                {
                    object[] newRow = { Dr.Name, Dr.Volume, Dr.Prise, Dr.Group };
                    Table.Rows.Add(newRow);
                }
            }
        }

        private void сохранить_Click(object sender, EventArgs e)
        {

        }

        private void загрузить_Click(object sender, EventArgs e)
        {

        }
    }
}