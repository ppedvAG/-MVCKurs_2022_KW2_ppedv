namespace DefaultWebAPI.Services
{
    public class TimeService : ITimeService
    {
        private string _currentTime;

        public TimeService()
        {
            _currentTime = DateTime.Now.ToString();
        }

        public string GetCurrentTime()
        {
            return _currentTime;
        }
    }
}
