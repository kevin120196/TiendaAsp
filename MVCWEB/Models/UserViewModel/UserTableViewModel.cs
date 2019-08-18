using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.UserViewModel
{
    public class UserTableViewModel
    {
        public int idUser { get; set; }
        public string nombreUser { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}