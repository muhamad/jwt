using System.Security.Cryptography;

namespace Jwt.Algorithms
{
    public abstract class HMACAlgorithm : IJwtAlgorithm
    {
        /// <inheritdoc />
        public virtual string Name => this.HashAlgorithmName.ToString();

        /// <inheritdoc />
        public abstract HashAlgorithmName HashAlgorithmName { get; }
    }
}
