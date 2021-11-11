using System;

public class Username
{
    public static bool Validate(string username)
    {
        var underScore = "_";
        bool isLetter = !String.IsNullOrEmpty(username) && Char.IsLetter(username[0]);

        if (username?.Length < 4)
        {
            return false;
        }

        if (username.StartsWith(isLetter.ToString()))
        {
            return false;
        }

        if (username.EndsWith(underScore))
        {
            return false;
        }

        if (username?.Length > 4)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Validate("Mike_Standish")); // Valid username
        Console.WriteLine(Validate("Mik")); // Invalid username less than 4 characters
        Console.WriteLine(Validate("Mike_Standish_")); // Invalid username ends with _

    }
}