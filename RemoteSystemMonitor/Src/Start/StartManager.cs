using System;

namespace RemoteSystemMonitor.Src.Start
{
    class StartManager
    {

        public static StartType DefineStartType(string[] args)
        {
            if (args.Length == 0)
            {
                return StartType.User;
            } else
            {
                return StartType.Silent.Equals(args[0]) ? StartType.Silent : StartType.User;
            }
        } 

    }
}
