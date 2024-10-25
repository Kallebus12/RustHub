using System.ComponentModel.DataAnnotations;

namespace RustHub.Business.CMS
{
    [GroupDefinitions]
    public static class GroupNames
    {
        [Display(Order = 10)]
        public const string Content = SystemTabNames.Content;

        [Display(GroupName = "Sidhuvud", Order = 2000)]
        public const string Header = "Sidhuvud";

        [Display(GroupName = "Sidfot", Order = 3000)]
        public const string Footer = "Sidfot";

        [Display(GroupName = "Framework", Order = 4000)]
        public const string Framework = "Framework";
    }
}