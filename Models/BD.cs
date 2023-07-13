using System.Data.SqlClient;
using Dapper;
public class BD{

    private static List<Partido> _ListadoPartidos = new List<Partido>{};
    private static List<Candidato> _ListadoCandidatos = new List<Candidato>{};

    private static string _connectionString = @"Server=localhost;
    DataBase=Elecciones2023;Trusted_Connection=True;";

    public static void CargarPartido(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Partido";
            _ListadoPartidos=db.Query<Partido>(sql).ToList();
        }
    }

    public static void CargarCandidato(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato";
            _ListadoCandidatos=db.Query<Candidato>(sql).ToList();
        }
    }

    public static void AgregarCandidato(Candidato can){
        string SQL = "INSERT INTO Candidatos(IdPartido, Nombre, Apellido, Foto, Pustulcaion, FechaNacimiento) Values (@pIdPartido, @pNombre, @pApellido,  @pFoto, @pPustulcaion, @pFechaNacimiento,)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdPartido = can.IdPartido, pNombre=can.Nombre, pApellido=can.Apellido, pFoto=can.Foto, pPostulacion=can.Postulacion, pFechaNacimiento=can.FechaNacimiento});
        }
    }

    public static void ElmiminarCandidato(int IdCandidato){
        string SQL = "DELETE FROM Candidatos WHERE IdCandidato = @id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
        db.Execute(SQL, new{id = IdCandidato});
        }
    }

    public static Partido VerInfoPartido(int idPartido){
        for(int i=0; i<_ListadoPartidos.Count(); idPartido++){
            if(_ListadoPartidos[i].IdPartido == idPartido) { return _ListadoPartidos[i];}
        }
        return null;
    }

    public static Candidato VerInfoCandidato(int idCandidato){
        for(int i=0; i<_ListadoCandidatos.Count(); i++){
            if(_ListadoCandidatos[i].IdCandidato == idCandidato) { return _ListadoCandidatos[i];}
        }
        return null;
    }

    public static List<Partido> ListarPartidos(){
        return _ListadoPartidos;
    }

    public static List<Candidato> ListarCandidatos(int idPartido){
    List<Candidato> candidatos = null;
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "SELECT * FROM Candidato WHERE IdPartido = @idPartido";
        candidatos = db.Query<Candidato>(sql, new { idPartido }).ToList();
    }
    return candidatos;
}
}
