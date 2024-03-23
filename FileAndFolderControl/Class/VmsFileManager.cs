using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderControl.Class
{
    internal class VmsFileManager
    {
        private string SourcePath;
        private string TargetPath;

        private bool Copy()
        {            
            string[] files = this.GetFilesOrNull(this.SourcePath);
            if (files == null)
                return false;

            this.CopyFilesToTarget(files, this.TargetPath);
            return true;
        }
        private void CopyFilesToTarget(string[] files, string targetPath)
        {
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string targetFile = Path.Combine(targetPath, fileName);
                File.Copy(file, targetFile, true);
            }
        }
        private string[] GetFilesOrNull(string sourcePath)
        {
            if (Directory.Exists(this.SourcePath) == false)
                return null;

            return Directory.GetFiles(sourcePath);
        }
        private void SetDirectoryPaths(string sourchPath, string targetPath)
        {
            SourcePath = sourchPath;
            TargetPath = targetPath;
        }

        public bool CopyFiles(string sourcePath, string targetPath)
        {
            this.SetDirectoryPaths(sourcePath, targetPath);
            bool isDone = this.Copy();
            return isDone;
        }
        
    }
}
