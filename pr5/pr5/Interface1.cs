using System.Collections.Generic;

namespace DataBase
{
    interface DataInterface
    {
        List<RawDataItem> GetRawData();
        List<SummaryDataItem> GetSummaryData();
    }
}
