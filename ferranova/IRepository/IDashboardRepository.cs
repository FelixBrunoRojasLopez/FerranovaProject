using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IDashboardRepository : ICRUDRepository<DashboardResponse>
    {
        List<DashboardResponse> InsertMultiple(List<DashboardResponse> dashboards);
    }
}
