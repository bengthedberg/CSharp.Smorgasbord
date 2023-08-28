using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.Events;

public class VideoEventArgs
{
    public Video Video { get; internal set; }

    public VideoEventArgs(Video video)
    {
        Video = video;
    }
}
