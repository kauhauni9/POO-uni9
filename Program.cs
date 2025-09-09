Televisao tv = new Televisao(55f);
Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.MudarDeCanalComCanalEspecifico(520);
Console.WriteLine($"Canal Selecionado {tv.Canal}");

tv.MudarCanalParaBaixo();
Console.WriteLine($"Canal Selecionado {tv.Canal}");

tv.MudarCanalParaBaixo();
Console.WriteLine($"Canal Selecionado {tv.Canal}");

tv.MudarCanalParaCima();
Console.WriteLine($"Canal Selecionado {tv.Canal}");

tv.DesligarTV();
Console.WriteLine("Canal Desligada");

tv.LigarTV();
Console.WriteLine($"Canal Selecionado {tv.Canal}");