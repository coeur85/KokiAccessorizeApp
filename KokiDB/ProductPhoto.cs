//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KokiDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhoto
    {
        public int PhotoID { get; set; }
        public int ProductID { get; set; }
        public string PhotoBase64 { get; set; }
    
        public virtual Product Product { get; set; }
    }
}