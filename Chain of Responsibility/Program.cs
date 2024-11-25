using Chain_of_Responsibility;

internal class Program
{
    private static void Main(string[] args)
    {
        var userError  = new UserErrorHandler();
        var serverError = new ServerErrorHandler();
        userError.SetNextHandler(serverError);
        var serverErrorRequest = new Request();
        serverErrorRequest.Type = "Server Error";
        serverErrorRequest.Message = "Краснов сервер почини";
        var userErrorRequest = new Request();
        userErrorRequest.Type = "User Error";
        userErrorRequest.Message = "Перваки опять засрали диск G роблоксом";
        var unknownRequest = new Request();
        unknownRequest.Type = "Unknown";
        unknownRequest.Message = "Unknown";
        userError.Handle(serverErrorRequest);
        userError.Handle(userErrorRequest);
        userError.Handle(unknownRequest);
        
    }
}