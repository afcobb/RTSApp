using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RTSApp.Models
{
    public class Carrier
    {
        public int CarrierID { get; set; }
        [MaxLength(50)]
        public string MCNumber { get; set; }
        public int DOTNumber { get; set; }
        [MaxLength(200)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        [MaxLength(20)]
        public string Zip { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        public string WebURL { get; set; }
        public Boolean Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
    }
}