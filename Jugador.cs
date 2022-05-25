class Jugador
{
    public Jugador()
    {    }

    public Jugador(string nombre)
    {
        Nombre = nombre;
    }

   public Jugador(string nombre, bool puedeJugar)
   {
       Nombre = nombre;
       PuedeJugar = puedeJugar;
   }
    public string Nombre { get; set; }
    public bool PuedeJugar { get; set; }
}