using NLog;

namespace WpfBusanFestivalApp.Helpers
{
    public static class Common
    {
        // 전체 프로젝트에서 사용할 NLog 객체
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();
    }
}
