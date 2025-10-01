using System.Formats.Asn1;
namespace testando
{
    public class Program
    {
        //Enum, quando criado, sempre que usado, so podem ser usados os valores que foram, declarados dentro dele
        //os indices sao definidos por padrao 0, 1, 2... mas posso definir um indicie colocando o nome = numero
        //exemplo
        //enum Cor { verde = 10, Vermelhor = 20}
        enum Cor { verde, vermelho, azul, ciano }
        static void Main()
        {
            /*
            Cor corFavorita = Cor.rosa; // nao posso atribuir um valor que nao esteja declarado no enum
            */
            //usando o enum
            Cor corFavorita = Cor.ciano;
            //aqui eu criei uma variavel usando a paleta do enum criado "Cor"


            //Tipos de dados

            int inteiro = 123;
            float numeroDecimal = 123.33f;
            string texto = "texto";
            bool booleano = true;
            var variavel = "qualquer uma das acima";
            dynamic dinamica = "qualquer uma das acima, mas ela pode ser alterada para outros tipos";
            const string permanente = "nao pode ser alterado o valor";
            string cor = "ciano";


            //Como usar o Switch(opcao mais viavel que if, else if, else)
            //so pode ser usado para comparações de igualdade
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("Azul");
                    break;
                case "vermelho":
                    Console.WriteLine("Vermelho");
                    break;
                case "ciano":
                    Console.WriteLine("Ciano");
                    break;
                default:
                    Console.WriteLine("retorno padrao caso n contenha a opcao");
                    break;
            }

            //chamada de uma funcao
            Teste();
        }

        static void Teste()
        {
            int batata = 40;
            Console.WriteLine(batata);
        }
    }
}
