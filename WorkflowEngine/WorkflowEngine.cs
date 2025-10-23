namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IWorkflowActivity<object>> _workflows;

        public WorkflowEngine()
        {
            _workflows = new List<IWorkflowActivity<object>>(); 
        }

        public void Run<T>(IWorkflowActivity<T> workflows, T whatItem)
        {
            // Execute each workflow
            workflows.Execute(whatItem);
        }
    }
}