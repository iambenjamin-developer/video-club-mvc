﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoClub.Entities
{
    [Table("Clientes")]
    public class Cliente
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        public bool EstaSuscritoNoticias { get; set; }

        [Display(Name = "Tipo de membresía:")]
        public TipoMembresia TipoMembresia { get; set; }

        public int TipoMembresiaId { get; set; }


        [Display(Name = "Fecha de Nacimiento:")]
        public DateTime? FechaNacimiento { get; set; }

    }
}