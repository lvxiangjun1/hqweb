//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5485
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// -------------------------------------------------------------
// 
//             Powered By： SR3.1(SmartRobot For SmartPersistenceLayer 3.1) 听棠
//             Created By： Administrator
//             Created Time： 2016/5/11 13:36:27
// 
// -------------------------------------------------------------
namespace Web.BusinessEntity
{
    using System;
    using System.Collections;
    using System.Data;
    using PersistenceLayer;
    
    
    /// <summary>该类的摘要说明</summary>
    [Serializable()]
    public class T_LAWHELPPICEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>LAWHELPID</summary>
        public const string @__LAWHELPID = "LAWHELPID";
        
        /// <summary>PICURL</summary>
        public const string @__PICURL = "PICURL";
        
        private decimal m_ID;
        
        private decimal m_LAWHELPID;
        
        private string m_PICURL;
        
        /// <summary>构造函数</summary>
        public T_LAWHELPPICEntity()
        {
        }
        
        /// <summary>属性ID </summary>
        public decimal ID
        {
            get
            {
                return this.m_ID;
            }
            set
            {
                this.m_ID = value;
            }
        }
        
        /// <summary>属性LAWHELPID </summary>
        public decimal LAWHELPID
        {
            get
            {
                return this.m_LAWHELPID;
            }
            set
            {
                this.m_LAWHELPID = value;
            }
        }
        
        /// <summary>属性PICURL </summary>
        public string PICURL
        {
            get
            {
                return this.m_PICURL;
            }
            set
            {
                this.m_PICURL = value;
            }
        }
    }
    
    /// T_LAWHELPPICEntity执行类
    public abstract class T_LAWHELPPICEntityAction
    {
        
        private T_LAWHELPPICEntityAction()
        {
        }
        
        public static void Save(T_LAWHELPPICEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_LAWHELPPICEntity RetrieveAT_LAWHELPPICEntity(decimal ID)
        {
            T_LAWHELPPICEntity obj=new T_LAWHELPPICEntity();
            obj.ID=ID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                return obj;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static EntityContainer RetrieveT_LAWHELPPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_LAWHELPPICEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_LAWHELPPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_LAWHELPPICEntity));
            return rc.AsDataTable();
        }
    }
}
