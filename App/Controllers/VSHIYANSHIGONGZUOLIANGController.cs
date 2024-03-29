﻿using System;
using System.Collections.Generic;
using System.Linq;

using Common;
using Langben.DAL;
using Langben.BLL;
using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 实验室别工作量统计分析
    /// </summary>
    public class VSHIYANSHIGONGZUOLIANGController : BaseController
    {

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public ActionResult Index()
        {
        
            return View();
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public ActionResult RenYuan()
        {

            return View();
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public ActionResult ZhengShu()
        {

            return View();
        }
        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
       
        public JsonResult GetData(string id="", int page=11, int rows=11, string order="", string sort = "", string search = "")
        {

            int total = 0;
            page = 1;
            rows = 9999;
            List<SHIYANSHIGONGZUO_Result> queryData = m_BLL.GetByParam(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
					,WEITUODAN = s.WEITUODAN
					,JIANDINGWANCHENG = s.JIANDINGWANCHENG
					,SHEBEIGUZHANG = s.SHEBEIGUZHANG
					,PIZHUNTONGGUO = s.PIZHUNTONGGUO
					,HEGE = s.HEGE
					,BUHEGE = s.BUHEGE
					,CHAOQI = s.CHAOQI
					
                }

                    )
            });
        }

        public JsonResult GetDataRE(string id = "", int page = 11, int rows = 11, string order = "", string sort = "", string search = "")
        {

            int total = 0;
            page = 1;
            rows = 9999;
            List<RENYUANGONGZUOLIANG_Result> queryData = m_BLL.GetByParamRE(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
                    ,
                    WEITUODAN = s.WEITUODAN
                    ,
                    JIANDINGWANCHENG = s.JIANDINGWANCHENG
                    ,
                    SHEBEIGUZHANG = s.SHEBEIGUZHANG
                    ,
                    PIZHUNTONGGUO = s.PIZHUNTONGGUO
                    ,
                    HEGE = s.HEGE
                    ,
                    BUHEGE = s.BUHEGE
                    ,
                    CHAOQI = s.CHAOQI
                    ,
                    SHENHEBUTONGGUO = s.SHENHEBUTONGGUO
                    ,
                    PIZHUNBUTONGGUO = s.PIZHUNBUTONGGUO

                }

                    )
            });
        }

        public JsonResult GetDataZH(string id = "", int page = 11, int rows = 11, string order = "", string sort = "", string search = "")
        {

            int total = 0;
            page = 1;
            rows = 9999;
            List<ZHENGSHUHAOLEIBIE_Result> queryData = m_BLL.GetByParamZH(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
                    ,
                    WEITUODAN = s.WEITUODAN
                    ,
                    JIANDINGWANCHENG = s.JIANDINGWANCHENG
                    ,
                    SHEBEIGUZHANG = s.SHEBEIGUZHANG
                    ,
                    PIZHUNTONGGUO = s.PIZHUNTONGGUO
                    ,
                    HEGE = s.HEGE
                    ,
                    BUHEGE = s.BUHEGE
                    ,
                    CHAOQI = s.CHAOQI
                }

                    )
            });
        }




        IBLL.IVSHIYANSHIGONGZUOLIANGBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public VSHIYANSHIGONGZUOLIANGController()
            : this(new VSHIYANSHIGONGZUOLIANGBLL()) { }

        public VSHIYANSHIGONGZUOLIANGController(VSHIYANSHIGONGZUOLIANGBLL bll)
        {
            m_BLL = bll;
        }
      
    }
}


