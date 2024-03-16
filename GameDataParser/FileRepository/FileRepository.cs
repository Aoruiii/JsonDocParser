namespace GameDataParser.FileRepository;

using System.Text.Json;
using GameDataParser.VideoGame;
using GameDataParser.ExceptionHandling;

public class FileRepository : IFileRepository
{
    public IEnumerable<VideoGame> Read(string fileName)
    {
        string jsonContent = File.ReadAllText(fileName);
        try
        {
            var videoGames = JsonSerializer.Deserialize<IEnumerable<VideoGame>>(jsonContent);
            return videoGames;
        }
        catch (JsonException ex)
        {
            throw new JsonNotInValidFormatException($"JSON in the {fileName}  was not in a valid format. JSON body:" + jsonContent, ex);
        }
    }

}