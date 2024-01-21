using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path1 = "D:/MyFile.txt";
                string path2 = "D:/MyFile New.txt";

                if (File.Exists(path1))                                                      // File.Exists() 
                {
                    File.WriteAllText(path1, "Hi, I am Pradip. This is my file project.");   // File.WriteAllText()

                    File.AppendAllText(path1, "\n\nThis text is appended to file.");         // File.AppendAllText(

                    string textAfterRead = File.ReadAllText(path1);                          // File.ReadAllText()

                    Console.WriteLine(textAfterRead);

                    File.Copy(path1, path2);                                                 // File.Copy()

                    File.Delete(path1);                                                      // File.Delete()
                    Console.WriteLine("Deleted old file.");
                }

                File.Create(path1);                                                          // File.Create()
                Console.WriteLine("Created new file.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Stack Trace: {e.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally block always exicutes.");
            }
        }
    }
}
