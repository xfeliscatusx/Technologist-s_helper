//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Obrabiarka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operacje
    {
        public int id_operacje { get; set; }
        public string nazwa_operacji { get; set; }
        public Nullable<int> id_rodzajeobrabiarek { get; set; }
    
        public virtual RodzajeObrabiarek RodzajeObrabiarek { get; set; }
    }
}
