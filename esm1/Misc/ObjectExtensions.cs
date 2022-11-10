using System.Text;
using System.Reflection;
using System.Collections;

namespace esm1.Misc
{

    /// <summary>
    /// A class that adds miscellaneous extension methods to objects.
    /// </summary>
    public static class ObjectExtensions
    {

        /// <summary>
        /// Represents the current indentation level when printing.
        /// </summary>
        private static int indentationLevel;

        /// <summary>
        /// Enables any <see cref="object"/> to invoke this method, to
        /// "ToString" all its <see cref="PropertyInfo"/>s.
        /// <para>
        /// So now you could override the <see cref="object.ToString"/> method with:
        /// <example>
        /// <code>
        /// public override string ToString()
        /// {
        ///     return this.ToStringExtension();
        /// }
        /// </code>
        /// </example>
        /// </para>
        /// </summary>
        /// <param name="obj">
        /// Any <see cref="object"/> that has <see cref="PropertyInfo"/>s to
        /// print.
        /// </param>
        /// <returns>
        /// A formatted <see cref="string"/> that resembles all the
        /// <see cref="PropertyInfo"/>s of the given <see cref="object"/>.
        /// </returns>
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

        /// <summary>
        /// Enables any <see cref="IEnumerable"/> to invoke this method, to
        /// "ToString" all its elements.
        /// <para>
        /// So now you could override the <see cref="object.ToString"/> method with:
        /// <example>
        /// <code>
        /// public override string ToString()
        /// {
        ///     return this.ToStringEnumerableExtension();
        /// }
        /// </code>
        /// </example>
        /// </para>
        /// </summary>
        /// <param name="enumerable">Any <see cref="IEnumerable"/>.</param>
        /// <returns>
        /// A formatted <see cref="string"/> that resembles all the
        /// elements of the given <see cref="IEnumerable"/>.
        /// </returns>
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
