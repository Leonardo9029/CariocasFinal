using Godot;
using System.Collections.Generic;

public partial class Mazo : Node
{
	public List<Carta> TodasLasCartas = new List<Carta>();

	public override void _Ready()
	{
		CrearMazoCarioca();
		MezclarMazo();
	}

	public void CrearMazoCarioca()
	{
		TodasLasCartas.Clear();
		for (int i = 0; i < 2; i++) // Dos mazos para jugar Carioca
		{
			foreach (Carta.PintaCarta pinta in System.Enum.GetValues(typeof(Carta.PintaCarta)))
			{
				if (pinta == Carta.PintaCarta.Comodin) continue;
				for (int valor = 1; valor <= 13; valor++)
				{
					TodasLasCartas.Add(new Carta(valor, pinta));
				}
			}
			// Agregamos los comodines
			TodasLasCartas.Add(new Carta(20, Carta.PintaCarta.Comodin));
			TodasLasCartas.Add(new Carta(20, Carta.PintaCarta.Comodin));
		}
		GD.Print($"¡Éxito! Se ha creado un mazo con {TodasLasCartas.Count} cartas.");
	}

	public void MezclarMazo()
	{
		System.Random aleatorio = new System.Random();
		for (int i = 0; i < TodasLasCartas.Count; i++)
		{
			Carta temporal = TodasLasCartas[i];
			int indice = aleatorio.Next(TodasLasCartas.Count);
			TodasLasCartas[i] = TodasLasCartas[indice];
			TodasLasCartas[indice] = temporal;
		}
		GD.Print("¡El mazo ha sido mezclado con éxito!");
	}
}
