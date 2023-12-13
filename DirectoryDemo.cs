using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfoAndPath_13_12_udemy
{
    public class DirectoryDemo
    {
        public static void Execute()
        {
            Directory.CreateDirectory(@"C:\Users\Usuario\Desktop\DirectoryExample\DirectoryFromVS");
            var files = Directory.GetFiles(@"C:\Users\Usuario\Desktop\DirectoryExample", "*.*", SearchOption.AllDirectories);

            // El método SearchOptions.AllDirectories nos permite, de manera recursiva, abrir todos los archivos en el directorio y sus subdirectorios.

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\Usuario\Desktop\DirectoryExample", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo(@"C:\Users\Usuario\Desktop\DirectoryInfoExample");
            var directoriesFromDirectoryInfo = directoryInfo.GetDirectories("*.*", SearchOption.AllDirectories);
            
            foreach(var directory in directoriesFromDirectoryInfo)
            { 
                Console.WriteLine(directory); 
            }

            var filesFromDirectoryInfo = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach ( var file in filesFromDirectoryInfo)
            {
                Console.WriteLine(file);
            }



        }
    }
}
