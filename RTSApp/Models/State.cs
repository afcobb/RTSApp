using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RTSApp.Models
{
    public class State
    {
        public int StateID { get; set; }
        [MaxLength(200)]
        public string StateName { get; set; }
        public string StateAbbrev { get; set; }

    }
}