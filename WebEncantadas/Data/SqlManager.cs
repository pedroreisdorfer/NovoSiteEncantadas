namespace WebEncantadas.Models.Repository
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch (tsql)
            {
                case TSql.EFETUAR_LOGIN:
                    sql = $"SELECT Emaill, Senha FROM Cadastro where Email = @Login and Senha = @Senha";
                    break;
            }

            return sql;
        }
    }
}
