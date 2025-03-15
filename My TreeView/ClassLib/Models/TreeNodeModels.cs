using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Models
{
    public class TreeNodeModels
    {
        public string Name { get; set; }
        public List<TreeNodeModels> Children { get; }
        public TreeNodeModels(string name)
        {
            Name = name;
            Children = new List<TreeNodeModels>();
        }
        public TreeNodeModels AddChildNode(string text)
        {
            TreeNodeModels node = new TreeNodeModels(text);
            Children.Add(node);
            return node;
        }
        private void Traverse(TreeNodeModels node, StreamWriter writer)
        {
            foreach (var child in node.Children)
            {
                writer.WriteLine($"{node.Name},{child.Name}"); 
                Traverse(child, writer); 
            }
        }
        public static void save_CSV(string Путь_к_файлу, List<TreeNodeModels> treeData)
        {
            using (StreamWriter writer = new StreamWriter(Путь_к_файлу, false, Encoding.UTF8))
            {               
                foreach (var rootNode in treeData)
                {
                    rootNode.Traverse(rootNode, writer);
                }
            }
        }
        public static List<TreeNodeModels> Load_CSV(string Путь_к_файлу)
        {
            var nodes = new Dictionary<string, TreeNodeModels>();
            List<TreeNodeModels> treeData = new List<TreeNodeModels>();
            using (StreamReader reader = new StreamReader(Путь_к_файлу, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Пропускаем заголовок
                    if (line.StartsWith("Parent,Child")) continue;

                    var parts = line.Split(',');

                    if (parts.Length < 2) continue; // Пропускаем некорректные строки

                    string parentName = parts[0].Trim();
                    string childName = parts[1].Trim();

                    // Если родительский узел не существует, создаем его
                    if (!nodes.ContainsKey(parentName))
                    {
                        nodes[parentName] = new TreeNodeModels(parentName);
                        treeData.Add(nodes[parentName]); // Добавляем в корневые узлы
                    }
                    // Создаем дочерний узел и добавляем его к родителю
                    TreeNodeModels parentNode = nodes[parentName];
                    TreeNodeModels childNode = new TreeNodeModels(childName);
                    parentNode.AddChildNode(childName);
                    nodes[childName] = childNode; // Сохраняем дочерний узел в словаре
                }
            }
            return treeData;
        }
    }
}