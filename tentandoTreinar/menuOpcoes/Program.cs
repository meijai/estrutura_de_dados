namespace menuOpcoes
{
    enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Selecione uma das opções a seguir:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            //int.Parse converte texto para inteiro
            //index serve para atribuir um valor
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer editar algo!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer listar algo!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar algo!");
                    break;
                default:
                    Console.WriteLine("Opcao Invalida!");
                    break;
            }
        }
    }   
}