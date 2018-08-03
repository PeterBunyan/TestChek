using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TestChek.Models;

namespace TestChek.Models
{
    public class Photo
    {
        private string _imageFolder = "~/Photos/";
        public string imageFolder { get { return _imageFolder; } }
        public string image;
        private string _imageExtension = ".jpeg";
        public string imageExtension { get { return _imageExtension; } }

        StringBuilder filePathImage = new StringBuilder();

        
    }
 
}
