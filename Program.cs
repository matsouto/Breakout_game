namespace Breakout;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        var v1 = new Vector2(1,1);
        var v2 = new Vector2(3,2);
        int scalar = 2;

        var v3 = v1 + v2;
        var v4 = v2 * scalar;
        var v5 = v1 / scalar;

        
    }    
}