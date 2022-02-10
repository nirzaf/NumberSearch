using static System.Char;
using static System.Console;

var arr = Find.Numbers("88Hello 3World!");
WriteLine(arr);



public static class Find
{
    public static int Numbers(string str)
    {
       string temp = "0";

        int sum = 0;

        foreach (char ch in str)
        {
            if (IsDigit(ch))
                temp += ch;
            else {
                sum += int.Parse(temp);
                temp = "0";
            }
        }
        return sum + int.Parse(temp);
    }
}
