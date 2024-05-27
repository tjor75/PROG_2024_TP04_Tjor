public static class ORTWorld {
    public static List<string> ListaDestinos {get; private set;} = new List<string>() {
        "Tokio, Japón", "Delhi, India", "Shanghái, China", "Dhaka, Bangladesh", "São Paulo, Brasil", "Ciudad de México, México", "El Cairo, Egipto", "Beijing, China", "Mumbai, India", "Osaka, Japón"
    };
    public static List<string> ListaHoteles {get; private set;} = new List<string>() {
        "hoteles/tokio-monday_haneda.jpg",
        "hoteles/delhi-hotel_le_roi.jpg",
        "hoteles/shanghai-jinjiang_inn.jpg",
        "hoteles/dhaka-regency_hotel_resort.jpg",
        "hoteles/sao_paulo-ibis_barra_funda.jpg",
        "hoteles/cdmx-mx_condesa.jpg",
        "hoteles/el_cairo-the_australian_hostel.jpg",
        "hoteles/beijing-happy_dragon_alley.jpg",
        "hoteles/mumbai-ginger_mumbai.jpg",
        "hoteles/osaka-sotetsu_fresa_inn_osaka_namba_ekimae.jpg"
    };
    public static List<string> ListaAereos {get; private set;}
    public static List<string> ListaExcursiones {get; private set;} = new List<string>() {
        "excursiones/tokio-go_kart_calle_shibuya.jpg",
        "excursiones/delhi-tour_taj_mahal_desde_delhi.jpg",
        "excursiones/shanghai-shanghai-autentico_recorrido_gastronomico_local_centro_shanghai.jpg",
        "excursiones/dhaka-fuerte_lalbag.jpg",
        "excursiones/sao_paulo-tour_biciletas_centro.jpg",
        "excursiones/cdmx-xochimilco_coyoacan_museo_frida_kalho.jpg",
        "excursiones/el_cairo-nuevo_recorrido_gran_museo_egipcio_recorrido_opcional_piramides.jpg",
        "excursiones/beijing-tour_4_horas_plaza_tiananmen_y_ciudad_prohibida.jpg",
        "excursiones/mumbai-aspectos_destacados_visita_turistica_privada.jpg",
        "excursiones/osaka-tour_privado_con_un_local_personalizado.jpg"
    };
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();
    
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