namespace InheritanceCli.Example2
{
    class ActivityLog : Log
    {
        public ActivityLog(string fileName) : base(fileName)
        {
        }

        public override void Write(string message)
        {
            base.Write($"ACTIVITY {message}");
        }

        public override void DisplayLog()
        {
            foreach (var item in LogDataClass.Logs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
