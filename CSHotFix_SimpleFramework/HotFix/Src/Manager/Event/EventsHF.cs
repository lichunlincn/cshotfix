using System;
using System.Collections.Generic;

using System.Text;


namespace HotFix
{

    public class EventsHF
    {
        public static EventsHF GetInstance()
        {
            return HotFixLoop.GetInstance().GetEvent();
        }


        public Action OnStartTestPerformanceEvent;
        public Action<uint> OnPlayerEnterEvent;
        public Action<string, bool> OnRedPointValueChange;
    }
}
