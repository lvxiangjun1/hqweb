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
    public class T_SECHOUSEEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>DISTRICT</summary>
        public const string @__DISTRICT = "DISTRICT";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>PRICE</summary>
        public const string @__PRICE = "PRICE";
        
        /// <summary>ROOM</summary>
        public const string @__ROOM = "ROOM";
        
        /// <summary>HALL</summary>
        public const string @__HALL = "HALL";
        
        /// <summary>TOILET</summary>
        public const string @__TOILET = "TOILET";
        
        /// <summary>AREA</summary>
        public const string @__AREA = "AREA";
        
        /// <summary>CONTENT</summary>
        public const string @__CONTENT = "CONTENT";
        
        /// <summary>LINKMAN</summary>
        public const string @__LINKMAN = "LINKMAN";
        
        /// <summary>LINKPHONE</summary>
        public const string @__LINKPHONE = "LINKPHONE";
        
        /// <summary>QQCODE</summary>
        public const string @__QQCODE = "QQCODE";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>MEMBERID</summary>
        public const string @__MEMBERID = "MEMBERID";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        /// <summary>CHECKTIME</summary>
        public const string @__CHECKTIME = "CHECKTIME";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";

        /// <summary>SECHOUSEID</summary>
        public const string @__SECHOUSEID = "SECHOUSEID";
        
        
        private decimal m_ID;
        
        private string m_DISTRICT;
        
        private string m_TITLE;
        
        private decimal m_PRICE;
        
        private decimal m_ROOM;
        
        private decimal m_HALL;
        
        private decimal m_TOILET;
        
        private decimal m_AREA;
        
        private string m_CONTENT;
        
        private string m_LINKMAN;
        
        private string m_LINKPHONE;
        
        private string m_QQCODE;
        
        private decimal m_STATUS;
        
        private decimal m_MEMBERID;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        private System.DateTime m_CHECKTIME = DateTime.MinValue;
        
        private string m_USERNAME;

        private string m_SECHOUSEID;
        
        /// <summary>构造函数</summary>
        public T_SECHOUSEEntity()
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
        
        /// <summary>属性DISTRICT </summary>
        public string DISTRICT
        {
            get
            {
                return this.m_DISTRICT;
            }
            set
            {
                this.m_DISTRICT = value;
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
        
        /// <summary>属性PRICE </summary>
        public decimal PRICE
        {
            get
            {
                return this.m_PRICE;
            }
            set
            {
                this.m_PRICE = value;
            }
        }
        
        /// <summary>属性ROOM </summary>
        public decimal ROOM
        {
            get
            {
                return this.m_ROOM;
            }
            set
            {
                this.m_ROOM = value;
            }
        }
        
        /// <summary>属性HALL </summary>
        public decimal HALL
        {
            get
            {
                return this.m_HALL;
            }
            set
            {
                this.m_HALL = value;
            }
        }
        
        /// <summary>属性TOILET </summary>
        public decimal TOILET
        {
            get
            {
                return this.m_TOILET;
            }
            set
            {
                this.m_TOILET = value;
            }
        }
        
        /// <summary>属性AREA </summary>
        public decimal AREA
        {
            get
            {
                return this.m_AREA;
            }
            set
            {
                this.m_AREA = value;
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
        
        /// <summary>属性LINKMAN </summary>
        public string LINKMAN
        {
            get
            {
                return this.m_LINKMAN;
            }
            set
            {
                this.m_LINKMAN = value;
            }
        }
        
        /// <summary>属性LINKPHONE </summary>
        public string LINKPHONE
        {
            get
            {
                return this.m_LINKPHONE;
            }
            set
            {
                this.m_LINKPHONE = value;
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
        public decimal MEMBERID
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
        
        /// <summary>属性CHECKTIME </summary>
        public System.DateTime CHECKTIME
        {
            get
            {
                return this.m_CHECKTIME;
            }
            set
            {
                this.m_CHECKTIME = value;
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

        /// <summary>属性SECHOUSEID </summary>
        public string SECHOUSEID
        {
            get
            {
                return this.m_SECHOUSEID;
            }
            set
            {
                this.m_SECHOUSEID = value;
            }
        }
    }
    
    /// T_SECHOUSEEntity执行类
    public abstract class T_SECHOUSEEntityAction
    {
        
        private T_SECHOUSEEntityAction()
        {
        }
        
        public static void Save(T_SECHOUSEEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_SECHOUSEEntity RetrieveAT_SECHOUSEEntity(decimal ID)
        {
            T_SECHOUSEEntity obj=new T_SECHOUSEEntity();
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
        public static EntityContainer RetrieveT_SECHOUSEEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECHOUSEEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_SECHOUSEEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECHOUSEEntity));
            return rc.AsDataTable();
        }
    }
}