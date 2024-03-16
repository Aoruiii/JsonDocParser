namespace GameDataParser.App;

using GameDataParser.UserInteraction;
using GameDataParser.FileRepository;
using GameDataParser.ExceptionHandling;
using GameDataParser.VideoGame;


public class GameDataParserProgram
{
    private IUserInteraction _userInteraction;
    private IFileRepository _fileRepository;


    public GameDataParserProgram(IUserInteraction userInteraction, IFileRepository fileRepository)
    {
        _userInteraction = userInteraction;
        _fileRepository = fileRepository;
    }

    public void Run()
    {
        var fileName = _userInteraction.GetFileNameFromUser();
        IEnumerable<VideoGame> videoGames = default;
        try
        {
            videoGames = _fileRepository.Read(fileName);
        }
        catch (JsonNotInValidFormatException ex)
        {
            var originalConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = originalConsoleColor;
            throw;
        }

        if (videoGames.Count() > 0)
        {
            Console.WriteLine("Loaded games are:");
            foreach (VideoGame videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
        }

    }
}