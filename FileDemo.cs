using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfoAndPath_13_12_udemy
{
    public class FileDemo
    {
        public static async void Execute()
        {
            /* Copy - Recibe 2 parámetros de string, el primero es el path de la fuente, 
             * y el segundo es un directorio distinto donde no puede recibir ni un directorio ni un archivo existente.
             * También puede recibir un tercer parámetro de tipo bool el cual, si es true, indica que sí existe ese archivo y, por tanto, se tiene que sobreescribir.
             * Para el ejemplo, se necesitan archivos pngs en los paths especificados (modificar según convenga) 
             * Se optó por usar una función no vista en las clases llamada Thread.Sleep para así visualizar los cambios en ejecución.
             */

            var path = @"C:\Users\Usuario\Pictures\hola.png";

            File.Copy(@"C:\Users\Usuario\Pictures\hola.png", @"J:\hola.png");

            Thread.Sleep(8000); // delay de 8 segundos
            File.Delete(path);

            if (!File.Exists(path))
            {
                await Console.Out.WriteLineAsync("Borrado de hola exitoso"); // print asincrónico
            }

            var textPath = @"C:\Users\Usuario\Desktop\xd.txt";

            var context = File.ReadAllText(textPath); // leer un texto de un archivo
            File.ReadAllBytes(textPath); // lo mismo pero en binario

            await Console.Out.WriteLineAsync(context);

            // Para usar el método FileInfo, hay que crear un objeto de ese tipo.

            var fileInfoPath = @"C:\Users\Usuario\Pictures\holaInfo.png";

            var fileInfo = new FileInfo(fileInfoPath);
            fileInfo.CopyTo(@"J:\holadenuevo.png"); // mismos parametros que File.Copy

            Thread.Sleep(8000);
            fileInfo.Delete();
            
            if (!fileInfo.Exists)
            {
                await Console.Out.WriteLineAsync("Borrado de holaInfo exitoso");
            }

            // Estas clases son similares, pero: para hacer unas cuantas operaciones a un archivo, mejor File.
            // Para hacer un gran número de operaciones, es mejor utilizar fileInfo para ello.

        }
    }
}
