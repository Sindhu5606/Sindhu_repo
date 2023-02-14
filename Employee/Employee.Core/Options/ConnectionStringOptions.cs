namespace Employee.Core.Options
{
    public class ConnectionStringOptions
    {
        public const string ConnectionString = "ConnectionString";
        public string DevDb { get; set; }
        public string Storage { get; set; }
    }
}
