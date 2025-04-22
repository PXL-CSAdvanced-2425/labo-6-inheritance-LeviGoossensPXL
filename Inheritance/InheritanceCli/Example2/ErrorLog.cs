namespace InheritanceCli.Example2
{
    class ErrorLog : Log
    {
        public override void Write(string message)
        {
            base.Write($"ERROR {message}");
        }
    }
}
