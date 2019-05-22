namespace AdaptorPattern.Adaptee
{
    public class VlcPlayer : IMedia
    {
        public void PlayMp4(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            System.Console.WriteLine("Playing file " + fileName);
        }
    }
}