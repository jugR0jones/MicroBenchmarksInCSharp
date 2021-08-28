namespace IntegerAsStringFormatting
{
    public class FixedWidthFormatter
    {
        public static string OutputAs000(int input)
        {
            char[] chArr = new char[3];

            int a = input / 10;

            chArr[2] = (char)(48 + input - (a * 10));
            int c = a / 10;
            chArr[0] = (char)(48 + c);
            chArr[1] = (char)(48 + a - (c * 10));

            string output = new string(chArr);
            return output;
        }
    }
}