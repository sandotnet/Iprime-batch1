namespace HandsOnProgramFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args); //using builder instance we configute services to the project
            var app = builder.Build(); //using app instance we configre the middlewares

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
