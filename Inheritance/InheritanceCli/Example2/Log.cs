namespace InheritanceCli.Example2
{
    abstract class Log
    {
        //private Dictionary<DateTime, string> _log = new Dictionary<DateTime, string>();

        /// <summary>
        /// Voegt een entry toe aan de Dictionary _log
        /// </summary>
        /// <param name="message"></param>
        public virtual void Write(string message)
        {
            LogDataClass.Logs.Add(DateTime.Now, message);
        }

        /// <summary>
        /// Toont de volledige log(Dictionary)
        /// </summary>
        public void DisplayLog()
        {
            foreach (var item in LogDataClass.Logs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
