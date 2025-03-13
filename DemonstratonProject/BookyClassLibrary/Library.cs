using System.IO;
using System.Text.RegularExpressions;

namespace BookyClassLibrary
{
    public class DirectoryUtilities
    {
        // Ensure Directory Exists
        public static void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        // Ensure File Exists
        public static void EnsureFilesExists(string file, string path)
        {
            string fullPath = Path.Combine(path, file); // Parent folder
            {
                if (!File.Exists(fullPath))
                {
                    File.Create(fullPath).Dispose(); // Will later read about why copilot suggested to use Dispose(), originally I didn't use it as a functionality.
                }
                /*else if (File.Exists((file)))
                {
                    MessageBox.Show("Sorry, but we detected you got registration, please click on Log In");
                }*/
            }
        }

        // Ensure Text is in proper format
        public static bool EnsureNamesComplyWithRestrictions(string text, string file, string path)
        {
            string regex = @"^[A-Z][a-z]+";
            string fullPath = Path.Combine(path, file);
            if (Regex.IsMatch(text, regex))
            {
                    string fileContents = File.Exists(fullPath) ? File.ReadAllText(fullPath) : string.Empty;
                    if (!fileContents.Contains(text))
                    {
                        File.AppendAllText(fullPath, text + " ");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Sorry but this username exists on this computer");
                        MessageBox.Show($"You can manually change that by going to {path}");
                        return true;
                    }
            }
            else
            {
                MessageBox.Show("Invalid Name format. Please use the following format - \"Name\"");
                return false;
            }
        }
        // Ensure if Info Exists
        public static void EnsureRegistrationInfoExists(string file, string path)
        {

        }

    }
}