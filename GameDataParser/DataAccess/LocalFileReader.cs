namespace GameDataParser.FileRepository;

using System.Text.Json;
using GameDataParser.VideoGame;
using GameDataParser.ExceptionHandling;

public class LocalFileReader : IFileReader
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
            throw new JsonException($"JSON in the {fileName}  was not in a valid format. JSON body:" + jsonContent, ex);
        }
    }

}