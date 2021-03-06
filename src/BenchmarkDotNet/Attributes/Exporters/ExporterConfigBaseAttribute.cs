﻿using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;

namespace BenchmarkDotNet.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Assembly)]
    public class ExporterConfigBaseAttribute : Attribute, IConfigSource
    {
        // CLS-Compliant Code requires a constructor without an array in the argument list
        protected ExporterConfigBaseAttribute()
        {
            Config = ManualConfig.CreateEmpty();
        }

        protected ExporterConfigBaseAttribute(params IExporter[] exporters)
        {
            Config = ManualConfig.CreateEmpty().With(exporters);
        }

        public IConfig Config { get; }
    }
}