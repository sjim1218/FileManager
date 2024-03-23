using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderControl.Class
{
    class VmsFolderManager
    {
        private string SourcePath;
        private string TargetPath;
        // 이 객체의 역할 정의하기
        // sender가 parameter로 경로를 알려 줄 경우
        // CopyFiles
        private void SetFolderInfos(string sourchPath, string targetPath)
        {
            SourcePath = sourchPath;
            TargetPath = targetPath;
        }
        private void Copy(string type)
        {
            if (File.Exists(this.SourcePath) == false)
                return;

            string[] files = Directory.GetFiles(SourcePath);

            foreach(string file in files)
            {
                string fileName = Path.GetFileName(file);
                string targetFile = Path.Combine(this.TargetPath, fileName);
                File.Copy(file, targetFile, true);
            }

        }
        public bool CopyFiles(string sourcePath, string targetPath)
        {
            this.SetFolderInfos(sourcePath, targetPath);

            return false;
        }
        
    }
}
