//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Returnbook
    {
        public int id { get; set; }
        public Nullable<int> m_id { get; set; }
        public string book { get; set; }
        public Nullable<System.DateTime> returndate { get; set; }
        public Nullable<int> elsp { get; set; }
        public Nullable<int> fine { get; set; }
    }
}
