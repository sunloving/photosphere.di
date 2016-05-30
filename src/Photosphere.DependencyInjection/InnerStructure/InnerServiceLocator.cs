﻿using Photosphere.DependencyInjection.Generators;
using Photosphere.DependencyInjection.Generators.ObjectGraphs;
using Photosphere.DependencyInjection.Lifetimes.Scopes.Services;
using Photosphere.DependencyInjection.Registrations.Services;
using Photosphere.DependencyInjection.Registrations.Services.CompositionRoots;
using Photosphere.DependencyInjection.Registrations.ValueObjects;
using Photosphere.DependencyInjection.Resolving;

namespace Photosphere.DependencyInjection.InnerStructure
{
    internal class InnerServiceLocator
    {
        public InnerServiceLocator()
        {
            var registry = new Registry();
            var scopeKeeper = new ScopeKeeper();
            var resolver = new Resolver(registry);
            var assembliesProvider = new AssembliesProvider();
            var compositionRootProvider = new CompositionRootProvider(assembliesProvider);
            var validator = new Validator();
            var objectGraphProvider = new ObjectGraphProvider();
            var instantiateMethodGenerator = new InstantiateMethodGenerator(registry, scopeKeeper, objectGraphProvider);
            var registrationFactory = new RegistrationFactory(scopeKeeper, instantiateMethodGenerator);
            var registrator = new Registrator(registry, validator, registrationFactory);
            var registryInitializer = new RegistryInitializer(compositionRootProvider, registrator);

            ScopeKeeper = scopeKeeper;
            Resolver = resolver;
            RegistryInitializer = registryInitializer;
        }

        public IScopeKeeper ScopeKeeper { get; }
        public IResolver Resolver { get; }
        public IRegistryInitializer RegistryInitializer { get; }
    }
}