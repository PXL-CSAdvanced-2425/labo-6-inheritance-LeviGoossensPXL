namespace InheritanceCli.Example2
{
    class ErrorLog : Log
    {
        public ErrorLog(string fileName) : base(fileName)
        {
        }

        public override void Write(string message)
        {
            base.Write($"ERROR {message}");
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
