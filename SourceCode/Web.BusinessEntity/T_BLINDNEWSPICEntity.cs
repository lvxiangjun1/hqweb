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
    public class T_BLINDNEWSPICEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>BLINDNEWSID</summary>
        public const string @__BLINDNEWSID = "BLINDNEWSID";
        
        /// <summary>PICINFO</summary>
        public const string @__PICINFO = "PICINFO";
        
        /// <summary>PICURL</summary>
        public const string @__PICURL = "PICURL";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        private decimal m_ID;
        
        private decimal m_BLINDNEWSID;
        
        private string m_PICINFO;
        
        private string m_PICURL;
        
        private decimal m_STATUS;
        
        /// <summary>构造函数</summary>
        public T_BLINDNEWSPICEntity()
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
        
        /// <summary>属性BLINDNEWSID </summary>
        public decimal BLINDNEWSID
        {
            get
            {
                return this.m_BLINDNEWSID;
            }
            set
            {
                this.m_BLINDNEWSID = value;
            }
        }
        
        /// <summary>属性PICINFO </summary>
        public string PICINFO
        {
            get
            {
                return this.m_PICINFO;
            }
            set
            {
                this.m_PICINFO = value;
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
        
        /// <summary>属性STATUS </summary>
        public decimal STATUS
        {
            get
            {
                return this.m_STATUS;
            }
            set
            {
                this.m_STATUS = value;
            }
        }
    }
    
    /// T_BLINDNEWSPICEntity执行类
    public abstract class T_BLINDNEWSPICEntityAction
    {
        
        private T_BLINDNEWSPICEntityAction()
        {
        }
        
        public static void Save(T_BLINDNEWSPICEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_BLINDNEWSPICEntity RetrieveAT_BLINDNEWSPICEntity(decimal ID)
        {
            T_BLINDNEWSPICEntity obj=new T_BLINDNEWSPICEntity();
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
        public static EntityContainer RetrieveT_BLINDNEWSPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_BLINDNEWSPICEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_BLINDNEWSPICEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_BLINDNEWSPICEntity));
            return rc.AsDataTable();
        }
    }
}