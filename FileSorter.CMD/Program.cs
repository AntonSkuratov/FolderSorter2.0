using FileSorter.BL.Models;
List<string> list = new List<string>();
list.Add("C:\\Users\\anton\\OneDrive\\Рабочий стол\\Test1");
var a = "C:\\Users\\anton\\OneDrive\\Рабочий стол\\Tests";
FileRepository fileRepository=new FileRepository(list);
FileRepositoryManagement repositoryManagement = new FileRepositoryManagement(fileRepository);
repositoryManagement.MoveTo(a);