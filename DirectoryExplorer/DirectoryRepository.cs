using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DirectoryExplorer
{
    public class DirectoryRepository : IDirectoryRepository
    {
        public string directoryPath ;
        public string newDirectoryCommand = "NEW";
        public string delDirectoryCommand = "DEL";
        public string yesCommand = "yes";
        public string noCommand = "no";
        public string continueInput = "yes";
        public void InputDirectoryPath()
        {
            while (string.IsNullOrEmpty(directoryPath))
            {
                Console.Write("Enter Path To Directory or a Command(NEW/DEL):");
                directoryPath = Console.ReadLine();
            }
        }
        public void ValidateCommand()
        {
            string possibleCommand = (directoryPath[0].ToString() + directoryPath[1].ToString() + directoryPath[2].ToString()).ToUpper();
            if (possibleCommand == newDirectoryCommand)
            {
                CreateNewDirectory();
            }else if(possibleCommand == delDirectoryCommand)
            {
                ValidateDeleteCommand();
            }
            
        }

        private void DeleteCurrentDirectory(string path)
        {
            try
            {
                Directory.Delete(path);
            }
            catch(Exception e)
            {
                Console.WriteLine("Directory Could not be found");
            }
        }

        private void CreateNewDirectory()
        {
            try
            {
                Directory.CreateDirectory(directoryPath.Substring(3).Trim());
            }
            catch(Exception e)
            {
                Console.WriteLine("Could not create a directory");
            }
        }

        public void UserInputContinueOrNot()
        {
            Console.WriteLine("Do You Want to Continue? (yes/no)");
            while (string.IsNullOrEmpty(continueInput) || continueInput != yesCommand || continueInput != noCommand)
            {
                Console.WriteLine("Invalid Input, Try again: ");
                continueInput = Console.ReadLine().ToLower();
            }
        }
        public bool UserWantsToContinue()
        {
            
            
            if(continueInput == yesCommand)
            {
                return true;
            }
            return false;
        }
        public bool DirectoryIsValid(string path)
        {
            if (Directory.Exists(path)) return true;
            Console.WriteLine("Enter Valid Path: ");
            InputDirectoryPath();
            return false;
        }

        public string inputDeleteValidationCommand()
        {
            Console.WriteLine("Are you sure you want to delete this directory? (yes/no)");

            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) || input != yesCommand || input != noCommand)
            {
                input = Console.ReadLine();
            }
            return input;
        }
        public void ValidateDeleteCommand()
        {
            if (inputDeleteValidationCommand() == yesCommand) 
            {
                DeleteCurrentDirectory(directoryPath.Substring(3).Trim()) ;
            }
            else
            {
                InputDirectoryPath();  
            }
            
        }

        public void ShowDirectoryFiles()
        {
            int filesCount = 0;
            int directoriesCount = 0;
            string[] files = Directory.GetFiles(directoryPath)
                                      .Select(Path.GetFileName)
                                      .ToArray();

            string[] dirs = Directory.GetDirectories(directoryPath)
                                      .Select(Path.GetFileName)
                                      .ToArray();

            Console.WriteLine("Files: ");
            foreach (string file in files)
            {
                filesCount++;
                Console.WriteLine($"{filesCount}.{files}");
            }
            Console.WriteLine("Directories: ");
            foreach (string dir in dirs)
            {
                directoriesCount++;
                Console.WriteLine($"{directoriesCount}. {dir}");

            }
        }
    }
}
