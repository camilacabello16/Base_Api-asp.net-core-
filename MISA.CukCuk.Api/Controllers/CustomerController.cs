using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Models;
using MISA.Service;
using MISA.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [ApiController]
    public class CustomerController : BaseController<Customer>
    {
        #region DECLARE

        #endregion

        #region CONSTRUCTOR 
        public CustomerController(ICustomerService customerService) : base(customerService)
        {

        }
        #endregion
    }
}
