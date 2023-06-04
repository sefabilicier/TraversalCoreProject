using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalR.DAL;
using SignalR.Hubs;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SignalR.Model
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHubs> _hubContext;

        public VisitorService(Context context, IHubContext<VisitorHubs> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("CallVisitorList", "aaa");
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>(); //visitorchartss isminde nesne örnekledim

            using (var command = _context.Database.GetDbConnection().CreateCommand()) //sorgu komutu oluşturduk
            {
                command.CommandText = "Select * From crosstab ('SELECT VisitDate, City,CityVisitCount From Visitors Order By 1,2') As ct(VisitDate date, City1 int, City2 int, City3 int, City4 int, City5 int)"; //crosstab ile yazdığımız sorgu
                command.CommandType = System.Data.CommandType.Text; //query türünde
                _context.Database.OpenConnection(); //sonra dedim ki bağlantımı aç

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) //okunduğu sürece her şehiri ana liste içerisine dahil edildi 
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x => //1,5 = visitors daki enum a bağlı olduğu içim
                        {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                        });

                        visitorCharts.Add(visitorChart);    
                    }
                }


                _context.Database.CloseConnection(); //bağlantımı kapatıp 
                return visitorCharts;   //bunu döndürdüm
            }
        }
    }
}
