using System.Text;
using System.IO;

namespace ImprimirCodigoFuente
{
    /// <summary>
    /// Para utilizar este c�digo:
    /// 1. Agregar un proyecto aplicaci�n de consola en la soluci�n que tiene el c�digo fuente a imprimir
    /// 2. Sustituir el c�digo de la clase Program por este c�digo 
    /// 3. Configurar el proyecto de consola como proyecto de inicio
    /// 4. Ejecutar la aplicaci�n
    /// 5. En la misma carpeta de la clase Program quedar�n los archivos de texto con el c�digo fuente
    /// </summary>
    internal class ImpresionCodigoFuenteSolucion
    {
        /// <summary>
        /// Imprime los archivos de c�digo con extensi�n .cs y las views .cshtml.
        /// Para agregar otro tipo de archivo simplemente invocar al m�todo Imprimir
        /// indicando *.extensi�n
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Imprimir("*.cs", "fuentesCs.txt");
            Imprimir("*.cshtml", "views.txt");

        }
        /// <summary>
        /// Imprime los archivos de c�digo fuente de la soluci�n
        /// </summary>
        /// <param name="tipoArchivo">El nombre del archivo a imprimir.Para imprimir todos los de un tipo determinado usar "*.extensi�n" por ejemplo:  "*.cs"</param>
        /// <param name="nombreArchivoSalida">El nombre del archivo de texto donde quedar� el c�digo fuente</param>
        /// <remarks>
        /// Este c�digo funciona siempre que el archivo de la soluci�n (.sln) est� en la ra�z de la soluci�n,
        /// es decir cuando todos los proyectos est�n en subcarpetas de la carpeta de la soluci�n
        /// </remarks>
        private static void Imprimir(string tipoArchivo, string nombreArchivoSalida)
        {
            try
            {
                string raizSolucion = ObtenerRutaSolucion();
                var separador = "***********************************" + Environment.NewLine;

                var archivos = System.IO.Directory.GetFiles(raizSolucion, tipoArchivo, System.IO.SearchOption.AllDirectories);

                //se obtienen los archivos .cs excluyendo los que contienen c�digo generado por el framework
                var resultado = archivos.Where(p => !p.Contains("Temporary")
                && !p.Contains("AssemblyInfo.cs")
                && !p.Contains("Program.cs")
                    && !p.Contains("AssemblyAttributes")
                    && !p.Contains(".g.cs"))
                    .Select(path => new { Carpeta = path, Nombre = System.IO.Path.GetFileName(path), Contenido = System.IO.File.ReadAllText(path) })
                                  .Select(info =>
                                      separador
                                    + "Archivo: " + info.Nombre + Environment.NewLine
                                    + "Carpeta: " + info.Carpeta + Environment.NewLine
                                    + separador
                                    + info.Contenido);


                var concatenado = string.Join(Environment.NewLine, resultado);
                File.WriteAllText(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())))
                    + @$"\{nombreArchivoSalida}", concatenado, Encoding.UTF8);
            }
            catch (Exception algunError)
            {
                Console.WriteLine(algunError.Message);
            }
        }
        static string ObtenerRutaSolucion()
        {
            string directorioActivo = Directory.GetCurrentDirectory();

            Console.WriteLine("Directorio activo: " + directorioActivo);

            // Navega hacia arriba en la estructura de directorios hasta encontrar la carpeta de la soluci�n
            DirectoryInfo directoryInfo = new DirectoryInfo(directorioActivo);

            while (directoryInfo != null && !DirectorioIncluye(directoryInfo, "*.sln"))
            {
                directoryInfo = directoryInfo.Parent;
            }

            if (directoryInfo != null)
            {
                return directoryInfo.FullName;
            }
            else
            {
                return string.Empty;
            }
        }

        static bool DirectorioIncluye(DirectoryInfo directory, string pattern)
        {
            return directory.GetFiles(pattern).Length > 0;
        }
    }
}

