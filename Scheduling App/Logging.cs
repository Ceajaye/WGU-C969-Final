using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    public static class Logging
    {
        private static string fileName = "activty_log.txt";

        public static void logActivity(User user)
        {
            bool fileDoesNotExists = false;
            string previousFile = "";

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader fileReader = new StreamReader(input);
                previousFile = fileReader.ReadToEnd().Trim();
                input.Close();
            }
            catch (IOException)
            {
                fileDoesNotExists = true;
            }
            finally
            {
                FileStream output = new FileStream(fileName, FileMode.Create);
                StreamWriter fileWriter = new StreamWriter(output);
                string currentLog = $"The user \"{user.UserName}\" logged in on {DateTime.Now.ToUniversalTime()} (UTC).";

                if (fileDoesNotExists)
                {
                    fileWriter.WriteLine(currentLog);
                    fileWriter.Close();
                }
                else
                {
                    fileWriter.WriteLine(previousFile);
                    fileWriter.WriteLine(currentLog);
                    fileWriter.Close();
                }
            }
        }
    }
}
