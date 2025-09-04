using Queues;
static void Main(string [] args)
{
    CallCenter center = new CallCenter();
    Parallel.Invoke(
    () => CallersAction(center),
    () => ConsultantAction(center, "Marcin",
    ConsoleColor.Red),
    () => ConsultantAction(center, "James",
    ConsoleColor.Yellow),
    () => ConsultantAction(center, "Olivia",
    ConsoleColor.Green));
}
    while (center.AreWaitingCalls())
    {
        IncomingCall call = center.Answer("Paulão");
        Console.WriteLine($"{call.Id} de {call.ClientId} atendido por {call.Consultant}");
        Console.WriteLine($"-- Em: {call.StartTime}");

        Thread.Sleep(random.Next(1000, 3000));

        center.End(call);

        Console.WriteLine($"Chamado {call.Id} de {call.ClientId} encerrado por {call.Consultant}");
        Console.WriteLine($"-- Em: {call.EndTime}");
    }