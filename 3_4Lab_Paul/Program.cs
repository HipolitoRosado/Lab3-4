using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern0 = @"[d-e]";
        string pattern1 = @"[d-e][*d]";
        string pattern2 = @"[a][a-z][a]";
        string pattern3 = @"[][p][a-z]*";
        string pattern4 = @"[a-z]*[e][]";
        string pattern5 = @"[A-Z]";




        string input = @"Episode IV, A NEW HOPE It is a period of civil war.
        Rebel spaceships, striking from a hidden base, have won their first victory 
        against the evil Galactic Empire. During the battle, Rebel spies managed to steal 
        secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station
        with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, 
        Princess Leia races home aboard her starship, custodian of the stolen plans that 
        can save her people and restore freedom to the galaxy....";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern0, options))
       
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        foreach (Match m in Regex.Matches(input, pattern1, options))

        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        foreach (Match m in Regex.Matches(input, pattern2, options))

        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        foreach (Match m in Regex.Matches(input, pattern3, options))

        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        foreach (Match m in Regex.Matches(input, pattern4, options))

        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        foreach (Match m in Regex.Matches(input, pattern5, options))

        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
        

    }
}


