namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string Date = "10/12/1997";
        Console.WriteLine($"{Date} = {DateFormatter.ChangeFormat(Date)}");
    }
}