using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.Common
{
    public class InfoStruct
    {
        [Serializable]

        public struct LoginForm
        {
            public string loginID;         //登陆编号
            public string userName;        //坐席号
            public string passWord;        //登陆密码
            public string lastUrl;         //最后一次所在页面URL
        }
    }
}
