﻿//------------------------------------------------------------------------------
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
//             Created Time： 2016/5/19 13:48:47
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
    public class T_TRANSACTIONBACKEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>TRANSACTIONID</summary>
        public const string @__TRANSACTIONID = "TRANSACTIONID";
        
        /// <summary>TARGETAREACODE</summary>
        public const string @__TARGETAREACODE = "TARGETAREACODE";
        
        /// <summary>TRANSACTIONTYPE</summary>
        public const string @__TRANSACTIONTYPE = "TRANSACTIONTYPE";
        
        /// <summary>TRANSACTIONSORT</summary>
        public const string @__TRANSACTIONSORT = "TRANSACTIONSORT";
        
        /// <summary>HELPTIME</summary>
        public const string @__HELPTIME = "HELPTIME";
        
        /// <summary>HELPCONTENT</summary>
        public const string @__HELPCONTENT = "HELPCONTENT";
        
        /// <summary>REPLYCONTENT</summary>
        public const string @__REPLYCONTENT = "REPLYCONTENT";
        
        /// <summary>REPLYTIME</summary>
        public const string @__REPLYTIME = "REPLYTIME";
        
        /// <summary>TRANSACTORID</summary>
        public const string @__TRANSACTORID = "TRANSACTORID";
        
        /// <summary>ORGCODE</summary>
        public const string @__ORGCODE = "ORGCODE";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>CALLED</summary>
        public const string @__CALLED = "CALLED";
        
        /// <summary>SESSIONID</summary>
        public const string @__SESSIONID = "SESSIONID";
        
        /// <summary>FILEPATH</summary>
        public const string @__FILEPATH = "FILEPATH";
        
        /// <summary>TYPICALFLAG</summary>
        public const string @__TYPICALFLAG = "TYPICALFLAG";
        
        /// <summary>NETSHOW</summary>
        public const string @__NETSHOW = "NETSHOW";
        
        /// <summary>ISOLDMAN</summary>
        public const string @__ISOLDMAN = "ISOLDMAN";
        
        /// <summary>ISEFFECT</summary>
        public const string @__ISEFFECT = "ISEFFECT";
        
        /// <summary>ISCOMINGCALL</summary>
        public const string @__ISCOMINGCALL = "ISCOMINGCALL";
        
        /// <summary>RELATIONTRANSID</summary>
        public const string @__RELATIONTRANSID = "RELATIONTRANSID";
        
        /// <summary>LOCALFILEPATH</summary>
        public const string @__LOCALFILEPATH = "LOCALFILEPATH";
        
        /// <summary>TYPEREMARK</summary>
        public const string @__TYPEREMARK = "TYPEREMARK";
        
        /// <summary>IFSH</summary>
        public const string @__IFSH = "IFSH";
        
        /// <summary>TORGCODE</summary>
        public const string @__TORGCODE = "TORGCODE";
        
        /// <summary>BJORGCODE</summary>
        public const string @__BJORGCODE = "BJORGCODE";
        
        /// <summary>IFXP</summary>
        public const string @__IFXP = "IFXP";
        
        /// <summary>IFYJXP</summary>
        public const string @__IFYJXP = "IFYJXP";
        
        /// <summary>IFSB</summary>
        public const string @__IFSB = "IFSB";
        
        /// <summary>OPERATIONTIME</summary>
        public const string @__OPERATIONTIME = "OPERATIONTIME";
        
        /// <summary>YCRESULT</summary>
        public const string @__YCRESULT = "YCRESULT";
        
        /// <summary>AREACODE</summary>
        public const string @__AREACODE = "AREACODE";
        
        /// <summary>QUERYTYPE</summary>
        public const string @__QUERYTYPE = "QUERYTYPE";
        
        /// <summary>CUSTOMERTYPE</summary>
        public const string @__CUSTOMERTYPE = "CUSTOMERTYPE";
        
        /// <summary>CALLTEL</summary>
        public const string @__CALLTEL = "CALLTEL";
        
        /// <summary>NAME</summary>
        public const string @__NAME = "NAME";
        
        /// <summary>SEX</summary>
        public const string @__SEX = "SEX";
        
        /// <summary>ADDRESS</summary>
        public const string @__ADDRESS = "ADDRESS";
        
        private decimal m_ID;
        
        private string m_TRANSACTIONID;
        
        private string m_TARGETAREACODE;
        
        private decimal m_TRANSACTIONTYPE;
        
        private string m_TRANSACTIONSORT;
        
        private System.DateTime m_HELPTIME = DateTime.MinValue;
        
        private string m_HELPCONTENT;
        
        private string m_REPLYCONTENT;
        
        private System.DateTime m_REPLYTIME = DateTime.MinValue;
        
        private string m_TRANSACTORID;
        
        private string m_ORGCODE;
        
        private decimal m_STATUS;
        
        private string m_CALLED;
        
        private string m_SESSIONID;
        
        private string m_FILEPATH;
        
        private decimal m_TYPICALFLAG;
        
        private decimal m_NETSHOW;
        
        private decimal m_ISOLDMAN;
        
        private decimal m_ISEFFECT;
        
        private decimal m_ISCOMINGCALL;
        
        private string m_RELATIONTRANSID;
        
        private string m_LOCALFILEPATH;
        
        private string m_TYPEREMARK;
        
        private decimal m_IFSH;
        
        private string m_TORGCODE;
        
        private string m_BJORGCODE;
        
        private decimal m_IFXP;
        
        private decimal m_IFYJXP;
        
        private decimal m_IFSB;
        
        private System.DateTime m_OPERATIONTIME = DateTime.MinValue;
        
        private decimal m_YCRESULT;
        
        private string m_AREACODE;
        
        private string m_QUERYTYPE;
        
        private string m_CUSTOMERTYPE;
        
        private string m_CALLTEL;
        
        private string m_NAME;
        
        private string m_SEX;
        
        private string m_ADDRESS;
        
        /// <summary>构造函数</summary>
        public T_TRANSACTIONBACKEntity()
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
        
        /// <summary>属性TRANSACTIONID </summary>
        public string TRANSACTIONID
        {
            get
            {
                return this.m_TRANSACTIONID;
            }
            set
            {
                this.m_TRANSACTIONID = value;
            }
        }
        
        /// <summary>属性TARGETAREACODE </summary>
        public string TARGETAREACODE
        {
            get
            {
                return this.m_TARGETAREACODE;
            }
            set
            {
                this.m_TARGETAREACODE = value;
            }
        }
        
        /// <summary>属性TRANSACTIONTYPE </summary>
        public decimal TRANSACTIONTYPE
        {
            get
            {
                return this.m_TRANSACTIONTYPE;
            }
            set
            {
                this.m_TRANSACTIONTYPE = value;
            }
        }
        
        /// <summary>属性TRANSACTIONSORT </summary>
        public string TRANSACTIONSORT
        {
            get
            {
                return this.m_TRANSACTIONSORT;
            }
            set
            {
                this.m_TRANSACTIONSORT = value;
            }
        }
        
        /// <summary>属性HELPTIME </summary>
        public System.DateTime HELPTIME
        {
            get
            {
                return this.m_HELPTIME;
            }
            set
            {
                this.m_HELPTIME = value;
            }
        }
        
        /// <summary>属性HELPCONTENT </summary>
        public string HELPCONTENT
        {
            get
            {
                return this.m_HELPCONTENT;
            }
            set
            {
                this.m_HELPCONTENT = value;
            }
        }
        
        /// <summary>属性REPLYCONTENT </summary>
        public string REPLYCONTENT
        {
            get
            {
                return this.m_REPLYCONTENT;
            }
            set
            {
                this.m_REPLYCONTENT = value;
            }
        }
        
        /// <summary>属性REPLYTIME </summary>
        public System.DateTime REPLYTIME
        {
            get
            {
                return this.m_REPLYTIME;
            }
            set
            {
                this.m_REPLYTIME = value;
            }
        }
        
        /// <summary>属性TRANSACTORID </summary>
        public string TRANSACTORID
        {
            get
            {
                return this.m_TRANSACTORID;
            }
            set
            {
                this.m_TRANSACTORID = value;
            }
        }
        
        /// <summary>属性ORGCODE </summary>
        public string ORGCODE
        {
            get
            {
                return this.m_ORGCODE;
            }
            set
            {
                this.m_ORGCODE = value;
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
        
        /// <summary>属性CALLED </summary>
        public string CALLED
        {
            get
            {
                return this.m_CALLED;
            }
            set
            {
                this.m_CALLED = value;
            }
        }
        
        /// <summary>属性SESSIONID </summary>
        public string SESSIONID
        {
            get
            {
                return this.m_SESSIONID;
            }
            set
            {
                this.m_SESSIONID = value;
            }
        }
        
        /// <summary>属性FILEPATH </summary>
        public string FILEPATH
        {
            get
            {
                return this.m_FILEPATH;
            }
            set
            {
                this.m_FILEPATH = value;
            }
        }
        
        /// <summary>属性TYPICALFLAG </summary>
        public decimal TYPICALFLAG
        {
            get
            {
                return this.m_TYPICALFLAG;
            }
            set
            {
                this.m_TYPICALFLAG = value;
            }
        }
        
        /// <summary>属性NETSHOW </summary>
        public decimal NETSHOW
        {
            get
            {
                return this.m_NETSHOW;
            }
            set
            {
                this.m_NETSHOW = value;
            }
        }
        
        /// <summary>属性ISOLDMAN </summary>
        public decimal ISOLDMAN
        {
            get
            {
                return this.m_ISOLDMAN;
            }
            set
            {
                this.m_ISOLDMAN = value;
            }
        }
        
        /// <summary>属性ISEFFECT </summary>
        public decimal ISEFFECT
        {
            get
            {
                return this.m_ISEFFECT;
            }
            set
            {
                this.m_ISEFFECT = value;
            }
        }
        
        /// <summary>属性ISCOMINGCALL </summary>
        public decimal ISCOMINGCALL
        {
            get
            {
                return this.m_ISCOMINGCALL;
            }
            set
            {
                this.m_ISCOMINGCALL = value;
            }
        }
        
        /// <summary>属性RELATIONTRANSID </summary>
        public string RELATIONTRANSID
        {
            get
            {
                return this.m_RELATIONTRANSID;
            }
            set
            {
                this.m_RELATIONTRANSID = value;
            }
        }
        
        /// <summary>属性LOCALFILEPATH </summary>
        public string LOCALFILEPATH
        {
            get
            {
                return this.m_LOCALFILEPATH;
            }
            set
            {
                this.m_LOCALFILEPATH = value;
            }
        }
        
        /// <summary>属性TYPEREMARK </summary>
        public string TYPEREMARK
        {
            get
            {
                return this.m_TYPEREMARK;
            }
            set
            {
                this.m_TYPEREMARK = value;
            }
        }
        
        /// <summary>属性IFSH </summary>
        public decimal IFSH
        {
            get
            {
                return this.m_IFSH;
            }
            set
            {
                this.m_IFSH = value;
            }
        }
        
        /// <summary>属性TORGCODE </summary>
        public string TORGCODE
        {
            get
            {
                return this.m_TORGCODE;
            }
            set
            {
                this.m_TORGCODE = value;
            }
        }
        
        /// <summary>属性BJORGCODE </summary>
        public string BJORGCODE
        {
            get
            {
                return this.m_BJORGCODE;
            }
            set
            {
                this.m_BJORGCODE = value;
            }
        }
        
        /// <summary>属性IFXP </summary>
        public decimal IFXP
        {
            get
            {
                return this.m_IFXP;
            }
            set
            {
                this.m_IFXP = value;
            }
        }
        
        /// <summary>属性IFYJXP </summary>
        public decimal IFYJXP
        {
            get
            {
                return this.m_IFYJXP;
            }
            set
            {
                this.m_IFYJXP = value;
            }
        }
        
        /// <summary>属性IFSB </summary>
        public decimal IFSB
        {
            get
            {
                return this.m_IFSB;
            }
            set
            {
                this.m_IFSB = value;
            }
        }
        
        /// <summary>属性OPERATIONTIME </summary>
        public System.DateTime OPERATIONTIME
        {
            get
            {
                return this.m_OPERATIONTIME;
            }
            set
            {
                this.m_OPERATIONTIME = value;
            }
        }
        
        /// <summary>属性YCRESULT </summary>
        public decimal YCRESULT
        {
            get
            {
                return this.m_YCRESULT;
            }
            set
            {
                this.m_YCRESULT = value;
            }
        }
        
        /// <summary>属性AREACODE </summary>
        public string AREACODE
        {
            get
            {
                return this.m_AREACODE;
            }
            set
            {
                this.m_AREACODE = value;
            }
        }
        
        /// <summary>属性QUERYTYPE </summary>
        public string QUERYTYPE
        {
            get
            {
                return this.m_QUERYTYPE;
            }
            set
            {
                this.m_QUERYTYPE = value;
            }
        }
        
        /// <summary>属性CUSTOMERTYPE </summary>
        public string CUSTOMERTYPE
        {
            get
            {
                return this.m_CUSTOMERTYPE;
            }
            set
            {
                this.m_CUSTOMERTYPE = value;
            }
        }
        
        /// <summary>属性CALLTEL </summary>
        public string CALLTEL
        {
            get
            {
                return this.m_CALLTEL;
            }
            set
            {
                this.m_CALLTEL = value;
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
    }
    
    /// T_TRANSACTIONBACKEntity执行类
    public abstract class T_TRANSACTIONBACKEntityAction
    {
        
        public T_TRANSACTIONBACKEntityAction()
        {
        }
        
        public static void Save(T_TRANSACTIONBACKEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_TRANSACTIONBACKEntity RetrieveAT_TRANSACTIONBACKEntity(decimal ID)
        {
            T_TRANSACTIONBACKEntity obj=new T_TRANSACTIONBACKEntity();
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
        public static EntityContainer RetrieveT_TRANSACTIONBACKEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_TRANSACTIONBACKEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_TRANSACTIONBACKEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_TRANSACTIONBACKEntity));
            return rc.AsDataTable();
        }
    }
}
