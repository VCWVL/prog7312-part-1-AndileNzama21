using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Minicipal_Services
{
 
    public interface IDataService
        {
            void AddIssue(ReportedIssue issue);
            List<ReportedIssue> GetIssues();
        }
    }

