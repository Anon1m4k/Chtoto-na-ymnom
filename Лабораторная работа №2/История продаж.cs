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
        
        List<ЗаписьТовара> Запись = new List<ЗаписьТовара>();       
            
        public void НоваяЗапись(ЗаписьТовара з)
        {
            Запись.Add(з);
        }
        public string ConwertString()
        {
            string res = " ";
            
            for (int i = 0 ; i < Запись.Count; i++)
            {
                ЗаписьТовара s = Запись[i];
                res += Convert.ToString(s.День);
                res += Convert.ToString(s.Количество);
                res +=s.Товар.СкажиНазвание();
            }
            return res;
        }
    }

}
