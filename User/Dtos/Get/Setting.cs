using SettingBase = SearchAndRescue.User.Dtos.Base.Setting;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Setting : SettingBase
    {
        public Guid Id { get; set; }
    }
}
