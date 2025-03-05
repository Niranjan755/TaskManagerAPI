using System;
using System.Security.Cryptography;

namespace TaskManagerAPI.Helpers
{
    public static class JwtHelper
    {
        public static string GenerateJwtSecretKey(int length = 32) // 32 bytes = 256 bits
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                var bytes = new byte[length];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}