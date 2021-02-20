using MISA.Common.Models;
using MISA.DataLayer;
using MISA.DataLayer.interfaces;
using MISA.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class CustomerGroupService : BaseService<CustomerGroup>, ICustomerGroupService
    {
        #region DECLARE
        #endregion

        #region CONSTRUCTOR
        public CustomerGroupService(IDbContext<CustomerGroup> dbContext) : base(dbContext)
        {

        }
        #endregion

        #region METHOD
        #endregion

    }
}
