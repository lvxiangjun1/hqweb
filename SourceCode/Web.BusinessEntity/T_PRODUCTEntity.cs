//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// -------------------------------------------------------------
// 
//             Powered By： SR3.1(SmartRobot For SmartPersistenceLayer 3.1) 听棠
//             Created By： lxj1987
//             Created Time： 2016/6/30 19:08:08
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
    public class T_PRODUCTEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";

        /// <summary>ID</summary>
        public const string @__PROID = "PROID";
        
        /// <summary>BAND</summary>
        public const string @__BAND = "BAND";
        
        /// <summary>PROTYPE</summary>
        public const string @__PROTYPE = "PROTYPE";
        
        /// <summary>INTRODUCE</summary>
        public const string @__INTRODUCE = "INTRODUCE";
        
        /// <summary>PRONAME</summary>
        public const string @__PRONAME = "PRONAME";
        
        /// <summary>PROSTATUS</summary>
        public const string @__PROSTATUS = "PROSTATUS";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>MEMBERID</summary>
        public const string @__MEMBERID = "MEMBERID";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        /// <summary>EDITIME</summary>
        public const string @__EDITIME = "EDITIME";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";

        /// <summary>ID</summary>
        public const string @__HITS = "HITS";
        
        private decimal m_ID;

        private string m_PROID;
        
        private string m_BAND;
        
        private string m_PROTYPE;
        
        private string m_INTRODUCE;
        
        private string m_PRONAME;
        
        private string m_PROSTATUS;
        
        private decimal m_STATUS;
        
        private string m_MEMBERID;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        private System.DateTime m_EDITIME = DateTime.MinValue;
        
        private string m_USERNAME;

        private decimal m_HITS;
        
        /// <summary>构造函数</summary>
        public T_PRODUCTEntity()
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

        /// <summary>属性PROID </summary>
        public string PROID
        {
            get
            {
                return this.m_PROID;
            }
            set
            {
                this.m_PROID = value;
            }
        }

        /// <summary>属性BAND </summary>
        public string BAND
        {
            get
            {
                return this.m_BAND;
            }
            set
            {
                this.m_BAND = value;
            }
        }
        
        /// <summary>属性PROTYPE </summary>
        public string PROTYPE
        {
            get
            {
                return this.m_PROTYPE;
            }
            set
            {
                this.m_PROTYPE = value;
            }
        }
        
        /// <summary>属性INTRODUCE </summary>
        public string INTRODUCE
        {
            get
            {
                return this.m_INTRODUCE;
            }
            set
            {
                this.m_INTRODUCE = value;
            }
        }
        
        /// <summary>属性PRONAME </summary>
        public string PRONAME
        {
            get
            {
                return this.m_PRONAME;
            }
            set
            {
                this.m_PRONAME = value;
            }
        }
        
        /// <summary>属性PROSTATUS </summary>
        public string PROSTATUS
        {
            get
            {
                return this.m_PROSTATUS;
            }
            set
            {
                this.m_PROSTATUS = value;
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
        
        /// <summary>属性MEMBERID </summary>
        public string MEMBERID
        {
            get
            {
                return this.m_MEMBERID;
            }
            set
            {
                this.m_MEMBERID = value;
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
        
        /// <summary>属性EDITIME </summary>
        public System.DateTime EDITIME
        {
            get
            {
                return this.m_EDITIME;
            }
            set
            {
                this.m_EDITIME = value;
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

    }
    
    /// T_PRODUCTEntity执行类
    public abstract class T_PRODUCTEntityAction
    {
        
        private T_PRODUCTEntityAction()
        {
        }
        
        public static void Save(T_PRODUCTEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_PRODUCTEntity RetrieveAT_PRODUCTEntity(decimal ID)
        {
            T_PRODUCTEntity obj=new T_PRODUCTEntity();
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
        public static EntityContainer RetrieveT_PRODUCTEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_PRODUCTEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_PRODUCTEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_PRODUCTEntity));
            return rc.AsDataTable();
        }
    }
}
