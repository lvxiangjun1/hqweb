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
    public class T_SECCAREntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>BRAND</summary>
        public const string @__BRAND = "BRAND";
        
        /// <summary>CARCOLOR</summary>
        public const string @__CARCOLOR = "CARCOLOR";
        
        /// <summary>REGTIME</summary>
        public const string @__REGTIME = "REGTIME";
        
        /// <summary>ISCAREIN4S</summary>
        public const string @__ISCAREIN4S = "ISCAREIN4S";
        
        /// <summary>ISACCIDENT</summary>
        public const string @__ISACCIDENT = "ISACCIDENT";
        
        /// <summary>SURVEY</summary>
        public const string @__SURVEY = "SURVEY";
        
        /// <summary>INSURANCE</summary>
        public const string @__INSURANCE = "INSURANCE";
        
        /// <summary>COMPULSOTYINSURANCE</summary>
        public const string @__COMPULSOTYINSURANCE = "COMPULSOTYINSURANCE";
        
        /// <summary>DRIVING</summary>
        public const string @__DRIVING = "DRIVING";
        
        /// <summary>PRICE</summary>
        public const string @__PRICE = "PRICE";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>INTRODUCE</summary>
        public const string @__INTRODUCE = "INTRODUCE";
        
        /// <summary>LINKMAN</summary>
        public const string @__LINKMAN = "LINKMAN";
        
        /// <summary>LINKPHONE</summary>
        public const string @__LINKPHONE = "LINKPHONE";
        
        /// <summary>LOOKADDRESS</summary>
        public const string @__LOOKADDRESS = "LOOKADDRESS";
        
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

        /// <summary>SECCARID</summary>
        public const string @__SECCARID = "SECCARID";
        
        private decimal m_ID;
        
        private string m_BRAND;
        
        private string m_CARCOLOR;
        
        private string m_REGTIME;
        
        private decimal m_ISCAREIN4S;
        
        private decimal m_ISACCIDENT;
        
        private string m_SURVEY;
        
        private string m_INSURANCE;
        
        private string m_COMPULSOTYINSURANCE;
        
        private decimal m_DRIVING;
        
        private decimal m_PRICE;
        
        private string m_TITLE;
        
        private string m_INTRODUCE;
        
        private string m_LINKMAN;
        
        private string m_LINKPHONE;
        
        private string m_LOOKADDRESS;
        
        private decimal m_STATUS;
        
        private decimal m_MEMBERID;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        private System.DateTime m_CHECKTIME = DateTime.MinValue;

        private string m_SECCARID;
        
        private string m_USERNAME;
        
        /// <summary>构造函数</summary>
        public T_SECCAREntity()
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
        
        /// <summary>属性BRAND </summary>
        public string BRAND
        {
            get
            {
                return this.m_BRAND;
            }
            set
            {
                this.m_BRAND = value;
            }
        }
        
        /// <summary>属性CARCOLOR </summary>
        public string CARCOLOR
        {
            get
            {
                return this.m_CARCOLOR;
            }
            set
            {
                this.m_CARCOLOR = value;
            }
        }
        
        /// <summary>属性REGTIME </summary>
        public string REGTIME
        {
            get
            {
                return this.m_REGTIME;
            }
            set
            {
                this.m_REGTIME = value;
            }
        }
        
        /// <summary>属性ISCAREIN4S </summary>
        public decimal ISCAREIN4S
        {
            get
            {
                return this.m_ISCAREIN4S;
            }
            set
            {
                this.m_ISCAREIN4S = value;
            }
        }
        
        /// <summary>属性ISACCIDENT </summary>
        public decimal ISACCIDENT
        {
            get
            {
                return this.m_ISACCIDENT;
            }
            set
            {
                this.m_ISACCIDENT = value;
            }
        }
        
        /// <summary>属性SURVEY </summary>
        public string SURVEY
        {
            get
            {
                return this.m_SURVEY;
            }
            set
            {
                this.m_SURVEY = value;
            }
        }
        
        /// <summary>属性INSURANCE </summary>
        public string INSURANCE
        {
            get
            {
                return this.m_INSURANCE;
            }
            set
            {
                this.m_INSURANCE = value;
            }
        }
        
        /// <summary>属性COMPULSOTYINSURANCE </summary>
        public string COMPULSOTYINSURANCE
        {
            get
            {
                return this.m_COMPULSOTYINSURANCE;
            }
            set
            {
                this.m_COMPULSOTYINSURANCE = value;
            }
        }
        
        /// <summary>属性DRIVING </summary>
        public decimal DRIVING
        {
            get
            {
                return this.m_DRIVING;
            }
            set
            {
                this.m_DRIVING = value;
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
        
        /// <summary>属性LOOKADDRESS </summary>
        public string LOOKADDRESS
        {
            get
            {
                return this.m_LOOKADDRESS;
            }
            set
            {
                this.m_LOOKADDRESS = value;
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
    }
    
    /// T_SECCAREntity执行类
    public abstract class T_SECCAREntityAction
    {
        
        private T_SECCAREntityAction()
        {
        }
        
        public static void Save(T_SECCAREntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_SECCAREntity RetrieveAT_SECCAREntity(decimal ID)
        {
            T_SECCAREntity obj=new T_SECCAREntity();
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
        public static EntityContainer RetrieveT_SECCAREntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECCAREntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_SECCAREntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SECCAREntity));
            return rc.AsDataTable();
        }
    }
}
