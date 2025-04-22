using InheritanceCli.Example2;

namespace InheritanceCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log baseLog = new Log();
            baseLog.Write("message1");

            ActivityLog activityLog = new ActivityLog();
            activityLog.Write("message2");

            ErrorLog errorLog = new ErrorLog();
            errorLog.Write("message3");

            baseLog.DisplayLog();
            //activityLog.DisplayLog();
            //errorLog.DisplayLog();
        }
    }
}