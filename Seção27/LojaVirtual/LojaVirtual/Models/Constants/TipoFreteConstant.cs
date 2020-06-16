using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Constants
{
    public class TipoFreteConstant
    {
        public const string PAC = "04510";
        public const string SEDEX = "04014";
        public const string SEDEX10 = "04790";

        public static string GetName(string code)
        {

            foreach (var field in typeof(TipoFreteConstant).GetFields())
            {
                if ((string)field.GetValue(null) == code)
                {
                    return field.Name.ToString();
                }
            }

            return "";
        }
        
    }
}
