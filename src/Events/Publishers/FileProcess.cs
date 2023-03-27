namespace Events.Publishers
{
    public delegate void Notify();

    // publisher class
    public class FileProcess
    {
        // event is an encapsulated delegate, delegate Notify, event ProcessCompleted of delegate type Notify
        public event Notify? ProcessCompleted;

        public void StartProcessingFile()
        {
            Console.WriteLine("Processing file...");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}