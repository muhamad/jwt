using System.Security.Cryptography;

namespace JWT.Algorithms
{
    /// <summary>
    /// HMAC using SHA-512
    /// </summary>
    public sealed class HMACSHA512Algorithm : HMACSHAAlgorithm
    {
        /// <inheritdoc />
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using var sha = new HMACSHA512(key);
            return sha.ComputeHash(bytesToSign);
        }

        /// <inheritdoc />
        public override HashAlgorithmName => HashAlgorithmName.SHA512;
    }
}
