﻿using System;
using System.Collections.Generic;
using System.Linq;

using Common;
using Langben.DAL;
using System.ServiceModel;

namespace Langben.IBLL
{
    /// <summary>
    /// 实验室别工作量统计分析 接口
    /// </summary>
    [ServiceContract(Namespace = "www.langben.com")]
    public interface IVSHIYANSHIGONGZUOLIANGBLL
    {
        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        [OperationContract]
        List<SHIYANSHIGONGZUO_Result> GetByParam(string id, int page, int rows, string order, string sort, string search, ref int total);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        System.Collections.Generic.List<VSHIYANSHIGONGZUOLIANG> GetAll();

        /// <summary>
        /// 人员查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        [OperationContract]
        List<RENYUANGONGZUOLIANG_Result> GetByParamRE(string id, int page, int rows, string order, string sort, string search, ref int total);
        /// <summary>
        /// 证书查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        [OperationContract]
        List<ZHENGSHUHAOLEIBIE_Result> GetByParamZH(string id, int page, int rows, string order, string sort, string search, ref int total);
    }
}

