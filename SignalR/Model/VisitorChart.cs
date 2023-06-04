using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace SignalR.Model
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Counts = new List<int>(); //ilgili şehir kaç kişi tarafından ziyaret edilldi
        }

        public string VisitDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
