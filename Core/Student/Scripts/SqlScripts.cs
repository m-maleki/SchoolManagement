namespace Core.Student.Scripts;

public static class SqlScripts
{
    public static string Add = "INSERT INTO [dbo].[Students] " 
                               + "([FirstName],[LastName],[Age],[PhoneNumber])"
                               + "VALUES(N'{0}',N'{1}',{2},N'{3}')";

    public static string Delete = "DELETE FROM [Database-Maktab].[dbo].[Students] WHERE Id = {0}";

    public static string Get = "SELECT * FROM [dbo].[Students] WHERE Id = {0}";

    public static string GetAll = "SELECT * FROM [dbo].[Students]";
}