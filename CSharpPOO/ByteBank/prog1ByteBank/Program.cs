using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem-Vinde ao ByteBank!");

Cliente cliente1 = new Cliente();
cliente1.nome = "Myllene Mendes";
cliente1.cpf = "15689625433";
cliente1.profissao = "Estagiária";

Cliente cliente2 = new Cliente();
cliente2.nome = "Pedro Gonçalves";
cliente2.cpf = "69845612423";
cliente2.profissao = "Professor";


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = cliente1;
conta1.agencia = 23;
conta1.conta = 123456;
conta1.saldo += 30;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = cliente2;
conta2.agencia = 29;
conta2.conta = 569871;
conta2.saldo += 50.50;


//Console.WriteLine("\nTitular: " + conta1.titular + "\nAgência: " + conta1.agencia + "\nConta: " + conta1.conta + "\nSaldo: " + conta1.saldo);
//Console.WriteLine("\nTitular: " + conta2.titular + "\nAgência: " + conta2.agencia + "\nConta: " + conta2.conta + "\nSaldo: " + conta2.saldo);

Console.WriteLine("\nSaldo " + conta2.titular.nome + conta2.saldo);

bool saque = conta2.Sacar(50);
Console.WriteLine(saque ? "\nSaque bem sucedido!" : "\nSaque não realizado!"); 
Console.WriteLine("Saldo " + conta2.titular.nome + ": " + conta2.saldo);

conta2.Depositar(60);
Console.WriteLine("Saldo " + conta2.titular.nome + ": " + conta2.saldo);

Console.WriteLine("\nSaldo " + conta1.titular.nome + ": " + conta1.saldo);
bool transferencia = conta2.Transferir(60, conta1);
Console.WriteLine(transferencia ? "\nTransferência bem sucedida!" : "\nTransferência não realizada!");
Console.WriteLine("Saldo " + conta1.titular.nome + ": " + conta1.saldo);
Console.WriteLine("Saldo " + conta2.titular.nome + ": " + conta2.saldo);

