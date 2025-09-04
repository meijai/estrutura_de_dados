using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Queues
{
    public class CallCenter
    {
        private int _counter = 0;
        public ConcurrentQueue<IncomingCall> Calls { get; private set; }
        //Atenção: Metodos contrutores possuem o mesmo nome da classe, isso é uma regra!
        //são invocados quando constroi-se uma nova instancia do objeto deste tipo.
        public CallCenter()
        {
            Calls = new ConcurrentQueue<IncomingCall>();
        }
        public int Call(int clientId)
        {
            IncomingCall call = new IncomingCall();
            {
                Id = ++_counter;
                ClientId = clientId;
                CallTime = DateTime.Now;
            };
            Calls.Enqueue(call);
            return Calls.Count;
        }

        public IncomingCall Answer(string consultant)
        {
            if (Calls.Count > 0 && Calls.TryDequeue(out IncomingCall call))
            {
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;
                return call;
            }
            return null!;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}