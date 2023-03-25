namespace BaltaExample
{
    public static class MainProgram
    {
        // can be declared inside or outside of the class
        private delegate void OnSuccessDelegate(IEnumerable<ArticleModel> data);
        private delegate void OnErrorDelegate(ErrorModel data);

        static void main()
        {
            OnSuccessDelegate OnSuccessHandler = OnSucess;
            OnErrorDelegate OnErrorHandler = OnError;
        }
    }
}