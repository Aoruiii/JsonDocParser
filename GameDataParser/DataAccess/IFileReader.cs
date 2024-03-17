namespace GameDataParser.FileRepository;
using GameDataParser.VideoGame;

public interface IFileReader
{
    public IEnumerable<VideoGame> Read(string fileNama);
}
