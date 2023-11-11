using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DashboardRepository : CRUDRepository<DashboardResponse>, IDashboardRepository
    {
        public GenericFilterResponse<DashboardResponse> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public List<DashboardResponse> InsertMultiple(List<DashboardResponse> dashboards)
        {
            throw new NotImplementedException();
        }
    }
}
