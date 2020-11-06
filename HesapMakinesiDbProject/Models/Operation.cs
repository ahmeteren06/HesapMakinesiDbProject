using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapMakinesiDbProject.Models
{
    [Table("tblIslemler")]
    public class Operation
    {

        [Key]
        public int OperationId { get; set; }
        public double Number1 { get; set; }
        [MaxLength(25)]
        public string Operator { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
    }
}