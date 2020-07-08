using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomAspNetCore.Services
{
    public class FileReaderService
    {

        //https://stackoverflow.com/questions/33884060/best-way-to-create-dynamic-html-in-c-sharp/33884169  //dynmaic html file
        public string GetFilesContent(string fileName)
        {
            var html = File.ReadAllText($"./wwwroot/{fileName}");
            return html;
        }
    }
}
