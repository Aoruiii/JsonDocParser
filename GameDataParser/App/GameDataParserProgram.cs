namespace GameDataParser.App;

using GameDataParser.UserInteraction;
using GameDataParser.FileRepository;
using GameDataParser.ExceptionHandling;
using GameDataParser.VideoGame;
using System.Text.Json;


public class GameDataParserProgram
{
    private readonly IUserInteractor _userInteraction;
    private readonly IFileReader _fileReader;




    public GameDataParserProgram(IUserInteractor userInteraction, IFileReader fileReader)
    {
        _userInteraction = userInteraction;
        _fileReader = fileReader;
    }

    public void Run()
    {
        var fileName = _userInteraction.GetFileNameFromUser();
        IEnumerable<VideoGame> videoGames = default;
        try
        {
            videoGames = _fileReader.Read(fileName);
        }
        catch (JsonException ex)
        {
            _userInteraction.PrintError(ex.Message);
            throw;
        }

        if (videoGames.Count() > 0)
        {
            _userInteraction.PrintMessage("Loaded games are:");
            foreach (VideoGame videoGame in videoGames)
            {
                _userInteraction.PrintMessage(videoGame.ToString());
            }
        }

    }
}