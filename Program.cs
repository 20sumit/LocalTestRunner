using System;
using System.IO;

class Program
{
    static int Main(string[] args)
    {
        try
        {
            // Simulate tests and write a result file with PASS content.
            // comment change

            var resultText = "PASS"; // change to "FAIL" to test failing pipeline
            File.WriteAllText("result.txt", resultText);
            Console.WriteLine("Result written to result.txt: " + resultText);

            // Exit code 0 for success. We rely on the result.txt contents for pipeline logic.
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Failed to write result: " + ex);
            // If writing fails, write FAIL to file as fallback
            try { File.WriteAllText("result.txt", "FAIL"); } catch { }
            return 1;
        }
    }
}
