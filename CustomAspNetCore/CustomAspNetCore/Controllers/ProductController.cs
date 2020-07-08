using CustomAspNetCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAspNetCore.Controllers
{
    public class ProductController
    {
        FileReaderService service = new FileReaderService();
        public string Index(string filename)
        {
            return service.GetFilesContent(filename);
        }
        public string Index2()
        {
            return "";
        }
    }
}
