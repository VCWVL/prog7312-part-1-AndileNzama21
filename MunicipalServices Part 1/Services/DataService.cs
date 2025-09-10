using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using MunicipalServices_Part_1.Models;



namespace MunicipalServices_Part_1.Services
{
    

    namespace MunicipalServicesApplication.Services
    {
        /// <summary>
        /// Service class for handling data operations for reported issues
        /// </summary>
        public interface IDataService
        {
            void AddIssue(ReportedIssue issue);
            List<ReportedIssue> GetIssues();
        }

        public class DataService : IDataService
        {
            private readonly List<ReportedIssue> _reportedIssues;

            public DataService()
            {
                _reportedIssues = new List<ReportedIssue>();
            }

            /// <summary>
            /// Adds a new issue to the collection
            /// </summary>
            /// <param name="issue">The issue to add</param>
            public void AddIssue(ReportedIssue issue)
            {
                _reportedIssues.Add(issue);
            }

            /// <summary>
            /// Retrieves all reported issues
            /// </summary>
            /// <returns>List of reported issues</returns>
            public List<ReportedIssue> GetIssues()
            {
                return new List<ReportedIssue>(_reportedIssues);
            }
        }
    }
}
