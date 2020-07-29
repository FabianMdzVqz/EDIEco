using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearZipDeXMLB64
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileB64Data = @"C:\Users\fm780_000\OneDrive\Documentos\EDI Mex EDI\Proyectos\DescargaSAT\Operación\20200722 - Error de descarga\414ac1a5-2838-4dd6-8861-b43f6791a614.dat";
            string FileZipData = @"C:\EDIMexEDIFL_Framework\ConectorSAT\Descargas\AFD130723IZ3\20200722_123205\Recibidos\Paquetes\20200722123239_B2141052-6E1C-427F-B79B-248BBF0D6C2E_01.gzip";
            byte[] file = Convert.FromBase64String( File.ReadAllText(FileB64Data));

            if (!Directory.Exists(Path.GetDirectoryName(FileZipData)))
                Directory.CreateDirectory(Path.GetDirectoryName(FileZipData));
            

            using (FileStream fs = File.Create(FileZipData, file.Length))
            {
                fs.Write(file, 0, file.Length);
            }
        }
    }
}
