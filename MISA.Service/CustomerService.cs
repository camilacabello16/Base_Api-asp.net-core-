using MISA.Common.Models;
using MISA.DataLayer;
using MISA.DataLayer.interfaces;
using MISA.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Service
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        #region DECALRE
        ICustomerRepository _customerRepository;
        #endregion

        #region CONSTRUCTOR
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
        #endregion

        #region METHOD

        /// <summary>
        /// Override hàm validate dữ liệu
        /// </summary>
        /// <param name="customer">Customer cần thêm mới</param>
        /// <param name="errorMsg">Câu thông báo lỗi</param>
        /// <returns>true - validate đúng, false - validate sai</returns>
        /// CreatedBy: BDHIEU (09/02/2021)
        protected override bool ValidateData(Customer customer, ErrorMsg errorMsg = null)
        {
            var isValid = true;
            if (customer.CustomerCode == "")
            {
                errorMsg.devMsg.Add(MISA.Common.Properties.Resources.ErrorService_NullCustomerCode_dev);
                errorMsg.userMsg.Add(MISA.Common.Properties.Resources.ErrorService_NullCustomerCode_user);
                isValid = false;
            }
            var isExist = _customerRepository.CheckCustomerCodeExist(customer.CustomerCode);
            if (isExist == true)
            {
                errorMsg.devMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateCustomerCode_dev);
                errorMsg.userMsg.Add(MISA.Common.Properties.Resources.ErrorService_DuplicateCustomerCode_user);
                isValid = false;
            }
            return isValid;
        }
        #endregion
    }
}
