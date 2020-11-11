﻿using Authority.Common;
using Materal.Common;
namespace Authority.Service.Model.User
{
    /// <summary>
    /// 用户查询模型
    /// </summary>
    public class QueryUserFilterModel : PageRequestModel
    {
        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public SexEnum? Sex { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
    }
}
