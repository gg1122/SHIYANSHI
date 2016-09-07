﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;
using Common;
using Langben.DAL;
using Langben.BLL;
using System.Web.Http;
using Langben.App.Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 委托单信息
    /// </summary>
    public class ORDER_TASK_INFORMATIONApiController : BaseApiController
    {

        public ORDER_TASK_INFORMATIONShow PostDataByID(string id)
        {

            if (!string.IsNullOrWhiteSpace(id))
            {

                id = id.Replace("@", "&");
            }
            int total = 0;
            string UNDERTAKE_LABORATORYID = string.Empty;
            List<APPLIANCE_DETAIL_INFORMATION> queryData = m_BLL.GetByParam(null, 1, 1, "DESC", "ID", id, ref total);
            foreach (var item in queryData)
            {
                List<APPLIANCE_LABORATORY> list = m_BLL2.GetByRefAPPLIANCE_DETAIL_INFORMATIOID(item.ID);
                foreach (var item2 in list)
                {
                    UNDERTAKE_LABORATORYID += item2.UNDERTAKE_LABORATORYID + ",";
                }
            }
            return queryData.Select(s => new ORDER_TASK_INFORMATIONShow()
            {
                APPLIANCE_DETAIL_INFORMATIONShows = new List<Models.APPLIANCE_DETAIL_INFORMATIONShow>() { new APPLIANCE_DETAIL_INFORMATIONShow() {


                    } },
                ID = s.ORDER_TASK_INFORMATION.ID
                    ,
                ORDER_NUMBER = s.ORDER_TASK_INFORMATION.ORDER_NUMBER
                    ,
                ACCEPT_ORGNIZATION = s.ORDER_TASK_INFORMATION.ACCEPT_ORGNIZATION
                    ,
                INSPECTION_ENTERPRISE = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE
                    ,
                INSPECTION_ENTERPRISE_ADDRESS = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE_ADDRESS
                    ,
                INSPECTION_ENTERPRISE_POST = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE_POST
                //,
                //    CONTACTS = s..ORDER_TASK_INFORMATIONCONTACTS
                //,
                //    CONTACT_PHONE = s..ORDER_TASK_INFORMATIONCONTACT_PHONE
                //,
                //    FAX = s..ORDER_TASK_INFORMATIONFAX
                //,
                //    CERTIFICATE_ENTERPRISE = s.CERTIFICATE_ENTERPRISE
                //,
                //    CERTIFICATE_ENTERPRISE_ADDRESS = s.CERTIFICATE_ENTERPRISE_ADDRESS
                //,
                //    CERTIFICATE_ENTERPRISE_POST = s.CERTIFICATE_ENTERPRISE_POST
                //,
                //    CONTACTS2 = s.CONTACTS2
                //,
                //    CONTACT_PHONE2 = s.CONTACT_PHONE2
                //,
                //    FAX2 = s.FAX2
                //,
                //    CUSTOMER_SPECIFIC_REQUIREMENTS = s.CUSTOMER_SPECIFIC_REQUIREMENTS
                //,
                //    ORDER_STATUS = s.ORDER_STATUS
                //,
                //    CREATETIME = s.CREATETIME
                //,
                //    CREATEPERSON = s.CREATEPERSON
                //,
                //    UPDATETIME = s.UPDATETIME
                //,
                //    UPDATEPERSON = s.UPDATEPERSON
            }).FirstOrDefault();

            };
            
        }

        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="getParam"></param>
        /// <returns></returns>
        public Common.ClientResult.DataResult PostData([FromBody]GetDataParam getParam)
        {
            int total = 0;
            List<ORDER_TASK_INFORMATION> queryData = m_BLL.GetByParam(null, getParam.page, getParam.rows, getParam.order, getParam.sort, getParam.search, ref total);
            var data = new Common.ClientResult.DataResult
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
                    ,
                    ORDER_NUMBER = s.ORDER_NUMBER
                    ,
                    ACCEPT_ORGNIZATION = s.ACCEPT_ORGNIZATION
                    ,
                    INSPECTION_ENTERPRISE = s.INSPECTION_ENTERPRISE
                    ,
                    INSPECTION_ENTERPRISE_ADDRESS = s.INSPECTION_ENTERPRISE_ADDRESS
                    ,
                    INSPECTION_ENTERPRISE_POST = s.INSPECTION_ENTERPRISE_POST
                    ,
                    CONTACTS = s.CONTACTS
                    ,
                    CONTACT_PHONE = s.CONTACT_PHONE
                    ,
                    FAX = s.FAX
                    ,
                    CERTIFICATE_ENTERPRISE = s.CERTIFICATE_ENTERPRISE
                    ,
                    CERTIFICATE_ENTERPRISE_ADDRESS = s.CERTIFICATE_ENTERPRISE_ADDRESS
                    ,
                    CERTIFICATE_ENTERPRISE_POST = s.CERTIFICATE_ENTERPRISE_POST
                    ,
                    CONTACTS2 = s.CONTACTS2
                    ,
                    CONTACT_PHONE2 = s.CONTACT_PHONE2
                    ,
                    FAX2 = s.FAX2
                    ,
                    CUSTOMER_SPECIFIC_REQUIREMENTS = s.CUSTOMER_SPECIFIC_REQUIREMENTS
                    ,
                    ORDER_STATUS = s.ORDER_STATUS
                    ,
                    CREATETIME = s.CREATETIME
                    ,
                    CREATEPERSON = s.CREATEPERSON
                    ,
                    UPDATETIME = s.UPDATETIME
                    ,
                    UPDATEPERSON = s.UPDATEPERSON


                })
            };
            return data;
        }

        /// <summary>
        /// 根据ID获取数据模型
        /// </summary>
        /// <param name="id">编号</param>
        [HttpGet]
        public ORDER_TASK_INFORMATION Get(string id)
        {
            ORDER_TASK_INFORMATION item = m_BLL.GetById(id);
            return item;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public Common.ClientResult.Result Post([FromBody]ORDER_TASK_INFORMATION entity)
        {

            Common.ClientResult.OrderTaskGong result = new Common.ClientResult.OrderTaskGong();
            if (entity != null && ModelState.IsValid)
            {
                string currentPerson = GetCurrentPerson();
                entity.CREATETIME = DateTime.Now;
                entity.CREATEPERSON = currentPerson;

                entity.ID = Result.GetNewId();
                string returnValue = string.Empty;
                if (m_BLL.Create(ref validationErrors, entity))
                {
                    LogClassModels.WriteServiceLog(Suggestion.InsertSucceed + "，委托单信息的信息的Id为" + entity.ID, "委托单信息"
                        );//写入日志 
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.InsertSucceed;
                    result.Id = entity.ID;
                    return result; //提示创建成功
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.InsertFail + "，委托单信息的信息，" + returnValue, "委托单信息"
                        );//写入日志                      
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.InsertFail + returnValue;
                    return result; //提示插入失败
                }
            }

            result.Code = Common.ClientCode.FindNull;
            result.Message = Suggestion.InsertFail + "，请核对输入的数据的格式"; //提示输入的数据的格式不对 
            return result;
        }

        // PUT api/<controller>/5
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>  
        public Common.ClientResult.Result Put([FromBody]ORDER_TASK_INFORMATION entity)
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();
            if (entity != null && ModelState.IsValid)
            {   //数据校验

                string currentPerson = GetCurrentPerson();
                entity.UPDATETIME = DateTime.Now;
                entity.UPDATEPERSON = currentPerson;

                string returnValue = string.Empty;
                if (m_BLL.Edit(ref validationErrors, entity))
                {
                    LogClassModels.WriteServiceLog(Suggestion.UpdateSucceed + "，委托单信息信息的Id为" + entity.ID, "委托单信息"
                        );//写入日志                   
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.UpdateSucceed;
                    return result; //提示更新成功 
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.UpdateFail + "，委托单信息信息的Id为" + entity.ID + "," + returnValue, "委托单信息"
                        );//写入日志   
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.UpdateFail + returnValue;
                    return result; //提示更新失败
                }
            }
            result.Code = Common.ClientCode.FindNull;
            result.Message = Suggestion.UpdateFail + "请核对输入的数据的格式";
            return result; //提示输入的数据的格式不对         
        }

        // DELETE api/<controller>/5
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>  
        public Common.ClientResult.Result Delete(string query)
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();

            string returnValue = string.Empty;
            string[] deleteId = query.GetString().Split(',');
            if (deleteId != null && deleteId.Length > 0)
            {
                if (m_BLL.DeleteCollection(ref validationErrors, deleteId))
                {
                    LogClassModels.WriteServiceLog(Suggestion.DeleteSucceed + "，信息的Id为" + string.Join(",", deleteId), "消息"
                        );//删除成功，写入日志
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.DeleteSucceed;
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.DeleteFail + "，信息的Id为" + string.Join(",", deleteId) + "," + returnValue, "消息"
                        );//删除失败，写入日志
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.DeleteFail + returnValue;
                }
            }
            return result;
        }

        IBLL.IORDER_TASK_INFORMATIONBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public ORDER_TASK_INFORMATIONApiController()
            : this(new ORDER_TASK_INFORMATIONBLL()) { }

        public ORDER_TASK_INFORMATIONApiController(ORDER_TASK_INFORMATIONBLL bll)
        {
            m_BLL = bll;
        }

    }
}


