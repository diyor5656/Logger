
class Program
{
    static void Main(string[] args)
    {
        ICustomLogger logger = new CustomLogger();
    
        logger.LogInformation("Console dasturi boshlandi.");
        logger.LogWarning("Bu ogohlantirish logi.");
        logger.LogError("Bu xato logi.");
    }
}
