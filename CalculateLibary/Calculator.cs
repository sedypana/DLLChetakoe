using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibary
{
    
    public class DllFile
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float lenght)
        {
            double result = -1;
            switch (productType)
            {
                case 1:
                    result = width * lenght * count * 1.1;
                    break;
                case 2:
                    result = width * lenght * count * 2.5;
                    break;
                    case 3:
                    result = width * lenght * count * 8.43;
                    break;
                    default:
                    return -1;
            }
            switch(materialType)
            {
                case 1:
                    result *= 1.883;
                    break;
                    case 2:
                    result *= 1.8012;
                    break;
                    default :
                    return -1;
            }
            return (int)Math.Ceiling(result);
            
        }

    }
}
