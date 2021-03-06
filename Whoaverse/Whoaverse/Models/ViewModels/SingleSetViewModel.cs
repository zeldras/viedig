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
using System.Collections.Generic;

namespace Voat.Models.ViewModels
{
    public class SingleSetViewModel
    {
        // set name
        public string Name { get; set; }

        // set creation date
        public DateTime Created { get; set; }

        // set id
        public int Id { get; set; }

        // set subscriber count
        public int Subscribers { get; set; }

        // list of subverses which define the set
        public List<Usersetdefinition> SubversesList { get; set; }

        // list of top submissions from single set
        public List<SetSubmission> SubmissionsList { get; set; }
    }
}