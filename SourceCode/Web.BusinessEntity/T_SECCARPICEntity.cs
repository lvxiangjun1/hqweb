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
//             Created Time： 2016/5/9 16:05:20
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
    public class T_SECCARPICEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>SECCARID</summary>
        public const string @__SECCARID = "SECCARID";
        
        /// <summary>PICURL</summary>
        public const string @__PICURL = "PICURL";
        
        /// <summary>ISTOP</summary>
        public const string @__ISTOP = "ISTOP";
        
        private decimal m_ID;

        private string m_SECCARID;
        
        private string m_PICURL;
        
        private decimal m_ISTOP;
        
        /// <summary>构造函数</summary>
        public T_SECCARPICEntity()
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
        
        /// <summary>属性SECCARID </summary>
        public string SECCARID
        {
            get
            {
                return this.m_SECCARID;
            }
            set
            {
                this.m_SECCARID = value;
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
        
        /// <summary>属性ISTOP </summary>
        public decimal ISTOP
        {
            get
            {
                return this.m_ISTOP;
            }
            set
            {
                this.m_ISTOP = value;
            }
        }
    }
    
    /// T_SECCARPICEntity执行类
    public abstract class T_SECCARPICEntityAction
    {
        
        private T_SECCARPICEntityAction()
        {
        }
        
        public static void Save(T_SECCARPICEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_SECCARPICEntity RetrieveAT_SECCARPICEntity(decimal ID)
        {
            T_SECCARPICEntity obj=new T_SECCARPICEntity();
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
        public static EntityContainer RetrieveT_SECCARPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECCARPICEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_SECCARPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECCARPICEntity));
            return rc.AsDataTable();
        }
    }
}