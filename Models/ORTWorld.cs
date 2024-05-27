public static class ORTWorld {
    public static List<string> ListaDestinos {get; private set;}
    public static List<string> ListaHoteles {get; private set;}
    public static List<string> ListaAereos {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}
    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool esExitoso = true;
        if (Paquetes.ContainsKey(destinoSeleccionado))
            Paquetes.Add(destinoSeleccionado, paquete);
        else
            esExitoso = false;
        return esExitoso;
    }
}