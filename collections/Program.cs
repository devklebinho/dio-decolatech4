Console.WriteLine("------------------------------Dictionary/Dicionário--------------------------------");

Dictionary<string, string> estados = new Dictionary<string, string>();//chave, valor | a chave deve ser única
estados.Add("PE", "Pernambuco");
estados.Add("BA", "Bahia");
estados.Add("AC", "Acre");

foreach(KeyValuePair<string,  string> item in estados)//foreach var tbm funciona
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");//passa a chave como parâmetro para remoção
estados["AC"] = "Acreanos"; //alterando valor de uma chave

foreach(var item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

string chave = "AC";
Console.WriteLine($"Verificando se o elemento {chave} existe no dicionario");

if(estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
}
else
{
    Console.WriteLine("Valor não existente");
}

Console.WriteLine(estados["PE"]);//acessando um elemento no dicionário deve-se passar a chave como parâmetro

Console.WriteLine("------------------------------Stack/Pilha--------------------------------");

Stack<int> pilha = new Stack<int>();//Declaração

pilha.Push(3);
pilha.Push(5);
pilha.Push(2);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o objeto {pilha.Pop()} do topo da pilha\n");
pilha.Push(67);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------Queue/Fila--------------------------------");

Queue<int> fila = new Queue<int>();//Declaração

fila.Enqueue(2);//1°
fila.Enqueue(5);//2°
fila.Enqueue(7);//3°
fila.Enqueue(8);//4°

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}\n");//sempre remove o primeiro elemento da fila
fila.Enqueue(3);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

