using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Viacash.General.Api.Models
{
    public class SenderWB
    {   public int ID_SENDER {get; set;}
        public string ID_BRANCH {get; set;}
        public string SEN_FNAME {get;set;}
        public string SEN_LNAME {get;set;}

        
    }
}
