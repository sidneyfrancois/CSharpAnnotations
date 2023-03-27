namespace Events.Publishers
{
    // publisher class
    public class ProcessingFiles
    {
        // event is an encapsulated delegate, delegate Notify, event ProcessCompleted of delegate type Notify
        public event Notify ProcessCompleted;

        public void StartProcessingFile()
        {
            Console.WriteLine("Processing file...");
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}