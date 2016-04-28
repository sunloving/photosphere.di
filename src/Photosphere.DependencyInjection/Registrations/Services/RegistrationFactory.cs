﻿using Photosphere.DependencyInjection.Extensions;
using Photosphere.DependencyInjection.Lifetimes;
using Photosphere.DependencyInjection.Registrations.ValueObjects;
using Photosphere.DependencyInjection.StaticServices.CilEmitting;

namespace Photosphere.DependencyInjection.Registrations.Services
{
    internal class RegistrationFactory : IRegistrationFactory
    {
        public IRegistration Get<TService>(Lifetime lifetime)
        {
            return new Registration
            {
                ServiceType = typeof(TService),
                ImplementationType = typeof(TService).GetFirstImplementationType(),
                InstantiateFunction = InstantiateMethodGenerator.Generate<TService>(),
                Lifetime = lifetime
            };
        }
    }
}