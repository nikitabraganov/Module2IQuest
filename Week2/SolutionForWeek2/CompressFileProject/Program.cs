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

                if (!FilesCompressed(fileInfo))
                {
                    using (FileStream compressedOutputFile = File.Create(fileInfo.FullName + ".gz"))
                    {
                        using (GZipStream compress = new GZipStream(compressedOutputFile, CompressionMode.Compress))
                        {
                            inputFileToCompress.CopyTo(compress);
                            Console.WriteLine("Compressed ratio of {0} is {1}%.", fileInfo.Name, fileInfo.Length / compressedOutputFile.Length);
                        }
                    }
                }
            }
        }
        public static bool FilesCompressed(FileInfo fileInfo)
        {
            return (File.GetAttributes(fileInfo.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileInfo.Extension != ".gz";
        }
    }
}
