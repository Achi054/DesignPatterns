namespace AdaptorPattern.Adaptor
{
    public interface IMediaPlayer
    {
        void Play(PlayerType audioType, string fileName);
    }
}