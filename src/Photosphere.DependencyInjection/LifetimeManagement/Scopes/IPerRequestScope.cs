using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Photosphere.DependencyInjection.LifetimeManagement.Scopes
{
    internal interface IPerRequestScope : IScope
    {
        void Add(Type type, LocalBuilder instanceVariable);

        IReadOnlyDictionary<Type, LocalBuilder> AvailableInstancesVariables { get; }
    }
}