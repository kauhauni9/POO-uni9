public class Televisao
{
    private const int VOL_MAX = 100;
    private const int CANAL_MAX = 520;
    private int CANAL_ANTES_DE_DESLIGAR = 0;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    public void AumentarVolume()
    {
        if(Volume < VOL_MAX)
        {
            Volume++;
        }
        else
        {
            Console.WriteLine("TV já está no max.");
        }
    }

    public void DiminuirVolume()
    {
        if(Volume < 0)
        {
            Console.WriteLine("A TV não possui volume negativo.");
        }
        else
        {
            Volume--;
        }
    }

    public void AtivarMudo()
    {
        Volume = 0;
    }

    public void LigarTV()
    {
        Estado = true;
        Canal = CANAL_ANTES_DE_DESLIGAR;
    }

    public void DesligarTV()
    {
        Estado = false;
        CANAL_ANTES_DE_DESLIGAR = Canal;
    }

    public void MudarCanalParaCima()
    {
        if(Canal > 520)
        {
            Console.WriteLine("Não existem mais canais.");
        }
        else{
            Canal++;
        }
    }

    public void MudarCanalParaBaixo()
    {
        if(Canal < 1)
        {
            Console.WriteLine("Não existem mais canais.");
        }
        else 
        {
            Canal--;
        }
    }

    public void MudarDeCanalComCanalEspecifico(int NumeroCanal)
    {
        if(NumeroCanal < 1 || NumeroCanal > 520) {
            Console.WriteLine("Canal Inválido!");
        } 
        else 
        {
            Canal = NumeroCanal;
        }
    }
}