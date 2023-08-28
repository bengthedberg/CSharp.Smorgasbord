using CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.Events;

namespace CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.SubscriberServices;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine($"MailService: Sending an email... {args.Video.Title}");
    }
}