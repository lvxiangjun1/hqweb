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
    public class T_DOCTORINFOEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>NAME</summary>
        public const string @__NAME = "NAME";
        
        /// <summary>SEX</summary>
        public const string @__SEX = "SEX";
        
        /// <summary>HOSPITAL</summary>
        public const string @__HOSPITAL = "HOSPITAL";
        
        /// <summary>DEPARTMENT</summary>
        public const string @__DEPARTMENT = "DEPARTMENT";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>INTRODUCE</summary>
        public const string @__INTRODUCE = "INTRODUCE";
        
        /// <summary>PICURL</summary>
        public const string @__PICURL = "PICURL";
        
        /// <summary>ISSUPPORTONLINE</summary>
        public const string @__ISSUPPORTONLINE = "ISSUPPORTONLINE";
        
        /// <summary>QQCODE</summary>
        public const string @__QQCODE = "QQCODE";
        
        /// <summary>ISONLINE</summary>
        public const string @__ISONLINE = "ISONLINE";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        private decimal m_ID;
        
        private string m_NAME;
        
        private string m_SEX;
        
        private string m_HOSPITAL;
        
        private string m_DEPARTMENT;
        
        private string m_TITLE;
        
        private string m_INTRODUCE;
        
        private string m_PICURL;
        
        private decimal m_ISSUPPORTONLINE;
        
        private string m_QQCODE;
        
        private decimal m_ISONLINE;
        
        private decimal m_STATUS;
        
        private string m_USERNAME;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        /// <summary>构造函数</summary>
        public T_DOCTORINFOEntity()
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
        
        /// <summary>属性NAME </summary>
        public string NAME
        {
            get
            {
                return this.m_NAME;
            }
            set
            {
                this.m_NAME = value;
            }
        }
        
        /// <summary>属性SEX </summary>
        public string SEX
        {
            get
            {
                return this.m_SEX;
            }
            set
            {
                this.m_SEX = value;
            }
        }
        
        /// <summary>属性HOSPITAL </summary>
        public string HOSPITAL
        {
            get
            {
                return this.m_HOSPITAL;
            }
            set
            {
                this.m_HOSPITAL = value;
            }
        }
        
        /// <summary>属性DEPARTMENT </summary>
        public string DEPARTMENT
        {
            get
            {
                return this.m_DEPARTMENT;
            }
            set
            {
                this.m_DEPARTMENT = value;
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
        
        /// <summary>属性ISSUPPORTONLINE </summary>
        public decimal ISSUPPORTONLINE
        {
            get
            {
                return this.m_ISSUPPORTONLINE;
            }
            set
            {
                this.m_ISSUPPORTONLINE = value;
            }
        }
        
        /// <summary>属性QQCODE </summary>
        public string QQCODE
        {
            get
            {
                return this.m_QQCODE;
            }
            set
            {
                this.m_QQCODE = value;
            }
        }
        
        /// <summary>属性ISONLINE </summary>
        public decimal ISONLINE
        {
            get
            {
                return this.m_ISONLINE;
            }
            set
            {
                this.m_ISONLINE = value;
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
    
    /// T_DOCTORINFOEntity执行类
    public abstract class T_DOCTORINFOEntityAction
    {
        
        private T_DOCTORINFOEntityAction()
        {
        }
        
        public static void Save(T_DOCTORINFOEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_DOCTORINFOEntity RetrieveAT_DOCTORINFOEntity(decimal ID)
        {
            T_DOCTORINFOEntity obj=new T_DOCTORINFOEntity();
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
        public static EntityContainer RetrieveT_DOCTORINFOEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_DOCTORINFOEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_DOCTORINFOEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_DOCTORINFOEntity));
            return rc.AsDataTable();
        }
    }
}
