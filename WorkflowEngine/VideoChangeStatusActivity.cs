namespace WorkflowEngine
{
    public class VideoChangeStatusActivity : IWorkflowActivity<VideoStatus>
    {
        public void Execute(VideoStatus videoStatus)
        {
            // Logic to change video status
            Console.WriteLine("Change video status to \"Processing\"...");
        }
    }
}