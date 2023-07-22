using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class RegEx
    {
        private string mobiles;
        public int WordCount(string name)
        {
            string[] words=name.Split(new char[] { ' ', },StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public List<string> EmailValidate(string email)
        {
            List<string> Email = new List<string>();
            string empattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            Regex r = new Regex(empattern);
            foreach (Match emailid in r.Matches(email))
            {
                Email.Add(emailid.Value);
            }
            return Email;
        }

        public List<string> ExtractMobileNumbers(string data) 
        {
            List<string> mobiles = new List<string>();
            string mbpattern = @"\b\d{10}\b";
            Regex r = new Regex(mbpattern);
            foreach (Match Mobile in r.Matches(data))
            {
                mobiles.Add(Mobile.Value);  
            }
            return mobiles;
        }
       
        public List<string> customregex(string data,string Pattern ) 
        {

            List<string> regxpatten = new List<string>();
            foreach (Match pattern in Regex.Matches(data, Pattern))
            {
                regxpatten.Add(pattern.Value);
            }
            return regxpatten;
        }
        public void Results(string text)
        {
            Console.WriteLine("Words count is:"+WordCount(text));
            var mobilenums = ExtractMobileNumbers(text);
            if (mobilenums.Count>0)
            {
                Console.WriteLine("Mobile Numbers Found");
                foreach (var mobilenum in mobilenums)
                {
                    Console.WriteLine(mobilenum);
                }
            }
            else
            {
                Console.WriteLine("Mobile Numbers Not Found");
            }

            var emails = EmailValidate(text);
            if (emails.Count > 0)
            {
                Console.WriteLine("Emails Found");
                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                }
            }
            else
            {
                Console.WriteLine("Emails Not Found");
            }

            Console.Write("Enter a custom regex pattern :\t");
            String Pattern=Console.ReadLine();
            List<string> data = customregex(text, Pattern);
            if(data.Count > 0)
            {
                Console.WriteLine("custom regex found");
                foreach (var pattern in data)
                {
                    Console.WriteLine("Founded custom regex's are:"+pattern);
                }

            }
            else
            {
                Console.WriteLine("No regex are found");
            }


        }
    }
}
