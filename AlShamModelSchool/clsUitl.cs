using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool
{
    internal class clsUitl
    {
        static public string NewGUID()
        {
            return Guid.NewGuid().ToString();
        }



        static public string ReplaceFileNameToGUID(string FileName)
        {
            string NewFileName = $"{NewGUID()}{Path.GetExtension(FileName)}";
            return NewFileName;
        }

        static public bool CreateFolderDoseNotExists(string FolderParh)
        {

            if (!Directory.Exists(FolderParh))
            {
                Directory.CreateDirectory(FolderParh);

                return true;
            }

            return false;
        }

        static public bool CopyImageToProjectImages(ref string sourceImage)
        {


            if (CreateFolderDoseNotExists(clsGloble.PeopleImageFolderPath)) return false;


            string NewImagePath = clsGloble.PeopleImageFolderPath + ReplaceFileNameToGUID(sourceImage);

            try
            {
                File.Copy(sourceImage, NewImagePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            sourceImage = NewImagePath;

            return true;
        }

    }
}
