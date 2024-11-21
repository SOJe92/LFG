namespace SearchAndRescue.User.Database
{
    public static class Queries
    {

        public static string TrySignin => "account.register_and_signin";

        public static string Signin => "account.signin";

        public static string Register => "account.register";

        public static string AddContactType => "SELECT public.add_user_contacttype";

        public static string AddEntity => "SELECT public.add_user_entity";

        public static string AddFavourite => "SELECT public.add_user_favourite";

        public static string AddFavouriteEntity => "SELECT public.add_favourite_entity";

        public static string AddFavouriteProduct => "SELECT public.add_favourite_product";

        public static string AddFeature => "SELECT public.add_user_feature(@puserid, @pfeatureid, @ppermissionid, @penabled)";

        public static string AddKeyword => "SELECT public.add_user_keyword";

        public static string AddPOI => "SELECT public.add_user_poi";

        public static string AddProduct => "SELECT public.add_user_product";

        public static string AddSectorService => "SELECT public.add_user_sectorservice";

        public static string AddUser => "SELECT public.add_user_user";

        public static string DeleteEntity => "public.delete_user_entity";

        public static string DeleteFavourite => "public.delete_user_favourite";

        public static string DeleteFavouriteEntity => "public.delete_favourite_product";

        public static string DeleteFavouriteProduct => "public.delete_favourite_entity";

        public static string DeletePOI => "public.delete_user_poi";

        public static string DeleteProduct => "public.delete_user_product";

        public static string CreateSetting => "settings.create_user_setting";

        public static string UpdateSetting => "settings.update_user_setting";

        public static string UpdateRole => "public.update_user_role";
    }
}
