using System.Security.Cryptography;

namespace JWT.Algorithms
{
    /// <summary>
    /// HMAC using SHA-384
    /// </summary>
    public sealed class HMACSHA384Algorithm : HMACAlgorithm
    {
        /// <inheritdoc />
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using var sha = new HMACSHA384(key);
            return sha.ComputeHash(bytesToSign);
        }

        /// <inheritdoc />
        public override HashAlgorithmName => HashAlgorithmName.SHA384;
    }
}
