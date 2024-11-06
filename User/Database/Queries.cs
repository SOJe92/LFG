namespace SearchAndRescue.User.Database
{
    public static class Queries
    {

        public static string TrySignin => "account.register_and_signin";

        public static string Signin => "account.signin";

        public static string Register => "account.register";

        public static string Permissions(string columns) => $"SELECT {columns} from account.get_featurepermissions(@puserid)";
    }
}
