//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Userpreference
    {
        public Userpreference()
        {
            this.Disable_custom_css = false;
            this.Night_mode = false;
            this.Language = "en";
            this.Clicking_mode = false;
            this.Enable_adult_content = false;
            this.Public_votes = false;
        }
    
        public string Username { get; set; }
        public bool Disable_custom_css { get; set; }
        public bool Night_mode { get; set; }
        public string Language { get; set; }
        public bool Clicking_mode { get; set; }
        public bool Enable_adult_content { get; set; }
        public bool Public_votes { get; set; }
        public bool Public_subscriptions { get; set; }
        public bool Topmenu_from_subscriptions { get; set; }
        public string Shortbio { get; set; }
        public string Avatar { get; set; }
    }
}
