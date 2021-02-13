using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocoQRCode.Shared.Entities
{
    public class QRCL
    {
        public int QRCodeID { get; set; }
       [Required(ErrorMessage ="This field is mandatory. Please fill it up")]
        public string ProdSerial { get; set; }
        public string ProdDescp { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime SystemDate { get; set; }
        public string UserCode { get; set; }
    }
}
