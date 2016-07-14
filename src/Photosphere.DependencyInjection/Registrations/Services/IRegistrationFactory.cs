﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Photosphere.DependencyInjection.Lifetimes;
using Photosphere.DependencyInjection.Registrations.ValueObjects;

namespace Photosphere.DependencyInjection.Registrations.Services
{
    internal interface IRegistrationFactory
    {
        IEnumerable<IRegistration> Get(Type serviceType, Assembly assembly, Lifetime lifetime);

        IEnumerable<IRegistration> GetByAttribute(Type attributeType, Assembly assembly, Lifetime lifetime);
    }
}