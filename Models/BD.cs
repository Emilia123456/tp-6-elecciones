using System.Data.SqlClient;
using Dapper;
public class BD{

    private static List<Partido> _ListadoPartidos = new List<Partido>{};
    private static List<Candidato> _ListadoCandidatos = new List<Candidato>{};

    private static string _connectionString = @"Server=localhost;
    DataBase=Elecciones2023;Trusted_Connection=True;";

    public void CargarPartido(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Pantentes";
            _ListadoPartidos=db.Query<Partido>(sql).ToList();
        }
    }

    public void CargarCandidato(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato";
            _ListadoCandidatos=db.Query<Candidato>(sql).ToList();
        }
    }

    public void AgregarCandidato(Candidato can){
        string SQL = "INSERT INTO Candidatos(IdPartido, Nombre, Apellido, Foto, Pustulcaion, FechaNacimiento) Values (@pIdPartido, @pNombre, @pApellido,  @pFoto, @pPustulcaion, @pFechaNacimiento,)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdPartido = can.IdPartido, pNombre=can.Nombre, pApellido=can.Apellido, pFoto=can.Foto, pPostulacion=can.Postulacion, pFechaNacimiento=can.FechaNacimiento});
        }
    }

    public void ElmiminarCandidato(int IdCandidato){
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

    
}
