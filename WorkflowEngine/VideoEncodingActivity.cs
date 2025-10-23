using System.Text;

namespace WorkflowEngine
{
    public class VideoEncodingActivity : IWorkflowActivity<CallNotification>
    {
        public void Execute(CallNotification callNotification)
        {
            // Logic to encode a video
            Console.WriteLine("Sending a call that video is ready for encodeing...");
        }
    }
}