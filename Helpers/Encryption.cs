﻿namespace SearchAndRescue.Helpers
{
    using BCrypt.Net;

    public static class Encryption
    {
        public static string HashPassword(string password)
        {
            return BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Verify(password, hashedPassword);
        }
    }
}
