//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEcole
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seance
    {
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public System.TimeSpan heuredebut { get; set; }
        public System.TimeSpan heurefin { get; set; }
        public int idPromoModule { get; set; }
    
        public virtual PromoModule PromoModule { get; set; }
    }
}
