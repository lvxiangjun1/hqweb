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
//             Created Time： 2016/5/24 13:25:20
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
    public class T_SURVEYEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        /// <summary>ISPUBLISH</summary>
        public const string @__ISPUBLISH = "ISPUBLISH";
        
        private decimal m_ID;
        
        private string m_TITLE;
        
        private string m_USERNAME;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        private decimal m_ISPUBLISH;
        
        /// <summary>构造函数</summary>
        public T_SURVEYEntity()
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
        
        /// <summary>属性ISPUBLISH </summary>
        public decimal ISPUBLISH
        {
            get
            {
                return this.m_ISPUBLISH;
            }
            set
            {
                this.m_ISPUBLISH = value;
            }
        }
    }
    
    /// T_SURVEYEntity执行类
    public abstract class T_SURVEYEntityAction
    {
        
        private T_SURVEYEntityAction()
        {
        }
        
        public static void Save(T_SURVEYEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_SURVEYEntity RetrieveAT_SURVEYEntity(decimal ID)
        {
            T_SURVEYEntity obj=new T_SURVEYEntity();
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
        public static EntityContainer RetrieveT_SURVEYEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SURVEYEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_SURVEYEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_SURVEYEntity));
            return rc.AsDataTable();
        }
    }
}
