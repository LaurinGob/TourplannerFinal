namespace Tourplanner.Logging
{
    // interface for log items
    public interface ILogItem
    {
        public void Info(string message);
        public void Warn(string message);
        public void Error(string message);
    }
}
