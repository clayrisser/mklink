ï»¿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkLink {
    class MyMethods {
    
        public static string getOutput() {

Process p = new Process();
p.StartInfo.UseShellExecute = false;
p.StartInfo.RedirectStandardOutput = true;
p.StartInfo.FileName = "Write500Lines.exe";
p.Start();

// To avoid deadlocks, always read the output stream first and then wait.
string output = p.StandardOutput.ReadToEnd();
p.WaitForExit();

return "";

}
        
    }
}