﻿using System;

namespace JWT.Algorithms
{
    /// <inheritdoc />
    public abstract class JwtAlgorithmFactory : IAlgorithmFactory
    {
        /// <inheritdoc />
        public virtual IJwtAlgorithm Create(JwtDecoderContext context)
        {
            var algorithmName = (JwtAlgorithmName)Enum.Parse(typeof(JwtAlgorithmName), context.Header.Algorithm);
            return Create(algorithmName);
        }

        protected abstract IJwtAlgorithm Create(JwtAlgorithmName algorithm);
    }
}