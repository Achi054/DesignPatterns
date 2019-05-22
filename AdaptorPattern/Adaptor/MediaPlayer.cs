using AdaptorPattern.Adaptee;

namespace AdaptorPattern.Adaptor
{
    public class MediaPlayer : IMediaPlayer
    {
        private IMedia media;

        public MediaPlayer(PlayerType type)
        {
            switch (type)
            {
                case PlayerType.VLC:
                    media = new VlcPlayer();
                    break;
                case PlayerType.MP4:
                    media = new Mp4Player();
                    break;
                default:
                    throw new System.InvalidOperationException();
            }
        }
        public void Play(PlayerType audioType, string fileName)
        {
            if (audioType == PlayerType.VLC)
                media.PlayVlc(fileName);
            else
                media.PlayMp4(fileName);
        }
    }
}