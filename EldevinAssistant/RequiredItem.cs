using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldevinAssistant
{
    public class RequiredItem
    {
        #region Members
        string name;
        List<string> locations;
        #endregion

        #region
        public RequiredItem(string _name, List<string> _locations)
        {
            name = _name;
            locations = _locations;
        }
        #endregion
    }
}
