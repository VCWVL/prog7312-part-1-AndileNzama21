using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MunicipalServices_Part_1.Models
{
   

    
        /// <summary>
        /// Represents a reported issue with all relevant details
        /// </summary>
        public class ReportedIssue
        {
            // Use properties with PascalCase
            public string ReferenceNumber { get; }
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string AttachmentPath { get; set; }
            public DateTime ReportDate { get; set; }
            public string Status { get; set; }

            private static int _referenceCounter = 1000;

            /// <summary>
            /// Initializes a new instance of the ReportedIssue class
            /// </summary>
            public ReportedIssue()
            {
                ReferenceNumber = "REF-" + _referenceCounter++;
                ReportDate = DateTime.Now;
                Status = "Submitted";
            }

            // Override ToString for better display
            public override string ToString()
            {
                return $"{ReferenceNumber}: {Category} issue at {Location}";
            }
        }
    }

