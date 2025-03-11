using System.IO;

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
        public static void EnsureInfoCompliesWithRestrictions(string text)
        {

        }
        // Ensure if Info Exists
        public static void EnsureRegistrationInfoExists(string file, string path)
        {

        }

    }
}