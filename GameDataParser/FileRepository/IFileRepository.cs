namespace GameDataParser.FileRepository;
using GameDataParser.VideoGame;

public interface IFileRepository
{
    public IEnumerable<VideoGame> Read(string fileNama);
}
