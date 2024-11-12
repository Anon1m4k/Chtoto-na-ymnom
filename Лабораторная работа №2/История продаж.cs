using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public class История_продаж
    {
        //Dictionary<ГруппыПродукции,List<ЗаписьТовара>> СловарьПродаж = new Dictionary<ГруппыПродукции, List<ЗаписьТовара>>();
        List<ЗаписьТовара> Запись = new List<ЗаписьТовара>();       
            
        public void НоваяЗапись(ЗаписьТовара з)
        {
            Запись.Add(з);
        }
        public string ConwertString()
        {
            string sasSDA = "DSADS";
                return sasSDA;
        }
    }

}
