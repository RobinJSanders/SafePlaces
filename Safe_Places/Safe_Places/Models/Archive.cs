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
    using System.ComponentModel;

    public partial class Archive
    {
        [DisplayName("Id")]
        public int Archive_ID { get; set; }
        [DisplayName("Employee name ")]
        
        public string Employee_name { get; set; }
        public string Situation { get; set; }
        [DisplayName("If other")]
        public string If_other { get; set; }
        [DisplayName("How it was Resolved")]
        public string Resolved { get; set; }
        public string Critical { get; set; }
        public string Details { get; set; }
        [DisplayName("Date")]
        public System.DateTime Archive_Date { get; set; }
    }
}
