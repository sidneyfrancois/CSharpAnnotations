using Events.Publishers;

namespace Events.Subscribers
{
    public static class FileMethods
    {
        public static void MainMethod()
        {
            FileProcess fp = new FileProcess();
            fp.ProcessCompleted += FileProcessCompleted;
            fp.StartProcessingFile();
        }

        public static void FileProcessCompleted()
        {
            Console.WriteLine("File processing completed...");
        }
    }
}