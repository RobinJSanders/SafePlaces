//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Safe_Places.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Archive
    {
        public int Archive_ID { get; set; }
        public string Employee_name { get; set; }
        public string Business_name { get; set; }
        public string Situation { get; set; }
        public string If_other { get; set; }
        public string Resolved { get; set; }
        public string Critical { get; set; }
        public string Details { get; set; }
        public System.DateTime Archive_Date { get; set; }
    }
}