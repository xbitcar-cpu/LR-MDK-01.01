using System.Collections.Generic;

namespace LR3
{
    public class ProfitByPeriodReport
    {
        private List<ReportRow> data_;

        public ProfitByPeriodReport()
        {
            data_ = new List<ReportRow>();
        }

        public void AddRow(ReportRow row)
        {
            data_.Add(row);
        }

        public List<ReportRow> GetReportRows()
        {
            return data_;
        }
    }
}
