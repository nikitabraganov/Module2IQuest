using System;
using System.IO;
using System.IO.Compression;

namespace CompressFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();

            DirectoryInfo newDirectoryInfo = new DirectoryInfo(directoryPath);

            // Compress the directory's files.
            foreach (FileInfo fileInfo in newDirectoryInfo.GetFiles())
            {
                Compress(fileInfo);
            }
            Console.ReadKey();
        }

        public static void Compress(FileInfo fileInfo)
        {
            // Get the stream of the source file.
            using (FileStream inputFileToCompress = fileInfo.OpenRead())
            {

                if ((File.GetAttributes(fileInfo.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileInfo.Extension != ".gz")
                {
                    using (FileStream compressedOutputFile = File.Create(fileInfo.FullName + ".gz"))
                    {
                        using (GZipStream Compress = new GZipStream(compressedOutputFile, CompressionMode.Compress))
                        {
                            inputFileToCompress.CopyTo(Compress);
                            Console.WriteLine("Compressed ratio of {0} is {1}%.", fileInfo.Name, fileInfo.Length/compressedOutputFile.Length);
                        }
                    }
                }
            }
        }
    }
}
