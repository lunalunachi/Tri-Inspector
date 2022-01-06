﻿using System;

namespace TriInspector
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class RegisterTriValueDrawerAttribute : Attribute
    {
        public RegisterTriValueDrawerAttribute(Type drawerType, int order)
        {
            DrawerType = drawerType;
            Order = order;
        }

        public Type DrawerType { get; }
        public int Order { get; }
        public TriTargetPropertyType Target { get; set; } = TriTargetPropertyType.SelfAndArrayElements;
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class RegisterTriAttributeDrawerAttribute : Attribute
    {
        public RegisterTriAttributeDrawerAttribute(Type drawerType, int order)
        {
            DrawerType = drawerType;
            Order = order;
        }

        public Type DrawerType { get; }
        public int Order { get; }
        public TriTargetPropertyType Target { get; set; } = TriTargetPropertyType.Self;
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class RegisterTriGroupDrawerAttribute : Attribute
    {
        public RegisterTriGroupDrawerAttribute(Type drawerType)
        {
            DrawerType = drawerType;
        }

        public Type DrawerType { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class RegisterTriPropertyHideProcessor : Attribute
    {
        public RegisterTriPropertyHideProcessor(Type processorType)
        {
            ProcessorType = processorType;
        }

        public Type ProcessorType { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class RegisterTriPropertyDisableProcessor : Attribute
    {
        public RegisterTriPropertyDisableProcessor(Type processorType)
        {
            ProcessorType = processorType;
        }

        public Type ProcessorType { get; }
    }
}