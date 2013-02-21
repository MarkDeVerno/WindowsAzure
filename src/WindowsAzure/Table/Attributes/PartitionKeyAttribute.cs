﻿using System;

namespace WindowsAzure.Table.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class PartitionKeyAttribute : Attribute
    {
    }
}