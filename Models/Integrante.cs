using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using Dapper;
public class Integrante
{
    [JsonProperty]
    public int id {get; set;}
     [JsonProperty]
    public string email {get; set;}
     [JsonProperty]
    public string nombre {get; set;}
     [JsonProperty]
    public string password {get; set;}
     [JsonProperty]
    public DateTime fechaNacimiento {get; set;}
     [JsonProperty]
    public string dni {get; set;}
     [JsonProperty]
    public string telefono {get; set;}
     [JsonProperty]
    public string direccion {get; set;}
     [JsonProperty]
    public string paisNacimiento {get; set;}
     [JsonProperty]
    public string colorFav {get; set;}
   
    public Integrante (string email, string nombre, string password, DateTime fechaNacimiento, string dni, string telefono, string direccion, string paisNacimiento, string colorFav)
    {
        this.email = email;
        this.nombre = nombre;
        this.password = password;
        this.fechaNacimiento = fechaNacimiento;
        this.dni = dni;
        this.telefono = telefono;
        this.direccion = direccion;
        this.paisNacimiento = paisNacimiento;
        this.colorFav = colorFav;
    }
    public Integrante ()
    {
        
    }
}