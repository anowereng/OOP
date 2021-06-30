using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public static class EnumService<T> where T : Enum
    {
        public static string[] AllNames => Enum.GetNames(typeof(T)).ToArray();

        public static string Name(object name) => Enum.GetName(typeof(T), name);

        public static T[] ConvertRequestModelToEnumArray(string [] reqEnums)
        {
            var selectedEnum = AllNames.Where(x => reqEnums.Contains(x));
            var selectedEnumToArray = selectedEnum.Select(x => (T)Enum.Parse(typeof(T), x)).ToArray();
            return selectedEnumToArray;
        }

    }
}
