using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Minicipal_Services;

namespace Minicipal_Services
{
   

    
        public class DataService : IDataService
        {
            private readonly List<ReportedIssue> _reportedIssues;

            public DataService()
            {
                _reportedIssues = new List<ReportedIssue>();
            }

            public void AddIssue(ReportedIssue issue)
            {
                _reportedIssues.Add(issue);
            }

            public List<ReportedIssue> GetIssues()
            {
                return new List<ReportedIssue>(_reportedIssues);
            }
        }
    }

