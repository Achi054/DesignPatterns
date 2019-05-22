namespace AdaptorPattern.Adaptee
{
    public class Mp4Player : IMedia
    {
        public void PlayMp4(string fileName)
        {
            System.Console.WriteLine("Playing file " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}