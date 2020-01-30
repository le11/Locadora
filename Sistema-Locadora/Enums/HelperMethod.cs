using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locadora.Enums
{
    class HelperMethod
    {
        public static IList<t> EnumToList<t>()
        {
            if (!typeof(Generos).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<t> list = new List<t>();
            Type type = typeof(Generos);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (t value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
    }
}
