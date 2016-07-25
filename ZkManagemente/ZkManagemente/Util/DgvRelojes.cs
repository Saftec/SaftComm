using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZkManagement.Util
{
    class DgvRelojes : DataGridView
    {

        public string GetIp()
        {
            return (this.CurrentRow.Cells[1].Value).ToString(); 
        }
    }
}
