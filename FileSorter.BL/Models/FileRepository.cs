using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.BL.Models
{
    public class FileRepository : IFileRepository
    {
        public FileRepository(List<string> folderPaths)
        {
            List<DirectoryInfo> directoryInfos = new List<DirectoryInfo>();
            foreach (var folder in folderPaths)
            {
                directoryInfos.Add(new DirectoryInfo(folder));
            }
            FolderPaths = directoryInfos;
        }


        public List<DirectoryInfo> FolderPaths { get; }
        public int FilesCount { get { return GetAllFiles().Count; } }
        public int UniqueExtensionsCount { get { return GetUniqueExtensions().Count; } }


        public List<FileInfo> GetAllFiles()
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (var folder in FolderPaths)
            {
                files.AddRange(folder.GetFiles("*.*", SearchOption.AllDirectories));
            }
            return files;
        }
        public List<string> GetUniqueExtensions()
        {
            return GetAllFiles().Select(x => x.Extension).Distinct().ToList();
        }
    }
}
