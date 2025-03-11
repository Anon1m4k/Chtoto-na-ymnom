using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Drink
    {
        public string Name { get; set; }
        public string Volume { get; set; }
        public float Prise { get; set; }
        public string Group { get; set; }

        public static Dictionary<string, string> Aliases = new Dictionary<string, string>()
        {
            { nameof(Name), "Название"},
            { nameof(Volume), "Объём"},
            { nameof(Prise), "Цена"},
            { nameof(Group), "Группа"},
        };

    }
}