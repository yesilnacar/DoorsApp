using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace DoorsApp.Core.Helpers
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            string description = null;

            if (e is Enum)
            {
                var type = e.GetType();
                var values = Enum.GetValues(type);

                var descValues = values.Cast<Enums.State>().Where(p => (int)p == e.ToInt32(CultureInfo.InvariantCulture));
                foreach (var state in descValues)
                {
                    var val = (int)state;
                    if (val != e.ToInt32(CultureInfo.InvariantCulture))
                        continue;

                    var memInfo = type.GetMember(type.GetEnumName(val));
                    var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (descriptionAttributes.Length > 0)
                        description = ((DescriptionAttribute)descriptionAttributes[0]).Description;

                    break;
                }
            }

            return description;
        }
    }
}
