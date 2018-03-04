using System.ComponentModel;

namespace Automation.Common.DataModels
{
    public enum SitePages
    {
        [Description("phones")]
        Phones,

        [Description("tablets")]
        Tablets,

        [Description("user-groups")]
        UserGroups,

        [Description("computers")]
        Computers,

        [Description("accessories")]
        Accessories,
        
        [Description("login")]
        Login
    }
}