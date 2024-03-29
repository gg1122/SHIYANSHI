﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SysEntities : DbContext
    {
        public SysEntities()
            : base("name=SysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AC_VOLTAGE_CURRENT> AC_VOLTAGE_CURRENT { get; set; }
        public virtual DbSet<ACTIVE_POWER> ACTIVE_POWER { get; set; }
        public virtual DbSet<ALLOWABLE_ERROR> ALLOWABLE_ERROR { get; set; }
        public virtual DbSet<APPLIANCE_DETAIL_INFORMATION> APPLIANCE_DETAIL_INFORMATION { get; set; }
        public virtual DbSet<APPLIANCE_LABORATORY> APPLIANCE_LABORATORY { get; set; }
        public virtual DbSet<APPLIANCECOLLECTION> APPLIANCECOLLECTION { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<CROSS_COS> CROSS_COS { get; set; }
        public virtual DbSet<CROSS_FREQUENCY_POWER_FACTOR> CROSS_FREQUENCY_POWER_FACTOR { get; set; }
        public virtual DbSet<CROSS_HEAD> CROSS_HEAD { get; set; }
        public virtual DbSet<CROSS_SIN> CROSS_SIN { get; set; }
        public virtual DbSet<CROSS_VOLTAGE_CURRENT> CROSS_VOLTAGE_CURRENT { get; set; }
        public virtual DbSet<DC_CURRENT_OUTPUT> DC_CURRENT_OUTPUT { get; set; }
        public virtual DbSet<DC_VOLTAGE_CURRENT_MEASURE> DC_VOLTAGE_CURRENT_MEASURE { get; set; }
        public virtual DbSet<DC_VOLTAGE_CURRENT_MEASURE_CH> DC_VOLTAGE_CURRENT_MEASURE_CH { get; set; }
        public virtual DbSet<DC_VOLTAGE_MEASURE_NO_INDEX> DC_VOLTAGE_MEASURE_NO_INDEX { get; set; }
        public virtual DbSet<DC_VOLTAGE_OUTPUT> DC_VOLTAGE_OUTPUT { get; set; }
        public virtual DbSet<ERROR_LIMIT> ERROR_LIMIT { get; set; }
        public virtual DbSet<FILE_UPLOADER> FILE_UPLOADER { get; set; }
        public virtual DbSet<FileUploader> FileUploader { get; set; }
        public virtual DbSet<FREQUENCY> FREQUENCY { get; set; }
        public virtual DbSet<METERING_STANDARD_DEVICE> METERING_STANDARD_DEVICE { get; set; }
        public virtual DbSet<METERING_STANDARD_DEVICE_CHECK> METERING_STANDARD_DEVICE_CHECK { get; set; }
        public virtual DbSet<ORDER_TASK_INFORMATION> ORDER_TASK_INFORMATION { get; set; }
        public virtual DbSet<OVERALL_TABLE> OVERALL_TABLE { get; set; }
        public virtual DbSet<PHASE> PHASE { get; set; }
        public virtual DbSet<PREPARE_SCHEME> PREPARE_SCHEME { get; set; }
        public virtual DbSet<PRINTREPORT> PRINTREPORT { get; set; }
        public virtual DbSet<PROJECTTEMPLET> PROJECTTEMPLET { get; set; }
        public virtual DbSet<QUALIFIED_UNQUALIFIED_TEST_ITE> QUALIFIED_UNQUALIFIED_TEST_ITE { get; set; }
        public virtual DbSet<REPORTCOLLECTION> REPORTCOLLECTION { get; set; }
        public virtual DbSet<RULE> RULE { get; set; }
        public virtual DbSet<SCHEME> SCHEME { get; set; }
        public virtual DbSet<SCHEME_RULE> SCHEME_RULE { get; set; }
        public virtual DbSet<SIGN> SIGN { get; set; }
        public virtual DbSet<STANDARDCHOICE> STANDARDCHOICE { get; set; }
        public virtual DbSet<SysAnnouncement> SysAnnouncement { get; set; }
        public virtual DbSet<SysDepartment> SysDepartment { get; set; }
        public virtual DbSet<SysDocument> SysDocument { get; set; }
        public virtual DbSet<SysDocumentTalk> SysDocumentTalk { get; set; }
        public virtual DbSet<SysEmail> SysEmail { get; set; }
        public virtual DbSet<SysEmailTemp> SysEmailTemp { get; set; }
        public virtual DbSet<SysException> SysException { get; set; }
        public virtual DbSet<SysField> SysField { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysMenu> SysMenu { get; set; }
        public virtual DbSet<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperation { get; set; }
        public virtual DbSet<SysMessage> SysMessage { get; set; }
        public virtual DbSet<SysMessageTemp> SysMessageTemp { get; set; }
        public virtual DbSet<SysNotice> SysNotice { get; set; }
        public virtual DbSet<SysOperation> SysOperation { get; set; }
        public virtual DbSet<SysPerson> SysPerson { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<THEAPPROVALPROCESS> THEAPPROVALPROCESS { get; set; }
        public virtual DbSet<THEREVIEWPROCESS> THEREVIEWPROCESS { get; set; }
        public virtual DbSet<THREE_PHASE_UNCERTAINTY> THREE_PHASE_UNCERTAINTY { get; set; }
        public virtual DbSet<TRANSMITER_SIN> TRANSMITER_SIN { get; set; }
        public virtual DbSet<TRANSMITTER_COS> TRANSMITTER_COS { get; set; }
        public virtual DbSet<TRANSMITTER_FREQUENCY_PHASE> TRANSMITTER_FREQUENCY_PHASE { get; set; }
        public virtual DbSet<TRANSMITTER_HEAD> TRANSMITTER_HEAD { get; set; }
        public virtual DbSet<TRANSMITTER_POWER_FACTOR> TRANSMITTER_POWER_FACTOR { get; set; }
        public virtual DbSet<TRANSMITTER_RANGE> TRANSMITTER_RANGE { get; set; }
        public virtual DbSet<UNCERTAINTY> UNCERTAINTY { get; set; }
        public virtual DbSet<UNCERTAINTY2_HZ> UNCERTAINTY2_HZ { get; set; }
        public virtual DbSet<UNCERTAINTYPARAMETERMANAGEMENT> UNCERTAINTYPARAMETERMANAGEMENT { get; set; }
        public virtual DbSet<UNCERTAINTYTABLE> UNCERTAINTYTABLE { get; set; }
        public virtual DbSet<UNDERTAKE_LABORATORY> UNDERTAKE_LABORATORY { get; set; }
        public virtual DbSet<VBAOGAODAYIN> VBAOGAODAYIN { get; set; }
        public virtual DbSet<VBIAOZHUNLIANGCHUANGONGZHUO> VBIAOZHUNLIANGCHUANGONGZHUO { get; set; }
        public virtual DbSet<VGONGZUOSHICHANG> VGONGZUOSHICHANG { get; set; }
        public virtual DbSet<VJIANDINGRENWU> VJIANDINGRENWU { get; set; }
        public virtual DbSet<VQIJULINGQU1> VQIJULINGQU1 { get; set; }
        public virtual DbSet<VQIJULINGQU2> VQIJULINGQU2 { get; set; }
        public virtual DbSet<VRUKU> VRUKU { get; set; }
        public virtual DbSet<VRULE> VRULE { get; set; }
        public virtual DbSet<VSHENHE> VSHENHE { get; set; }
        public virtual DbSet<VSHENPI> VSHENPI { get; set; }
        public virtual DbSet<VSHIYANSHIGONGZUOLIANG> VSHIYANSHIGONGZUOLIANG { get; set; }
        public virtual DbSet<VZHENGSHULEIBEITONGJIFENXI> VZHENGSHULEIBEITONGJIFENXI { get; set; }
        public virtual DbSet<VZHENGSHUXINXICHAXUN> VZHENGSHUXINXICHAXUN { get; set; }
        public virtual DbSet<VXIANGQING> VXIANGQING { get; set; }
        public virtual DbSet<VTEST_ITE> VTEST_ITE { get; set; }
    
        public virtual ObjectResult<SHIYANSHIGONGZUO_Result> SHIYANSHIGONGZUO(Nullable<System.DateTime> sTARTDATE, Nullable<System.DateTime> eNDDATE, string dANWEI)
        {
            var sTARTDATEParameter = sTARTDATE.HasValue ?
                new ObjectParameter("STARTDATE", sTARTDATE) :
                new ObjectParameter("STARTDATE", typeof(System.DateTime));
    
            var eNDDATEParameter = eNDDATE.HasValue ?
                new ObjectParameter("ENDDATE", eNDDATE) :
                new ObjectParameter("ENDDATE", typeof(System.DateTime));
    
            var dANWEIParameter = dANWEI != null ?
                new ObjectParameter("DANWEI", dANWEI) :
                new ObjectParameter("DANWEI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SHIYANSHIGONGZUO_Result>("SHIYANSHIGONGZUO", sTARTDATEParameter, eNDDATEParameter, dANWEIParameter);
        }
    
        public virtual ObjectResult<RENYUANGONGZUOLIANG_Result> RENYUANGONGZUOLIANG(Nullable<System.DateTime> sTARTDATE, Nullable<System.DateTime> eNDDATE, string dANWEI)
        {
            var sTARTDATEParameter = sTARTDATE.HasValue ?
                new ObjectParameter("STARTDATE", sTARTDATE) :
                new ObjectParameter("STARTDATE", typeof(System.DateTime));
    
            var eNDDATEParameter = eNDDATE.HasValue ?
                new ObjectParameter("ENDDATE", eNDDATE) :
                new ObjectParameter("ENDDATE", typeof(System.DateTime));
    
            var dANWEIParameter = dANWEI != null ?
                new ObjectParameter("DANWEI", dANWEI) :
                new ObjectParameter("DANWEI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RENYUANGONGZUOLIANG_Result>("RENYUANGONGZUOLIANG", sTARTDATEParameter, eNDDATEParameter, dANWEIParameter);
        }
    
        public virtual ObjectResult<ZHENGSHUHAOLEIBIE_Result> ZHENGSHUHAOLEIBIE(Nullable<System.DateTime> sTARTDATE, Nullable<System.DateTime> eNDDATE, string dANWEI)
        {
            var sTARTDATEParameter = sTARTDATE.HasValue ?
                new ObjectParameter("STARTDATE", sTARTDATE) :
                new ObjectParameter("STARTDATE", typeof(System.DateTime));
    
            var eNDDATEParameter = eNDDATE.HasValue ?
                new ObjectParameter("ENDDATE", eNDDATE) :
                new ObjectParameter("ENDDATE", typeof(System.DateTime));
    
            var dANWEIParameter = dANWEI != null ?
                new ObjectParameter("DANWEI", dANWEI) :
                new ObjectParameter("DANWEI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ZHENGSHUHAOLEIBIE_Result>("ZHENGSHUHAOLEIBIE", sTARTDATEParameter, eNDDATEParameter, dANWEIParameter);
        }
    }
}
