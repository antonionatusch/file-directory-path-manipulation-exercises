using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfo_13_12_udemy
{
    public class PathDemo
    {
        public static void Execute()
        {
            var path = @"C:\Users\Usuario\Desktop\DirectoryExample\file1.txt";

            var dotIndex = path.IndexOf(".");
            
            Console.WriteLine("Extensión: " + Path.GetExtension(path));
            Console.WriteLine("Nombre del archivo: " + Path.GetFileName(path));
            Console.WriteLine("Nombre del archivo sin la extensión: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Nombre del directorio que contiene el archivo: " + Path.GetDirectoryName(path));

        }
    }
}
