/*
            Huynh Nhut Linh 20521530
            Nguyễn Văn Luân 20521584
            Lê Huỳnh Anh Kiên 20521487
            Nguyễn Tuấn Kiệt 20521499
         */


/*Implement a function which convert the given boolean value into its string representation.

Note: Only valid inputs will be given.*/

public static string boolean_to_string(bool b)
{
    return b.ToString();
}

/*Very simple, given an integer or a floating-point number, find its opposite.
*/
public static int Opposite(int number)
{
    return -number;
}

/*Given an array of integers, return a new array with each value doubled.*/

public static int[] Maps(int[] x)
{
    for (int i = 0; i < x.Lenght; i++)
    {

    }

    return x;
}
//It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string.
//You're given one parameter, the original string. You don't have to worry with strings with less than two characters.
public static string Remove_char(string s)
            {
                s = s.Substring(1, s.Length - 2);
                return s;
            }
