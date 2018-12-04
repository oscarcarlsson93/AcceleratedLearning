using System;
using System.IO;

namespace Module9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Project\";
            watcher.EnableRaisingEvents = true;

            watcher.Created += FileCreated;
            watcher.Renamed += FileRenamed;
            watcher.Deleted += FileDeleted;
            watcher.Changed += FileChanged;
            
            Console.WriteLine($"I'm wathcing this folder: {watcher.Path}");

            Console.ReadKey();
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} removed");
        }

        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.Name} renamed");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} created");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} changed");
        }
    }
}
