using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    // Purpose: Separate the construction of a complex object from its representation
    // Real-time Usage: Building complex DTOs or HTML/PDF reports.
    public class ReportBuilder
    {
        private Report _report = new();

        public ReportBuilder AddTitle(string title)
        {
            _report.Title = title;
            return this;
        }

        public ReportBuilder AddContent(string content)
        {
            _report.Content = content;
            return this;
        }

        public Report Build() => _report;
    }

    public class Report
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
