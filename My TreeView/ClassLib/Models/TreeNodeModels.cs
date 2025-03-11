using System;
using System.Collections.Generic;
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
    }
}