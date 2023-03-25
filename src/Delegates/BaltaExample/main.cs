using BaltaExample.Models;

namespace BaltaExample
{
    public static class MainProgram
    {
        // can be declared inside or outside of the class
        private delegate void OnSuccessDelegate(IEnumerable<ArticleModel> data);
        private delegate void OnErrorDelegate(ErrorModel data);

        public static void main()
        {
            OnSuccessDelegate OnSuccessHandler = OnSuccess;
            OnErrorDelegate OnErrorHandler = OnError;
            Func<IEnumerable<ArticleModel>, string> PrintCompleteArticleData;

            GetArticles(OnSuccessHandler, OnErrorHandler);

            Console.WriteLine("Finished program.");
        }

        private static void OnSuccess(IEnumerable<ArticleModel> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.Title);
            }            
        }

        private static void OnError(ErrorModel data)
        {
            Console.WriteLine($"ERRO: {data.Message}");
        }

        private static void GetArticles(OnSuccessDelegate onSuccess, OnErrorDelegate onError)
        {
            try
            {
                var data = new List<ArticleModel>();
                data.Add(new ArticleModel(1, "Artigo 1"));
                data.Add(new ArticleModel(2, "Artigo 2"));
                // throw new Exception("Erro");
                onSuccess(data);
            }
            catch (Exception ex)
            {
                onError(new ErrorModel($"Ocorreu um erro: {ex.Message}"));
                throw;
            }
        }
    }
}