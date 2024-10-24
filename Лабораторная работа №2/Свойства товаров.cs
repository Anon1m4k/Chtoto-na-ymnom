using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public class Товар
    {
        private string Название;
        private double Цена;
        private ГруппыПродукции ГруппыПродукции;
        public Товар(string Название_, double Цена_, ГруппыПродукции ГруппыПродукции_)
        {
            Название = Название_;
            Цена = Цена_;
            ГруппыПродукции = ГруппыПродукции_;
        }
        public string СкажиНазвание()
        {
            return Название;

        }
    }
}
