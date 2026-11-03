using System.Collections.Generic;

namespace LR3
{
    public class ProfitByProductGroupReport
    {
        private List<GroupReportRow> data_;

        public ProfitByProductGroupReport()
        {
            data_ = new List<GroupReportRow>();
        }

        public void AddRow(GroupReportRow row)
        {
            data_.Add(row);
        }

        public List<GroupReportRow> GetReportRows()
        {
            return data_;
        }
    }
}
