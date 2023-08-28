using CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.PublishService;
using CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample.SubscriberServices;
using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.EventAndDelegate.VideoEncodingExample;

public class PubSubExampleVideoEncoding
{
    public static void Run()
    {
        var video = new Video { Title = "Video 1" };
        var videoEncoder = new VideoEncoder(); // publisher
        
        var mailService = new MailService(); // subscriber
        var messageService = new MessageService(); // subscriber

        // Subscribe to the event
        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }
}