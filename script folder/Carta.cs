using Godot;

public partial class Carta : Resource
{
	public enum PintaCarta { Corazon, Diamante, Trebol, Pica, Comodin }

	[Export] public int Valor { get; set; }
	[Export] public PintaCarta Pinta { get; set; }

	public Carta() {}

	public Carta(int valor, PintaCarta pinta)
	{
		Valor = valor;
		Pinta = pinta;
	}
}
