namespace GameDataParser.UserInteraction;

public class UserInteraction : IUserInteraction
{
    public string GetFileNameFromUser()
    {
        while (true)
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                return fileName;
            }
            else if (fileName is null)
            {
                System.Console.WriteLine("File name cannot be null.");
                continue;
            }
            else if (fileName.Length == 0)
            {
                System.Console.WriteLine("File name cannot be empty.");
                continue;
            }
            else
            {
                System.Console.WriteLine("File not found.");
                continue;
            }
        }
    }
}

