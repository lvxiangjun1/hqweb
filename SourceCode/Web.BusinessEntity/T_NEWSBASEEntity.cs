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
    public class T_NEWSBASEEntity : EntityObject
    {
        
        /// <summary>ID</summary>
        public const string @__ID = "ID";
        
        /// <summary>NODEID</summary>
        public const string @__NODEID = "NODEID";
        
        /// <summary>TITLE</summary>
        public const string @__TITLE = "TITLE";
        
        /// <summary>COPYRIGHT</summary>
        public const string @__COPYRIGHT = "COPYRIGHT";
        
        /// <summary>AUTHOR</summary>
        public const string @__AUTHOR = "AUTHOR";
        
        /// <summary>PUBLISHTIME</summary>
        public const string @__PUBLISHTIME = "PUBLISHTIME";
        
        /// <summary>HITS</summary>
        public const string @__HITS = "HITS";
        
        /// <summary>CONTENT</summary>
        public const string @__CONTENT = "CONTENT";
        
        /// <summary>DEFAULTPICURL</summary>
        public const string @__DEFAULTPICURL = "DEFAULTPICURL";
        
        /// <summary>USERNAME</summary>
        public const string @__USERNAME = "USERNAME";
        
        /// <summary>INSERTTIME</summary>
        public const string @__INSERTTIME = "INSERTTIME";
        
        /// <summary>UPDATEUSERNAME</summary>
        public const string @__UPDATEUSERNAME = "UPDATEUSERNAME";
        
        /// <summary>UPDATETIME</summary>
        public const string @__UPDATETIME = "UPDATETIME";
        
        /// <summary>STATUS</summary>
        public const string @__STATUS = "STATUS";
        
        /// <summary>ISSPECIAL</summary>
        public const string @__ISSPECIAL = "ISSPECIAL";
        
        /// <summary>TITLEFONT</summary>
        public const string @__TITLEFONT = "TITLEFONT";
        
        /// <summary>TITLECOLOR</summary>
        public const string @__TITLECOLOR = "TITLECOLOR";
        
        /// <summary>TITLESIZE</summary>
        public const string @__TITLESIZE = "TITLESIZE";
        
        /// <summary>SUBTITLE</summary>
        public const string @__SUBTITLE = "SUBTITLE";
        
        /// <summary>SUBTITLEFONT</summary>
        public const string @__SUBTITLEFONT = "SUBTITLEFONT";
        
        /// <summary>SUBTITLECOLOR</summary>
        public const string @__SUBTITLECOLOR = "SUBTITLECOLOR";
        
        /// <summary>SUBTITLESIZE</summary>
        public const string @__SUBTITLESIZE = "SUBTITLESIZE";
        
        /// <summary>FILEPATH</summary>
        public const string @__FILEPATH = "FILEPATH";
        
        private decimal m_ID;
        
        private decimal m_NODEID;
        
        private string m_TITLE;
        
        private string m_COPYRIGHT;
        
        private string m_AUTHOR;
        
        private System.DateTime m_PUBLISHTIME = DateTime.MinValue;
        
        private decimal m_HITS;
        
        private string m_CONTENT;
        
        private string m_DEFAULTPICURL;
        
        private string m_USERNAME;
        
        private System.DateTime m_INSERTTIME = DateTime.MinValue;
        
        private string m_UPDATEUSERNAME;
        
        private System.DateTime m_UPDATETIME = DateTime.MinValue;
        
        private decimal m_STATUS;
        
        private string m_ISSPECIAL;
        
        private string m_TITLEFONT;
        
        private string m_TITLECOLOR;
        
        private decimal m_TITLESIZE;
        
        private string m_SUBTITLE;
        
        private string m_SUBTITLEFONT;
        
        private string m_SUBTITLECOLOR;
        
        private decimal m_SUBTITLESIZE;
        
        private string m_FILEPATH;
        
        /// <summary>构造函数</summary>
        public T_NEWSBASEEntity()
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
        
        /// <summary>属性NODEID </summary>
        public decimal NODEID
        {
            get
            {
                return this.m_NODEID;
            }
            set
            {
                this.m_NODEID = value;
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
        
        /// <summary>属性COPYRIGHT </summary>
        public string COPYRIGHT
        {
            get
            {
                return this.m_COPYRIGHT;
            }
            set
            {
                this.m_COPYRIGHT = value;
            }
        }
        
        /// <summary>属性AUTHOR </summary>
        public string AUTHOR
        {
            get
            {
                return this.m_AUTHOR;
            }
            set
            {
                this.m_AUTHOR = value;
            }
        }
        
        /// <summary>属性PUBLISHTIME </summary>
        public System.DateTime PUBLISHTIME
        {
            get
            {
                return this.m_PUBLISHTIME;
            }
            set
            {
                this.m_PUBLISHTIME = value;
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
        
        /// <summary>属性DEFAULTPICURL </summary>
        public string DEFAULTPICURL
        {
            get
            {
                return this.m_DEFAULTPICURL;
            }
            set
            {
                this.m_DEFAULTPICURL = value;
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
        
        /// <summary>属性UPDATEUSERNAME </summary>
        public string UPDATEUSERNAME
        {
            get
            {
                return this.m_UPDATEUSERNAME;
            }
            set
            {
                this.m_UPDATEUSERNAME = value;
            }
        }
        
        /// <summary>属性UPDATETIME </summary>
        public System.DateTime UPDATETIME
        {
            get
            {
                return this.m_UPDATETIME;
            }
            set
            {
                this.m_UPDATETIME = value;
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
        
        /// <summary>属性ISSPECIAL </summary>
        public string ISSPECIAL
        {
            get
            {
                return this.m_ISSPECIAL;
            }
            set
            {
                this.m_ISSPECIAL = value;
            }
        }
        
        /// <summary>属性TITLEFONT </summary>
        public string TITLEFONT
        {
            get
            {
                return this.m_TITLEFONT;
            }
            set
            {
                this.m_TITLEFONT = value;
            }
        }
        
        /// <summary>属性TITLECOLOR </summary>
        public string TITLECOLOR
        {
            get
            {
                return this.m_TITLECOLOR;
            }
            set
            {
                this.m_TITLECOLOR = value;
            }
        }
        
        /// <summary>属性TITLESIZE </summary>
        public decimal TITLESIZE
        {
            get
            {
                return this.m_TITLESIZE;
            }
            set
            {
                this.m_TITLESIZE = value;
            }
        }
        
        /// <summary>属性SUBTITLE </summary>
        public string SUBTITLE
        {
            get
            {
                return this.m_SUBTITLE;
            }
            set
            {
                this.m_SUBTITLE = value;
            }
        }
        
        /// <summary>属性SUBTITLEFONT </summary>
        public string SUBTITLEFONT
        {
            get
            {
                return this.m_SUBTITLEFONT;
            }
            set
            {
                this.m_SUBTITLEFONT = value;
            }
        }
        
        /// <summary>属性SUBTITLECOLOR </summary>
        public string SUBTITLECOLOR
        {
            get
            {
                return this.m_SUBTITLECOLOR;
            }
            set
            {
                this.m_SUBTITLECOLOR = value;
            }
        }
        
        /// <summary>属性SUBTITLESIZE </summary>
        public decimal SUBTITLESIZE
        {
            get
            {
                return this.m_SUBTITLESIZE;
            }
            set
            {
                this.m_SUBTITLESIZE = value;
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
    }
    
    /// T_NEWSBASEEntity执行类
    public abstract class T_NEWSBASEEntityAction
    {
        
        private T_NEWSBASEEntityAction()
        {
        }
        
        public static void Save(T_NEWSBASEEntity obj)
        {
            if (obj!=null)
            {
                obj.Save();
            }
        }
        
        /// <summary>根据主键获取一个实体</summary>
        public static T_NEWSBASEEntity RetrieveAT_NEWSBASEEntity(decimal ID)
        {
            T_NEWSBASEEntity obj=new T_NEWSBASEEntity();
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
        public static EntityContainer RetrieveT_NEWSBASEEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_NEWSBASEEntity));
            return rc.AsEntityContainer();
        }
        
        /// <summary>获取所有实体(EntityContainer)</summary>
        public static DataTable GetT_NEWSBASEEntity()
        {
            RetrieveCriteria rc=new RetrieveCriteria(typeof(T_NEWSBASEEntity));
            return rc.AsDataTable();
        }
    }
}
