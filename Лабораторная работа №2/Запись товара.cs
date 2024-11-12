using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public struct ЗаписьТовара
    {
       
        public int День;
        public int Количество;
        public Товар Товар;
        //string Название
        public ЗаписьТовара(Товар Т, int День_, int Количество_)
        {
            Товар = Т;
            День = День_;
            Количество = Количество_;

        }
    }
}
