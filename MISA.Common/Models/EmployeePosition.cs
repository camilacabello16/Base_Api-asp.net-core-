using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Vị trí nhân viên
    /// CreatedBy: BDHieu (13/02/2021)
    /// </summary>
    public class EmployeePosition
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int PositionId { get; set; }
        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string PositionName { get; set; }
        #endregion
    }
}
