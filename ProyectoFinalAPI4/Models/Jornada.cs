using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalAPI4.Models
{
    public partial class Jornada
    {
        public Jornada()
        {
            Ofertalaboral = new HashSet<Ofertalaboral>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ofertalaboral> Ofertalaboral { get; set; }
    }
}
