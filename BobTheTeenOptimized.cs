using System;
using System.Linq;

namespace Bob
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userSentence = Console.ReadLine();
            Console.WriteLine(Response(userSentence));
        }

        public static string Response(string sentence) =>
            sentence switch
            {
                var s when s.EndsWith("?") && s.Any(char.IsUpper) => "Calm down, I know what I'm doing!",
                var s when s.EndsWith("?") => "Sure.",
                var s when s.Any(char.IsUpper) => "Whoa, chill out!",
                var s when s.Equals("") => "Fine. Be that way!",
                _ => "Whatever."
            };
    }
}