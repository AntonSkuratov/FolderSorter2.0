using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.BL.Models
{
    public class FileRepositoryManagement
    {
        public FileRepositoryManagement(IFileRepository fileRepository)
        {
            FileRepository = fileRepository;
        }

        public IFileRepository FileRepository { get; }

        public void MoveTo(string finalPath)
        {
            CreateFolders(finalPath);
            foreach (var file in FileRepository.GetAllFiles())
            {
                File.Copy(file.FullName, Path.Combine(finalPath, file.Extension, file.Name));
            }
        }
        private void CreateFolders(string finalPath)
        {
            foreach (var folder in FileRepository.GetUniqueExtensions())
            {
                Directory.CreateDirectory(Path.Combine(finalPath, folder));
            }
        }
    }
}
