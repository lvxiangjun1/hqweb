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
    public class T_BLINDACTIVITYEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>HITS</summary>
        public const string @__HITS = "HITS";
        
        /// <summary>CONTENT</summary>
        public const string @__CONTENT = "CONTENT";
        
        /// <summary>ACTIVITYTIME</summary>
        public const string @__ACTIVITYTIME = "ACTIVITYTIME";
        
        /// <summary>ADDRESS</summary>
        public const string @__ADDRESS = "ADDRESS";
        
        /// <summary>SIGNTIME</summary>
        public const string @__SIGNTIME = "SIGNTIME";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        private decimal m_ID;
        
        private string m_TITLE;
        
        private decimal m_HITS;
        
        private string m_CONTENT;
        
        private string m_ACTIVITYTIME;
        
        private string m_ADDRESS;
        
        private string m_SIGNTIME;
        
        private decimal m_STATUS;
        
        private string m_USERNAME;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        /// <summary>构造函数</summary>
        public T_BLINDACTIVITYEntity()
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
        
        /// <summary>属性TITLE </summary>
        public string TITLE
        {
            get
            {
                return this.m_TITLE;
            }
            set
            {
                this.m_TITLE = value;
            }
        }
        
        /// <summary>属性HITS </summary>
        public decimal HITS
        {
            get
            {
                return this.m_HITS;
            }
            set
            {
                this.m_HITS = value;
            }
        }
        
        /// <summary>属性CONTENT </summary>
        public string CONTENT
        {
            get
            {
                return this.m_CONTENT;
            }
            set
            {
                this.m_CONTENT = value;
            }
        }
        
        /// <summary>属性ACTIVITYTIME </summary>
        public string ACTIVITYTIME
        {
            get
            {
                return this.m_ACTIVITYTIME;
            }
            set
            {
                this.m_ACTIVITYTIME = value;
            }
        }
        
        /// <summary>属性ADDRESS </summary>
        public string ADDRESS
        {
            get
            {
                return this.m_ADDRESS;
            }
            set
            {
                this.m_ADDRESS = value;
            }
        }
        
        /// <summary>属性SIGNTIME </summary>
        public string SIGNTIME
        {
            get
            {
                return this.m_SIGNTIME;
            }
            set
            {
                this.m_SIGNTIME = value;
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
        
        /// <summary>属性USERNAME </summary>
        public string USERNAME
        {
            get
            {
                return this.m_USERNAME;
            }
            set
            {
                this.m_USERNAME = value;
            }
        }
        
        /// <summary>属性INSERTTIME </summary>
        public System.DateTime INSERTTIME
        {
            get
            {
                return this.m_INSERTTIME;
            }
            set
            {
                this.m_INSERTTIME = value;
            }
        }
    }
    
    /// T_BLINDACTIVITYEntity执行类
    public abstract class T_BLINDACTIVITYEntityAction
    {
        
        private T_BLINDACTIVITYEntityAction()
        {
        }
        
        public static void Save(T_BLINDACTIVITYEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_BLINDACTIVITYEntity RetrieveAT_BLINDACTIVITYEntity(decimal ID)
        {
            T_BLINDACTIVITYEntity obj=new T_BLINDACTIVITYEntity();
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
        public static EntityContainer RetrieveT_BLINDACTIVITYEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_BLINDACTIVITYEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_BLINDACTIVITYEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_BLINDACTIVITYEntity));
            return rc.AsDataTable();
        }
    }
}
