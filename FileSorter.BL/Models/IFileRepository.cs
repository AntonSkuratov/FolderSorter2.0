using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorter.BL.Models
{
    public interface IFileRepository
    {
        List<FileInfo> GetAllFiles();
        List<string> GetUniqueExtensions();
    }
}
