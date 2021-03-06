﻿using Photosphere.DependencyInjection.Initialization.Saturation.Generation.MethodBodyGenerating.ValueObjects;

namespace Photosphere.DependencyInjection.Initialization.Saturation.Generation.MethodBodyGenerating.SomeServices.InstantiatingGenerators
{
    internal class ObjectInstantiatingGenerator : InstantiatingGeneratorBase, IObjectInstantiatingGenerator
    {
        public void Generate(GeneratingDesign design)
        {
            var parameters = GenerateForSubGraphs(design);
            design.Designer.CreateNewObject(design.ObjectGraph.Constructor, parameters);
        }
    }
}