using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProyectoFinalAPI4.Models
{
    public partial class Habconocimcand
    {
        
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CandidatoIdcandidat { get; set; }

        public virtual Candidato CandidatoIdcandidatNavigation { get; set; }
    }
}
