using System.Text;
using System.Reflection;
using System.Collections;

namespace esm1.Misc
{
    public static class ObjectExtensions
    {
        private static int indentationLevel;

        public static string ToStringExtension(this object obj)
        {
            StringBuilder stringBuilder = new();
            int i = 0;
            StringIndentation.NewLine(stringBuilder, indentationLevel);
            stringBuilder.Append('{');
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.GetType().GetProperties().Length > 0)
                {
                    indentationLevel++;
                    StringIndentation.NewLine(stringBuilder,
                        indentationLevel);
                }

                stringBuilder.Append(property.Name);
                stringBuilder.Append(": ");
                if (property.GetIndexParameters().Length > 0)
                {
                    stringBuilder.Append("Indexed Property cannot be used");
                }
                else
                {
                    stringBuilder.Append(property.GetValue(obj, null));
                }

                i++;

                if (i < obj.GetType().GetProperties().Length)
                {
                    stringBuilder.Append(',');
                }

                indentationLevel--;
            }

            StringIndentation.NewLine(stringBuilder, indentationLevel);
            stringBuilder.Append('}');

            return stringBuilder.ToString();
        }

        public static string ToStringEnumerableExtension(this IEnumerable enumerable)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append('[');
            indentationLevel++;
            foreach (var item in enumerable)
            {
                stringBuilder.Append(item.ToStringExtension());
                stringBuilder.Append(',');
            }
            indentationLevel--;
            StringIndentation.NewLine(stringBuilder, indentationLevel);
            stringBuilder.Append(']');

            return stringBuilder.ToString();
        }
    }
}
