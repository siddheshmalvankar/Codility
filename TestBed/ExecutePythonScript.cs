using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    public class ExecutePythonScript
    {
        public void ExecutePyhthonProcess()
        {
            //1 Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\ZP844KY\AppData\Local\Programs\Python\Python37\python.exe";

            //2. Provide Script and arguments
            var script = @"C:\Users\ZP844KY\Downloads\SachinThorat\SachinThorat\Automation_Framework\test_sites\tests\tests\test_apis.py";
            var resultPath = @"C:\sidd\results";
            var baseurl= @"https://login.ey.com/";

            //3 Arguments
            psi.Arguments = $"\"{script} --base-url {baseurl} --alluredir \"\"{resultPath}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //Execute process and get output
            var errors = "";
            var results = "";

            using (var process= Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();

            }

            //Display output
            Console.WriteLine("Errors");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine(results);

        }
    }
}
