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
    
    public partial class Commentvotingtracker
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> VoteStatus { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual Comment Comment { get; set; }
    }
}
