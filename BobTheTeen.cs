using System;
using System.Text.RegularExpressions;

namespace BobTheTeen
{
    public class Program
    {
        static void Main(string[] args)
        {
	    string userSentence  = args[0];
            Bob bob = new Bob();
            bob.Response(userSentence);
        }
    }
      
    public class Bob
    {
        private string[] response;
	private Regex[]  bobsBrainRegex;
	public Bob(){
	    response = new String[5];
            response[0] = "Whoa, chill out!";
	    response[1] = "Whatever.";			 
	    response[2] = "Sure.";				 
	    response[3] = "Fine. Be that way!";		 
	    response[4] = "Calm down, I know what I'm doing!";

	    bobsBrainRegex = new Regex[5];
	    bobsBrainRegex[0] = new Regex("(^[A-Z]+$)|(^[A-Z1-9,\\s]+!$)");
	    bobsBrainRegex[1] = new Regex("(\\.$)|([0-9]$)|(^[A-Z].+?!$)|([a-z]\\s+$)");
	    bobsBrainRegex[2] = new Regex(".[^A-Z]\\?\\s*$");
	    bobsBrainRegex[3] = new Regex("(^\\s*)$");
	    bobsBrainRegex[4] = new Regex("^[A-Z\\s]+\\?$");
	    
	}

        public string Response(string sentence)
        {
            bool[] regexMatch = new bool[5] {false, false, false, false, false};

	    for(int i = 0;i<5;i++){
	        if (bobsBrainRegex[i].IsMatch(sentence))
                {
		    regexMatch[i] = true;
                    Console.WriteLine(response[i]);
                }
	    }
		    
	    if(!regexMatch[0] && !regexMatch[1] && !regexMatch[1] && !regexMatch[2] && !regexMatch[3] && !regexMatch[4]) 
            {
                Console.WriteLine("It doesnt work!");
            }
            return sentence;
        }
    }
}
