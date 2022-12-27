namespace Quiz
{
    public static class DiConfig
    {
        public static void UseQuiz(this IServiceCollection services)
        {

            UseRepository(services);
            UseService(services);
        }

        private static void UseRepository(this IServiceCollection services)
        {
           

        }
        private static void UseService(this IServiceCollection services)
        {
            
        }
    }
}
