using InheritanceCli.Example2;

namespace InheritanceCli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ActivityLog activityLog = new ActivityLog();
            activityLog.Write("message2");

            ErrorLog errorLog = new ErrorLog();
            errorLog.Write("message3");

            activityLog.DisplayLog();
            //errorLog.DisplayLog();
        }
    }
}