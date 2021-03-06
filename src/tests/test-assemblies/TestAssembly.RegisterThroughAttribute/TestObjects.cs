﻿using System;

namespace TestAssembly.RegisterThroughAttribute
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public class TestRegisterAttribute : Attribute {}

    public class Bar {}

    public class Foo {}

    public class Foo2ForAttribute : FooForAttribute {}

    [TestRegister]
    public class FooForAttribute {}
}