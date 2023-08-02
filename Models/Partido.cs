public class Partido{
    public int IdPartido {get; set;}
    public string Nombre {get; set;}
    public string Logo {get; set;}
    public string SitioWeb {get; set;}
    public DateTime FechaFundacion {get; set;}
    public int CantidadSenadores {get; set;}
    public int CantidadDiputados {get; set;}

    public Partido(int idpartido, string nombre, string logo, string sitioweb, DateTime fechafundacion, int cantidaddiputados, int cantidadsenadores){
        IdPartido=idpartido;
        Nombre=nombre;
        Logo=logo;
        SitioWeb=sitioweb;
        FechaFundacion=fechafundacion;
        CantidadDiputados=cantidaddiputados;
        CantidadSenadores=cantidadsenadores;    
    }

    public Partido(){}
} 
