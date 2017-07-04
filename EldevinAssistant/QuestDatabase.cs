using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldevinAssistant
{
    class QuestDatabase
    {
        #region Members
        ItemDatabase itemDatabase;
        Quest forestry1, forestry2, forestry3, forestry4, forestry5, forestry6, forestry7, forestry8, forestry9, forestry10;
        #endregion

        #region Constructor
        public QuestDatabase()
        {
            /* Items, their max stack size, and potential amounts depending on selected quests
             * 
             * Pynwood Logs (10): 10, 20, 30, 50, 
             * Wood Sap (25): 10, 15, 25
             */
            itemDatabase = new ItemDatabase();
            forestry1 = new Quest(1, itemDatabase.PynwoodLog, 10, null, 0, null, 0, null, 0, null, 0);
            forestry2 = new Quest(1, itemDatabase.PynwoodLog, 20, null, 0, null, 0, null, 0, null, 0);
            forestry3 = new Quest(1, itemDatabase.PynwoodLog, 20, itemDatabase.WoodSap, 10, itemDatabase.AbrasiveSpirit, 10, null, 0, null, 0);
            forestry4 = new Quest(1, itemDatabase.PynwoodLog, 30, itemDatabase.WoodSap, 15, itemDatabase.AbrasiveSpirit, 15, null, 0, null, 0);
            forestry5 = new Quest(1, itemDatabase.LithistleLog, 10, null, 0, null, 0, null, 0, null, 0);
            forestry6 = new Quest(1, itemDatabase.LithistleLog, 20, null, 0, null, 0, null, 0, null, 0);
            forestry7 = new Quest(1, itemDatabase.LithistleLog, 20, itemDatabase.WoodSap, 10, itemDatabase.WhiteSpirit, 10, null, 0, null, 0);
            forestry8 = new Quest(1, itemDatabase.ElmoreLog, 20, null, 0, null, 0, null, 0, null, 0);
            forestry9 = new Quest(1, itemDatabase.ElmoreLog, 20, null, 0, null, 0, null, 0, null, 0);
            forestry10 = new Quest(1, itemDatabase.ElmoreLog, 20, itemDatabase.WoodSap, 10, itemDatabase.SealingSpirit, 10, null, 0, null, 0);
        }
        #endregion
    }
}
