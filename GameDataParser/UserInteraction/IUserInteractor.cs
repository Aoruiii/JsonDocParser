namespace GameDataParser.UserInteraction;


public interface IUserInteractor
{
    string GetFileNameFromUser();

    void PrintMessage(string message);
    void PrintError(string message);
}

