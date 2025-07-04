﻿using System.ComponentModel.DataAnnotations.Schema;

namespace API_Maquinas.Models
{
    public class Logins
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Users { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string PassWord { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Rol { get; set; } 
    }
}
