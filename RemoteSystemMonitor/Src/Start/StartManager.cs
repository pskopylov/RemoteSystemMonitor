using System;

namespace RemoteSystemMonitor.Src.Start
{
    class StartManager
    {

        public static StartType DefineStartType(string[] args)
        {
            if (args.Length == 0)
            {
                return StartType.Auto;
            } else
            {
                return StartType.User.ToString().Equals(args[0]) ? StartType.User : StartType.Auto;
            }
        } 

    }
}
