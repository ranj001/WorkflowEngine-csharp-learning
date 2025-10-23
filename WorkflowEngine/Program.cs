namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry point for the Workflow Engine application
            var workflowEngine = new WorkflowEngine();

            workflowEngine.Run(new UploadVideoActivity(), new Video());
            workflowEngine.Run(new VideoEncodingActivity(), new CallNotification());
            workflowEngine.Run(new VideoNotificationActivity(), new MailNotification());
            workflowEngine.Run(new VideoChangeStatusActivity(), new VideoStatus());
        }
    }
}