using Queues;

Random random = new Random();

CallCenter center = new CallCenter();
center.Call(1234);
center.Call(5678);
center.Call(1468);
center.Call(9641);
center.Call(4321);
center.Call(1122);

string[] consultants = { "Paulão", "Cleber", "Clotilde", "Bernenta", "Matilda" };

while (center.AreWaitingCalls())
{
    string consultant = consultants[random.Next(consultants.Length)];

    IncomingCall call = center.Answer(consultant);
    Console.WriteLine($"{call.Id} de {call.ClientId} atendido por {call.Consultant}");
    Console.WriteLine($"-- Em: {call.StartTime}");

    Thread.Sleep(random.Next(1000, 3000));

    center.End(call);

    Console.WriteLine($"Chamado {call.Id} de {call.ClientId} encerrado por {call.Consultant}");
    Console.WriteLine($"-- Em: {call.EndTime}");
}