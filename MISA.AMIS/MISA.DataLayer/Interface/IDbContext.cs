using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.DataLayer.Interfaces
{
    public interface IDbContext<TEntity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Toàn bộ dự liệu nhân viên</returns>
        /// CreatedBy: NTTHIEM (21/02/2021)
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <param name="query">Lệnh truy vấn</param>
        /// <param name="cmdType">Kiểu truy vấn: text, produce</param>
        /// <returns></returns>
        /// /// CreatedBy: NTTHIEM (21/02/2021)
        IEnumerable<TEntity> GetAll(string query = null, CommandType cmdType = CommandType.Text);


        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng cần thêm</param>
        /// <returns></returns>
        /// /// CreatedBy: NTTHIEM (21/02/2021)
        int Insert(TEntity entity);

        /// <summary>
        /// Sử dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng sửa</param>
        /// <returns></returns>
        /// /// CreatedBy: NTTHIEM (21/02/2021)
        int Put(TEntity entity);

        /// <summary>
        /// Xóa dữ liệu
        /// </summary>
        /// <param name="entityId">Id đối tượng</param>
        /// <returns></returns>
        /// /// CreatedBy: NTTHIEM (21/02/2021)
        int Delete(string entityId);
    }
}
