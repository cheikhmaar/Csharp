//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenDotNet1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordinateur
    {
        public int Id { get; set; }
        public string refOrdi { get; set; }
        public string ram { get; set; }
        public string disque { get; set; }
        public string processeur { get; set; }
        public int marqueId { get; set; }
        public int osId { get; set; }
    
        public virtual Marque Marque { get; set; }
        public virtual Os Os { get; set; }
    }
}