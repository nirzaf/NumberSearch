using static System.Console;

var arr = Find.Numbers("88Hello 3World!");
WriteLine(arr);



public static class Find{

//find all numbers and add into array from a string input
   public static int Numbers(string str)
   {
        // A temporary string
        string temp = "0";
 
        // holds sum of all numbers
        // present in the string
        int sum = 0;
 
        // read each character in input string
        for (int i = 0; i < str.Length; i++) {
            char ch = str[i];
 
            // if current character is a digit
            if (char.IsDigit(ch))
                temp += ch;
 
            // if current character is an alphabet
            else {
 
                // increment sum by number found earlier
                // (if any)
                sum += int.Parse(temp);
 
                // reset temporary string to empty
                temp = "0";
            }
        }
 
        // atoi(temp.c_str()) takes care of trailing
        // numbers
        return sum + int.Parse(temp);
    }

}
