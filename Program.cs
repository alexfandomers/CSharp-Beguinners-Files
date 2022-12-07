namespace Files
{
      public class Program
    {
        static void Main(string[] args)
        { 
            ////File class(static)////            
            //more convinient if we have small number of operations
            //everytime we call them, some security checking is done to make sure the current user has access to  the file
            //it can affect the perform of the application if you have a lot of them
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);           

            ////FileInfo class////           
            //FileInfo class using Same methods  (instance methods)(FIRST WE CREATE A OBJECT)
            //this way security check is done only once during creation of a file object.
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }           

            ////Directory (static)////           
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\C#", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(@"C:\C#", "*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...put the path here..");//if you wanna know if directory exists*/                       

            ////DirectoryInfo////           
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
           
            ////Path (static)////           
            var path2 = @"c:\temp\folder1.sln";
            Console.WriteLine("Extension: " + Path.GetExtension(path2));
            Console.WriteLine("File name: " + Path.GetFileName(path2));
            Console.WriteLine("File name without Extension: " + Path.GetFileNameWithoutExtension(path2));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path2));
        }
    }
}
