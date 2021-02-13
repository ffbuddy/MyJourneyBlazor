using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocoQRCode.Shared.Entities
{
    public class OUSR
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string UserPassword { get; set; }                     
        public DateTime DateCreated { get; set; }


    }
}
