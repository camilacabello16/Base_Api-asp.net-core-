using Dapper;
using MISA.Common.Models;
using MISA.DataLayer.interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MISA.DataLayer
{
    public class CustomerRepository : DbContext<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Kiểm tra mã khách hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="CustomerCode">Mã khách hàng cần kiểm tra</param>
        /// <returns>true: tồn tại, false: không tồn tại</returns>
        /// CreatedBy: BDHIEU (09/02/2021)
        public bool CheckCustomerCodeExist(string CustomerCode)
        {
            _dbConnection = new MySqlConnection(_sqlConnector);
            var sqlCommand = $"SELECT CustomerCode FROM Customer WHERE CustomerCode = '{CustomerCode}'";
            var res = _dbConnection.Query<string>(sqlCommand, commandType: CommandType.Text).FirstOrDefault();
            if (res != null)
            {
                return true;
            }
            return false;
        }
    }
}
