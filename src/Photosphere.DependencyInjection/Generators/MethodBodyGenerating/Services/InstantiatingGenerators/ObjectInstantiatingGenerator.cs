﻿namespace Photosphere.DependencyInjection.Generators.MethodBodyGenerating.Services.InstantiatingGenerators
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