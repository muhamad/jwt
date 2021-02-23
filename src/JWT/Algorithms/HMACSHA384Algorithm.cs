﻿using System.Security.Cryptography;

namespace JWT.Algorithms
{
    /// <summary>
    /// HMAC using SHA-384
    /// </summary>
    public sealed class HMACSHA384Algorithm : HMACSHAAlgorithm
    {
        /// <inheritdoc />
        public override HashAlgorithmName HashAlgorithmName => HashAlgorithmName.SHA384;

        protected override HMAC CreateAlgorithm(byte[] key) => new HMACSHA512(key);
    }
}
