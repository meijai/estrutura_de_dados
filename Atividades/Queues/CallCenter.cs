using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queues
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<IncomingCall> Calls { get; private set; } = [];
        //Atenção: Metodos contrutores possuem o mesmo nome da classe, isso é uma regra!
        //são invocados quando constroi-se uma nova instancia do objeto deste tipo.
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }
        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall();
            call.Id = ++_counter;
            call.ClientId = clientId;
            call.CallTime = DateTime.Now;

            Calls.Enqueue(call);
        }

        public IncomingCall Answer(string consultant)
        {
            if (Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
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