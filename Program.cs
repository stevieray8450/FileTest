using System.IO;

namespace FileTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] strings = { "Test1", "Test2", "Test3" };
            string path = "test.txt";

            if(File.Exists(path))
            {
                File.Delete(path);
            }

            using (var fileStream = File.Create(path))
            {
                using (var fileWriter = new StreamWriter(fileStream))
                {
                    foreach (var s in strings)
                    {
                        fileWriter.WriteLine(s);
                    }
                }
            }

            using (var fileReader = new StreamReader(path)) {
                var lines = fileReader.ReadToEnd();
            }
        }
    }
}
