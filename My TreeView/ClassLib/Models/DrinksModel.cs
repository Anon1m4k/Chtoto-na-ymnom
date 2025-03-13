using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLib.Models
{
    public class DrinksModel
    {
        public List<Drink> Drinks { get; }
       

        public DrinksModel()
        {
            Drinks = new List<Drink>();

            Drinks.Add(new Drink
            {
                Name = "Яблочный сок из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Негазированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Яблочный сок из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Негазированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Вишнёвый сок из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Негазированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Вишнёвый сок из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Негазированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Колла из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Газированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Колла из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Газированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Спрайт из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Газированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Спрайт из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Газированные",
            });
            Drinks.Add(new Drink
            {
                Name = "Вино из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Алкогольные",
            });
            Drinks.Add(new Drink
            {
                Name = "Водка из Магнита",
                Volume = "100мл",
                Prise = 150,
                Group = "Алкогольные",
            });

            Drinks.Add(new Drink
            {
                Name = "Вино из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Алкогольные",
            });
            Drinks.Add(new Drink
            {
                Name = "Водка из Пятёрочки",
                Volume = "100мл",
                Prise = 100,
                Group = "Алкогольные",
            });
        }
        public Drink GetName(string Name)
        {
            return Drinks.Find(e => e.Name == Name);
        }
    }
}