namespace WorkflowEngine
{
    public class UploadVideoActivity : IWorkflowActivity<Video>
    {

        public void Execute(Video video)
        {
            // Logic to upload a video
            Console.WriteLine("Uploading video...");
        }
    }
}