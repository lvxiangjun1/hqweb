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
//             Created Time： 2016/5/18 9:29:33
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
    public class SYS_USER_ENTEREntity : EntityObject
    {
        
        /// <summary>NB_ID</summary>
        public const string @__NB_ID = "NB_ID";
        
        /// <summary>VAR_ZH</summary>
        public const string @__VAR_ZH = "VAR_ZH";
        
        /// <summary>NB_ENTERID</summary>
        public const string @__NB_ENTERID = "NB_ENTERID";
        
        /// <summary>DT_ADD_TIME</summary>
        public const string @__DT_ADD_TIME = "DT_ADD_TIME";
        
        /// <summary>VAR_ADD_REMARK</summary>
        public const string @__VAR_ADD_REMARK = "VAR_ADD_REMARK";
        
        /// <summary>NB_ZT</summary>
        public const string @__NB_ZT = "NB_ZT";
        
        private decimal m_NB_ID;
        
        private string m_VAR_ZH;
        
        private decimal m_NB_ENTERID;
        
        private System.DateTime m_DT_ADD_TIME = DateTime.MinValue;
        
        private string m_VAR_ADD_REMARK;
        
        private decimal m_NB_ZT;
        
        /// <summary>构造函数</summary>
        public SYS_USER_ENTEREntity()
        {
        }
        
        /// <summary>属性NB_ID </summary>
        public decimal NB_ID
        {
            get
            {
                return this.m_NB_ID;
            }
            set
            {
                this.m_NB_ID = value;
            }
        }
        
        /// <summary>属性VAR_ZH </summary>
        public string VAR_ZH
        {
            get
            {
                return this.m_VAR_ZH;
            }
            set
            {
                this.m_VAR_ZH = value;
            }
        }
        
        /// <summary>属性NB_ENTERID </summary>
        public decimal NB_ENTERID
        {
            get
            {
                return this.m_NB_ENTERID;
            }
            set
            {
                this.m_NB_ENTERID = value;
            }
        }
        
        /// <summary>属性DT_ADD_TIME </summary>
        public System.DateTime DT_ADD_TIME
        {
            get
            {
                return this.m_DT_ADD_TIME;
            }
            set
            {
                this.m_DT_ADD_TIME = value;
            }
        }
        
        /// <summary>属性VAR_ADD_REMARK </summary>
        public string VAR_ADD_REMARK
        {
            get
            {
                return this.m_VAR_ADD_REMARK;
            }
            set
            {
                this.m_VAR_ADD_REMARK = value;
            }
        }
        
        /// <summary>属性NB_ZT </summary>
        public decimal NB_ZT
        {
            get
            {
                return this.m_NB_ZT;
            }
            set
            {
                this.m_NB_ZT = value;
            }
        }
    }
    
    /// SYS_USER_ENTEREntity执行类
    public abstract class SYS_USER_ENTEREntityAction
    {
        
        public SYS_USER_ENTEREntityAction()
        {
        }
        
        public static void Save(SYS_USER_ENTEREntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static SYS_USER_ENTEREntity RetrieveASYS_USER_ENTEREntity(decimal NB_ID)
        {
            SYS_USER_ENTEREntity obj=new SYS_USER_ENTEREntity();
            obj.NB_ID=NB_ID;
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
        public static EntityContainer RetrieveSYS_USER_ENTEREntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(SYS_USER_ENTEREntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetSYS_USER_ENTEREntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(SYS_USER_ENTEREntity));
            return rc.AsDataTable();
        }
    }
}
