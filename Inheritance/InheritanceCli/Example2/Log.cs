namespace InheritanceCli.Example2
{
    abstract class Log
    {
        //private Dictionary<DateTime, string> _log = new Dictionary<DateTime, string>();
        private string _fileName;

        protected Log(string fileName)
        {
            _fileName = fileName;
        }
        /// <summary>
        /// Voegt een entry toe aan de Dictionary _log
        /// </summary>
        /// <param name="message"></param>
        public virtual void Write(string message)
        {
            DateTime now = DateTime.Now;
            LogDataClass.Logs.Add(now, message);
            using StreamWriter sw = new StreamWriter(_fileName);
            sw.WriteLine($"{now}:\t{message}");
        }

        ///// <summary>
        ///// Toont de volledige log(Dictionary)
        ///// </summary>
        //public void DisplayLog()
        //{
        //    foreach (var item in LogDataClass.Logs)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }
        //}

        public abstract void DisplayLog();
    }
}
