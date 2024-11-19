using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
   public class type_operation
    {       
      static public type Operation(int number)
        {
            switch(number)
            {
                case  1:

                    return type.distance;

                case 2 :
                   
                    return type.acceleration;

                case 3:
                    
                    return type.motion_coordinates;

                case  4: 
                    return type.save;

                default:
                    return type.error;
                    
            }
        }
        

    }
}
