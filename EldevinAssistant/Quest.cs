using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldevinAssistant
{
    public class Quest
    {
        #region Members
        int skillLevel;
        RequiredItem item1;
        int quantity1;
        RequiredItem item2;
        int quantity2;
        RequiredItem item3;
        int quantity3;
        RequiredItem item4;
        int quantity4;
        RequiredItem item5;
        int quantity5;
        #endregion

        #region Constructor
        public Quest(int _skillLevel, RequiredItem _item1, int _quantity1, RequiredItem _item2, int _quantity2, RequiredItem _item3, int _quantity3,
            RequiredItem _item4, int _quantity4, RequiredItem _item5, int _quantity5)
        {
            skillLevel = _skillLevel;
            item1 = _item1;
            quantity1 = _quantity1;
            item2 = _item2;
            quantity2 = _quantity2;
            item3 = _item3;
            quantity3 = _quantity3;
            item4 = _item4;
            quantity4 = _quantity4;
            item5 = _item5;
            quantity5 = _quantity5;
        }
        #endregion
    }
}
