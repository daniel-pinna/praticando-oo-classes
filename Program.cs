Livro l1 = new Livro();
l1.Titulo = "Dom Casmurro";
l1.Autor = "Machado de Assis";

Console.WriteLine($"Título: {l1.Titulo}");
Console.WriteLine($"Autor: {l1.Autor}");

Passagem passagem = new Passagem("Lucas Souza", "Paris");
Console.WriteLine($"\nPassageiro: {passagem.Passageiro}");
Console.WriteLine($"Destino: {passagem.Destino}");

ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);
Console.WriteLine($"\nNúmero da Conta: {conta.NumeroConta}");
Console.WriteLine($"Saldo Atual: {conta.Saldo}\n");

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);

funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
funcionario.Promover("Analista de Projetos");       // Promoção válida

Console.WriteLine("--- Após promoção ---");
Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);
 
Retangulo retangulo = new Retangulo();
retangulo.Largura = 5;
retangulo.Altura = 8;
retangulo.CalcularArea();

Filme filme = new Filme("Matrix", 16);
filme.ExibirResultado(14);
filme.ExibirResultado(20);

Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);

Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();

Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();

InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto2 = new ProdutoDigital("Photoshop", 89.99, info);
produto2.ExibirDetalhes();