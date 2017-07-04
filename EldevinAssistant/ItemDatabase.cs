using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldevinAssistant
{
    class ItemDatabase
    {
        #region Members
        public RequiredItem PynwoodLog { get; set; }
        public RequiredItem LithistleLog { get; set; }
        public RequiredItem ElmoreLog { get; set; }
        public RequiredItem WoodSap { get; set; }
        public RequiredItem AbrasiveSpirit { get; set; }
        public RequiredItem WhiteSpirit { get; set; }
        public RequiredItem SealingSpirit { get; set; }
        #endregion

        #region Constructor
        public ItemDatabase()
        {
            PynwoodLog = new RequiredItem("Pynwood Log", new List<string> { "To-Do" });
            LithistleLog = new RequiredItem("Lithistle Log", new List<string> { "To-Do" });
            ElmoreLog = new RequiredItem("Elmore Log", new List<string> { "To-Do" });
            WoodSap = new RequiredItem("Wood Sap", new List<string> { "All trees" });
            AbrasiveSpirit = new RequiredItem("Abrasive Spirit", new List<string> { "To-Do" });
            WhiteSpirit = new RequiredItem("White Spirit", new List<string> { "To-Do" });
            SealingSpirit = new RequiredItem("Sealing Spirit", new List<string> { "To-Do" });
        }
        #endregion
    }
}
