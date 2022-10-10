using System.Diagnostics;

Process p = new Process();
p.StartInfo.FileName = "cmd.exe";
p.StartInfo.Arguments = "/c C:\\Windows\\System32\\ncpa.cpl";
p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
p.StartInfo.RedirectStandardOutput = true;
p.StartInfo.RedirectStandardError = true;
p.StartInfo.CreateNoWindow = true;

p.Start();