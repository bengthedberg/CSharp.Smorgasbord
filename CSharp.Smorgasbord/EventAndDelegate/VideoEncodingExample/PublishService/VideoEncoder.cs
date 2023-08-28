using CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.Events;
using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.PublishService;
public class VideoEncoder
{
    public event EventHandler<VideoEventArgs> VideoEncoded = null!;
    //  The above is a shorthand for :
    //  public delegate void VideoEncodedHandler(object sender, VideoEventArgs args);
    //  public event VideoEncodedHandler VideoEncoded = null!;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000); // Simulate encoding
        OnVideoEncoded(video);
    }

    // Event Handler
    // This is the method that raises the event. Both publisher and subscriber have access to this method, but only the publisher should call it. 
    // It is the contract between publisher and subscriber.
    public void OnVideoEncoded(Video video)
    {
        VideoEncoded?.Invoke(this, new VideoEventArgs(video));
    }
}