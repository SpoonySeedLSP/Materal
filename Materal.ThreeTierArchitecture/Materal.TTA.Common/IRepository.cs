﻿using Materal.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Materal.TTA.Common
{
    public interface IRepository<T, in TPrimaryKeyType> where T : class, IEntity<TPrimaryKeyType>
    {
        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <returns></returns>
        bool Existed(TPrimaryKeyType id);
        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <returns></returns>
        bool Existed(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <returns></returns>
        bool Existed(FilterModel filterModel);

        /// <summary>
        /// 总数
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 总数
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <returns></returns>
        int Count(FilterModel filterModel);

        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <returns></returns>
        IQueryable<T> Where(FilterModel filterModel);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <returns></returns>
        List<T> Find(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <returns></returns>
        List<T> Find(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderExpression);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="sortOrder">排序方式</param>
        /// <returns></returns>
        List<T> Find(Expression<Func<T, bool>> expression, Expression<Func<T, object>> orderExpression, SortOrder sortOrder);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <returns></returns>
        List<T> Find(FilterModel filterModel);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <returns></returns>
        List<T> Find(FilterModel filterModel, Expression<Func<T, object>> orderExpression);
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="sortOrder">排序方式</param>
        /// <returns></returns>
        List<T> Find(FilterModel filterModel, Expression<Func<T, object>> orderExpression, SortOrder sortOrder);
        /// <summary>
        /// 检索
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T FirstOrDefault(TPrimaryKeyType id);
        /// <summary>
        /// 检索
        /// </summary>
        /// <param name="filterModel">过滤器模型</param>
        /// <returns></returns>
        T FirstOrDefault(FilterModel filterModel);
        /// <summary>
        /// 检索
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(PageRequestModel pageRequestModel);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(PageRequestModel pageRequestModel, Expression<Func<T, object>> orderExpression);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="sortOrder">排序方式</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(PageRequestModel pageRequestModel, Expression<Func<T, object>> orderExpression, SortOrder sortOrder);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, PageRequestModel pageRequestModel);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="pagingIndex">页数</param>
        /// <param name="pagingSize">每页显示数量</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, int pagingIndex, int pagingSize);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, Expression<Func<T, object>> orderExpression, PageRequestModel pageRequestModel);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="sortOrder">排序方式</param>
        /// <param name="pageRequestModel">分页请求模型</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, Expression<Func<T, object>> orderExpression, SortOrder sortOrder, PageRequestModel pageRequestModel);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="pagingIndex">页数</param>
        /// <param name="pagingSize">每页显示数量</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, Expression<Func<T, object>> orderExpression, int pagingIndex, int pagingSize);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filterExpression">过滤表达式</param>
        /// <param name="orderExpression">排序表达式</param>
        /// <param name="sortOrder">排序方式</param>
        /// <param name="pagingIndex">页数</param>
        /// <param name="pagingSize">每页显示数量</param>
        /// <returns></returns>
        (List<T> result, PageModel pageModel) Paging(Expression<Func<T, bool>> filterExpression, Expression<Func<T, object>> orderExpression, SortOrder sortOrder, int pagingIndex, int pagingSize);
    }
}
