namespace BookStore.UI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl { get; } = "https://localhost:44358/"; // API
        public static string AuthorsEndpoint { get; } = $"{BaseUrl}api/authors/";
        public static string BooksEndpoint { get; } = $"{BaseUrl}api/books/";
        public static string RegisterEndpoint { get; } = $"{BaseUrl}api/users/register";
        public static string LoginEndpoint { get; } = $"{BaseUrl}api/users/login";
    }

}
