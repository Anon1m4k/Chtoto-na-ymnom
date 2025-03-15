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
            /*{
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
            {
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
            }*/

            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);
            MyTreeView.ExpandAll();

            
            Table.DataSource = bild;

            /*Table.Columns.Add("Name", "Название");
            Table.Columns.Add("Volume", "Объём");
            Table.Columns.Add("Prise", "Цена");
            Table.Columns.Add("Group", "Группа");*/
                            
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
                    //object[] newRow = { Dr.Name, Dr.Volume, Dr.Prise, Dr.Group };
                    //Table.Rows.Add(newRow);

                    bild.Add(Dr);
                }
            }
        }
        private const string Путь_к_файлу = "Напитки_по_магазинам.csv";
        private void сохранить_Click(object sender, EventArgs e)
        {
            TreeNodeModels.save_CSV(Путь_к_файлу, treeData_);
            MessageBox.Show($"Структура дерева сохранена в файл {Путь_к_файлу}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void загрузить_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*", Title = "Выберите CSV файл для загрузки" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string путьКФайлу = openFileDialog.FileName;
                        var loadedTreeData = TreeNodeModels.Load_CSV(путьКФайлу);

                        MyTreeView.Nodes.Clear();
                        MyTreeView.Nodes.AddRange(loadedTreeData.Select(CreateTreeNode).ToArray());

                        MessageBox.Show($"Структура дерева загружена из файла {путьКФайлу}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private TreeNode CreateTreeNode(TreeNodeModels treeNodeModel)
        {
            TreeNode treeNode = new TreeNode(treeNodeModel.Name);
            foreach (var child in treeNodeModel.Children)
            {
                treeNode.Nodes.Add(CreateTreeNode(child)); // Рекурсивное добавление дочерних узлов
            }
            return treeNode;
        }
        // private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        // }
        BindingList<Drink> bild = new BindingList<Drink>();
    }
}