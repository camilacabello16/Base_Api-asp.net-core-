using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.interfaces
{
    public interface ICustomerRepository:IDbContext<Customer>
    {
        #region DECALRE
        #endregion

        #region CONSTRUCTOR
        #endregion

        #region METHOD
        /// <summary>
        /// Kiểm tra trùng mã khách hàng
        /// </summary>
        /// <param name="CustomerCode">Mã khách hàng truyền vào</param>
        /// <returns>true - đã tồn tại, false - chưa tồn tại</returns>
        /// CreatedBy: BDHIEU (10/02/2021)
        bool CheckCustomerCodeExist(string CustomerCode);
        #endregion
    }
}
