//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetStore_EF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class accounts
    {
        public int id { get; set; }
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    
        public virtual Role Role1 { get; set; }
    }
}
