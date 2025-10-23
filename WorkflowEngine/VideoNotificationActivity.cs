namespace WorkflowEngine
{
    public class VideoNotificationActivity : IWorkflowActivity<MailNotification>
    {
        public void Execute(MailNotification mail)
        {
            // Logic to send video notification
            Console.WriteLine("Sending email notification...");
        }
    }
}