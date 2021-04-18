using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace project_ASQ
{
    class StreamWriterTwo
    {
        public static void SaveDataAsync(List<string> data, string path = "")
        {
            if (string.IsNullOrWhiteSpace(path))
                path = @"C:\test\test.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var line in data)
                file.WriteLine(string.Format("{0}\n", line));
        }
    }
}
