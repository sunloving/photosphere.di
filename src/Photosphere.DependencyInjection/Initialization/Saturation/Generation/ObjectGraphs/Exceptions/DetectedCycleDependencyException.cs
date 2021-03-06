﻿using System;

namespace Photosphere.DependencyInjection.Initialization.Saturation.Generation.ObjectGraphs.Exceptions
{
    public class DetectedCycleDependencyException : Exception
    {
        private readonly Type _type;

        public DetectedCycleDependencyException(Type type)
        {
            _type = type;
        }

        public override string Message => $"Founded cycle dependency in `{_type}`";
    }
}