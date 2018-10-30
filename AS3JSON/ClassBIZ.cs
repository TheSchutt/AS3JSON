using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityRepository;
using Newtonsoft.Json;

namespace AS3JSON
{
   public class ClassBIZ
    {
        public ClassBIZ()
        {

        }
        public DollarRates useJSON(string value)
        {
            DollarRates DR = JsonConvert.DeserializeObject<DollarRates>(value);
            return DR;
        }
    }
}
