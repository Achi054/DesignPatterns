namespace AdaptorPattern.Adaptee
{
    public interface IMedia
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }
}