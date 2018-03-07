using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.Common
{
    /// <summary>
    /// Summary description for Menu
    /// </summary>
    public class TreeMenu
    {
        public TreeMenu()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int ID { get; set; }

        public int ParentMenuID { get; set; }

        public string MenuName { get; set; }

        public string MenuClickURL { get; set; }

    }
}
