namespace WebEncantadas.Models.Repository
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch (tsql)
            {
                case TSql.LOGIN_USUARIO:
                    sql = "";
                    break;
            }

            return sql;
        }
    }
}
