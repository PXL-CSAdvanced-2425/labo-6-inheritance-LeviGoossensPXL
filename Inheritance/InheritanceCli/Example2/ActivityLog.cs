namespace InheritanceCli.Example2
{
    class ActivityLog : Log
    {
        public override void Write(string message)
        {
            base.Write($"ACTIVITY {message}");
        }
    }
}
