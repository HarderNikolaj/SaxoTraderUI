using System;
using System.Security.Cryptography;
namespace SaxoTraderUI.Models.Types
{
    public static class Constants
    {
        private static string state = GetRandomString(24);

        public static string State { get => state; set => state = value; }

        /// <summary>
        /// Create a random Base64Encoded string
        /// </summary>
        /// <returns></returns>
        private static string GetRandomString(int length)
        {
            byte[] bytes = RandomNumberGenerator.GetBytes(length);
            // Prevent confusion with "+" vs " ":
            return Convert.ToBase64String(bytes).Replace("+", "-");
        }
    }
}