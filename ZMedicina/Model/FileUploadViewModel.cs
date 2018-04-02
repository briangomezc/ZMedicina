using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Service;
using Microsoft.AspNetCore.Http;

namespace Model
{
    public class FileUploadViewModel
    {
        public IFormFile File { get; set; }

        public string Source { get; set; }

        public long Size { get; set; }

        public string Extension { get; set; }
    }
}
