//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiemTra02.Code
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> PostedDatetime { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<bool> Approved { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
