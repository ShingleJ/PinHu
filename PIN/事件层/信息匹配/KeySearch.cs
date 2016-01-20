using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;

namespace PIN
{
    public class KeySearch
    {
        //构造函数，实现关键字搜索
        public List<String[]> KeySearchResult(String key)
        {
            String connectionString = Parameters.event_info;
            String commandTextQuery = "select * from AllEvents where Event_Content like '%" + key + "%';";
            DTConnection con=new DTConnection();
            List<String[]> keyResult=con.ReadCon(commandTextQuery,connectionString);
            return keyResult;
        }
    }
}
