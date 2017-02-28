using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppleBrainsSite.Services
{
    public class UploadsService : BaseService, IUploadsService
    {
        public string Upload (HttpPostedFile file)
        {
            string uploadFileName = file.FileName;
            string path = System.Configuration.ConfigurationManager.AppSettings["UploadFilePath"];
            string filePath = path + uploadFileName;
            file.SaveAs(filePath);

            string virtualpath = System.Configuration.ConfigurationManager.AppSettings["VirtualUploadFilePath"];
            string virtualFilePath = virtualpath + uploadFileName;

            return virtualFilePath;
        }
    }
}