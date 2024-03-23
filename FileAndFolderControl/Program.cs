using FileAndFolderControl.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderManager = new VmsFolderManager();

            string sourcePath = @"D:\Programming\VMS\STUDY\DevFileManager\Test\Source";
            string targetPath = @"D:\Programming\VMS\STUDY\DevFileManager\Test\Target";
            
            var tryCopy = folderManager.CopyFiles(sourcePath, targetPath);
        }
    }
}
