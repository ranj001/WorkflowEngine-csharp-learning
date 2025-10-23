namespace WorkflowEngine
{
    public interface IWorkflowActivity<T>
    {
        void Execute(T Activity);
    }
}