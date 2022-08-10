namespace Client
{
    class Program // добавил новую ветку , и коментарий чтобы вспомнить как клонировать репозитории
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш клиент");
            OurClient ourClient = new OurClient();
        }
    }
}