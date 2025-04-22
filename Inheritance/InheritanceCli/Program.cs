using InheritanceCli.Example2;

namespace InheritanceCli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ActivityLog activityLog = new ActivityLog("log1.txt");
            activityLog.Write("message2");

            ErrorLog errorLog = new ErrorLog("log1.txt");
            errorLog.Write("message3");

            activityLog.DisplayLog();
            //errorLog.DisplayLog();
        }
    }
}