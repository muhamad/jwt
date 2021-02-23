using System.Security.Cryptography;

namespace JWT.Algorithms
{
    public abstract class HMACSHAAlgorithm : IJwtAlgorithm
    {
        /// <inheritdoc />
        public virtual string Name => this.HashAlgorithmName.ToString();

        /// <inheritdoc />
        public abstract HashAlgorithmName HashAlgorithmName { get; }
    }
}
