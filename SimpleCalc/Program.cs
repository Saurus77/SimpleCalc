using SimpleCalc.Data;

namespace SimpleCalc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new SimpleCalcDbContext())
            {
                db.Database.EnsureCreated();
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //string expr = "2+3(1)2";
            //Console.WriteLine(expr);
            //Console.WriteLine();
            //var tokens = Tokenizer.Tokenize(expr);
            //foreach (var token in tokens)
            //{
            //    Console.WriteLine(token);
            //}
            //Console.WriteLine();
            //Console.WriteLine(CalculationLogic.CountTokens(tokens));


        }
    }
}