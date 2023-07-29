using System.Data.SqlClient;

namespace WebEncantadas.Data
{
    public class ContextLogin
    {
        //SqlConnection connection = ConnectionManager.GetConnection();
        

        //    var command = new SqlCommand("SELECT num_mesa, valor_cadeira FROM dbo.reserva_ingressos WHERE id = 1", connection);
        //    decimal valor_cadeira = 0;

        //    int num_mesa = 0;
        //    var valores_cadeira = new Dictionary<int, decimal>();
        //    var reader = command.ExecuteReader(); // função é chamada no objeto SqlCommand para executar a consulta SQL e retornar um objeto SqlDataReader que pode ser usado para ler as linhas do resultado da consulta.
        // while (reader.Read()) //A instrução if verifica se há alguma linha no resultado da consulta usando o método Read() do objeto SqlDataReader. Se houver pelo menos uma linha, o valor da coluna "valor_cadeira" é lido na variável "valor_cadeira" usando o método GetDecimal() do objeto SqlDataReader.
        //{
        //    num_mesa = reader.GetInt32(0);
        //    valor_cadeira = reader.GetDecimal(1);; // valor da cadeira
        //    // use a variável valor para exibir o valor na sua página HTML
        //    valores_cadeira[num_mesa] = valor_cadeira;
        //}
    }
}
