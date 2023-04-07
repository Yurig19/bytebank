using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
#region
/*Funcionario pedro = new Funcionario("38098765434", 2000);
pedro.Nome = "Pedro Costa Silveiro";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("34456895409");
roberta.Nome = "Roberta Silva";
Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificções = " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários = " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("O salário do Pedro agora é " + pedro.Salario);
Console.WriteLine("O salário da Roberta agora é " + roberta.Salario);
*/
#endregion

//CalcularBonificacao();

UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("65547897640");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("45698709832");
    paula.Nome = "Paula Gonçalves";

    Auxiliar igor = new Auxiliar("55690832450");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("256709544326");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de bonifícação = " + gerenciador.TotalDeBonificacao);
}
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("90876532421");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "8976";


    GerenteDeContas rosivalda = new GerenteDeContas("76895446790");
    rosivalda.Nome = "Rosivalda Da Silva";
    rosivalda.Senha = "54498";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "23456";


    sistema.Logar(ingrid, "8976");
    sistema.Logar(rosivalda, "5449");
    sistema.Logar(caio, "5449");


}
