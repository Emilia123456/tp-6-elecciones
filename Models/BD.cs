using System.Data.SqlClient;
using Dapper;
public class BD{
    
    //sacar las listas


    private static string _connectionString = @"Server=localhost;
    DataBase=Elecciones2023;Trusted_Connection=True;";

   
   
    //agregar candidato hace el insert de  UN candidato: OK
    public static void AgregarCandidato(Candidato can){
        string SQL = "INSERT INTO Candidatos(IdPartido, Nombre, Apellido, Foto, Pustulcaion, FechaNacimiento) Values (@pIdPartido, @pNombre, @pApellido,  @pFoto, @pPustulcaion, @pFechaNacimiento,)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{pIdPartido = can.IdPartido, pNombre=can.Nombre, pApellido=can.Apellido, pFoto=can.Foto, pPostulacion=can.Postulacion, pFechaNacimiento=can.FechaNacimiento});
        }
    }

    //eliminar candidato hace el insert de  UN candidato: OK
    public static void ElmiminarCandidato(int IdCandidato){
        string SQL = "DELETE FROM Candidatos WHERE IdCandidato = @id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
        db.Execute(SQL, new{id = IdCandidato});
        }
    }

    //retorna la informacion de UN Pardido
    public static Partido VerInfoPartido(int idPartido){
        //Ir a la base de datos y traer un partido

        for(int i=0; i<_ListadoPartidos.Count(); idPartido++){
            if(_ListadoPartidos[i].IdPartido == idPartido) { return _ListadoPartidos[i];}
        }
        return null;
    }

    //retorna la informacion de UN canditato
    public static Candidato VerInfoCandidato(int idCandidato){
        //Ir a la base de datos y traer un candidato
        for(int i=0; i<_ListadoCandidatos.Count(); i++){
            if(_ListadoCandidatos[i].IdCandidato == idCandidato) { return _ListadoCandidatos[i];}
        }
        return null;
    }

    //devuelve la LISTA de partidos
    public static List<Partido> ListarPartidos(){
        List<Partido> _ListadoPartidos = new List<Partido>{};
        //ir a buscarla AHORA a la base de datos y ternornala
        return _ListadoPartidos;
    }

    //devuelve la LISTA de candidatos de UN partido
    public static List<Candidato> ListarCandidatos(int idPartido){
    List<Candidato> candidatos = null;
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "SELECT * FROM Candidato WHERE IdPartido = @idPartido";
        //miren en la documentacion como reemplazae los @:  @idPartido
        candidatos = db.Query<Candidato>(sql, new { idPartido }).ToList();
    }
    return candidatos;
}
}
