﻿using System.Threading.Tasks;
using DotNetty.Codecs.Http;

namespace Materal.DotNetty.ControllerBus.Filters
{
    public interface IActionBeforeAsyncFilter : IFilter
    {
        /// <summary>
        /// 处理过滤器
        /// </summary>
        /// <param name="baseController"></param>
        /// <param name="actionInfo"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        Task HandlerFilterAsync(BaseController baseController, ActionInfo actionInfo, IFullHttpRequest request, ref IFullHttpResponse response);
    }
}
