using System.Text;

namespace HomeworkProgram
{
    public static class BilderExt
    {
        public static string BilderEx(this StringBuilder input, int index, int length)
        {
            return input.ToString().Substring(index, length);
        }

        public static string BilderEx(this StringBuilder input, int index)
        {
            return input.ToString().Substring(index);
        }
    }
}