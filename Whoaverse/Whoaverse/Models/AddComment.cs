﻿/*
This source file is subject to version 3 of the GPL license, 
that is bundled with this package in the file LICENSE, and is 
available online at http://www.gnu.org/licenses/gpl.txt; 
you may not use this file except in compliance with the License. 

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

All portions of the code written by Voat are Copyright (c) 2014 Voat
All Rights Reserved.
*/

using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Voat.Models
{
    public class AddComment
    {
        public int Id { get; set; }
        public short Likes { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<short> Votes { get; set; }
        public bool Anonymized { get; set; }
        
        [Required(ErrorMessage = "Comment author is required.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Comment text is required. Please fill this field.")]
        [StringLength(10000, ErrorMessage = "Comment text is limited to 10.000 characters.")]
        [AllowHtml]
        public string CommentContent { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "MessageId is required.")]
        public int MessageId { get; set; }
    }
}