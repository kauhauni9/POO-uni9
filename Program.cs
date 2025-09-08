Televisao tv = new Televisao(55f);
Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AtivarMudo();
Console.WriteLine($"Volume {tv.Volume}");