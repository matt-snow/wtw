using System;
using System.Collections.Generic;

namespace MattSnowWTW
{
    public class Solution
    {
        public int NumberOfUniqueEmailAddresses(string[] emails)
        {
            List<string> uniqueEmails = new List<string>();

            foreach(string email in emails)
            {
                string[] explodedEmail = email.ToLower().Split("@");
                string local = explodedEmail[0].Split("+")[0].Replace(".", "");
                string strippedEmail = local + "@" + explodedEmail[1];
                if(!uniqueEmails.Contains(strippedEmail))
                {
                    uniqueEmails.Add(strippedEmail);
                }
            }
            return(uniqueEmails.Count);
        }
    }
}