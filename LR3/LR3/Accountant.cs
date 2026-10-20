using LR3;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Accountant 
    {
        public static ProfitByPeriodReport MakeReport(SaleHistory history,
                                                      DateTime startPeriod,
                                                      DateTime endPeriod)
        {
            Dictionary<string, ReportRow> totalRows = new Dictionary<string, ReportRow>();

            List<SaleItem> items = history.GetSales();

            foreach (SaleItem item in items)
            {
                string saleProduct = item.GetProductName();
                DateTime saleDate = item.GetSaleDate();

                if (startPeriod > saleDate || saleDate > endPeriod)
                {
                    continue;
                }

                if (totalRows.ContainsKey(saleProduct))
                {
                    ReportRow row = totalRows[saleProduct];
                    row.Count_ += item.GetCount();
                    row.Cost_ += item.GetCount() * item.GetPrice();
                    totalRows[saleProduct] = row;
                }
                else
                {
                    totalRows.Add(saleProduct, new ReportRow
                    {
                        Product_ = saleProduct,
                        Count_ = item.GetCount(),
                        Cost_ = item.GetCount() * item.GetPrice()
                    });
                }
            }

            ProfitByPeriodReport result = new ProfitByPeriodReport();

            foreach (KeyValuePair<string, ReportRow> row in totalRows)
            {
                result.AddRow(row.Value);
            }

            return result;
        }

        public static ProfitByProductGroupReport MakeGroupReport(ProfitByPeriodReport periodReport,
                                                                 Nomenclature nomenclature)
        {
            Dictionary<ProductGroup, GroupReportRow> totalRows = new Dictionary<ProductGroup, GroupReportRow>();

            foreach (ReportRow periodRow in periodReport.GetReportRows())
            {
                ProductGroup group = nomenclature.GetProductGroupByProduct(periodRow.Product_).Value;

                if (totalRows.ContainsKey(group))
                {
                    GroupReportRow row = totalRows[group];
                    row.Count_ += periodRow.Count_;
                    row.Cost_ += periodRow.Cost_;
                    totalRows[group] = row;
                }
                else
                {
                    totalRows.Add(group, new GroupReportRow
                    {
                        Group_ = group,
                        Count_ = periodRow.Count_,
                        Cost_ = periodRow.Cost_
                    });
                }
            }

            ProfitByProductGroupReport result = new ProfitByProductGroupReport();

            foreach (KeyValuePair<ProductGroup, GroupReportRow> row in totalRows)
            {
                result.AddRow(row.Value);
            }

            return result;
        }
    }
}