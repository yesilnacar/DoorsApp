using System.ComponentModel;

namespace DoorsApp.Core.Enums
{
    public enum State
    {
        [Description("@")]
        Open = 1,
        [Description("H")]
        Hold,
        [Description("#")]
        Closed
    }
}
