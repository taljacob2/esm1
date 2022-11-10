using System.Text;

namespace esm1.Misc
{

    /// <summary>
    /// A class that helps building strings with indentation.
    /// </summary>
    /// <seealso cref="ObjectExtensions"/>
    public static class StringIndentation
    {
        public static void NewLine(StringBuilder stringBuilder,
            int indentationLevel)
        {
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Create(indentationLevel));
        }

        public static string Create(int indentationLevel)
        {
            StringBuilder builder = new();
            for (int i = 1; i <= indentationLevel; i++)
            {
                builder.Append("    ");
            }

            return builder.ToString();
        }
    }
}
