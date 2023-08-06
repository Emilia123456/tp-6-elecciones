using System.Data.SqlClient;
using Dapper;
public class BD{
    
    //sacar las listas


    private static string _connectionString = @"Server=localhost; DataBase=Elecciones2023;Trusted_Connection=True;";

   
   
    //agregar candidato hace el insert de  UN candidato: OK
    public static void AgregarCandidato(Candidato can){
        string SQL = "INSERT INTO Candidato(IdPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion) Values (@pIdPartido, @pApellido, @pNombre, @pFechaNacimiento, @pFoto, @pPostulacion);";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdPartido = can.IdPartido, pNombre=can.Nombre, pApellido=can.Apellido, pFechaNacimiento=can.FechaNacimiento, pFoto=can.Foto, pPostulacion=can.Postulacion});
        }
    }

    //eliminar candidato hace el insert de  UN candidato: OK
    public static void ElmiminarCandidato(int IdCandidato){
        string SQL = "DELETE FROM Candidato WHERE IdCandidato = @id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
        db.Execute(SQL, new{id = IdCandidato});
        }
    }

    //retorna la informacion de UN Pardido: creo ok
    public static Partido VerInfoPartido(int verPartido){
        //Ir a la base de datos y traer un partido
    Partido partido = new Partido();
    using(SqlConnection db = new SqlConnection(_connectionString)){        
        string sql = "SELECT * FROM Partido WHERE IdPartido = @pverPartido";
        partido = db.QueryFirstOrDefault<Partido>(sql, new { pverPartido  = verPartido});
    }
    return partido;


    }

    //retorna la informacion de UN canditato: creo ok
    public static Candidato VerInfoCandidato(int idCandidato){
        //Ir a la base de datos y traer un candidato
        Candidato candidato = new Candidato();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato WHERE IdCandidato = @pIdCandidato";
            candidato = db.QueryFirstOrDefault<Candidato>(sql, new { pIdCandidato= idCandidato});
        }
        return candidato;
    }

    //devuelve la LISTA de partidos: creo ok
    public static List<Partido> ListarPartidos(){
        string sql = "SELECT * FROM Partido";
        //ir a buscarla AHORA a la base de datos y retornearla
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Partido>(sql).ToList();
        }
    }

    //devuelve la LISTA de candidatos de UN partido: creo ok
    public static List<Candidato> ListarCandidatos(int idpartido){
        string sql = "SELECT * FROM Candidato WHERE IdPartido = @pidpartido";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Candidato>(sql, new { pidPartido = idpartido}).ToList();
        }
    }
}
