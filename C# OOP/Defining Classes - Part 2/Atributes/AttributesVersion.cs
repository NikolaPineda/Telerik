using System;

namespace Attributes
{
    [AttributeUsage(
        AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method |
        AttributeTargets.Enum)]
    internal class AttributeVersion : Attribute
    {
        public AttributeVersion(string version)
        {
            Version = version;
        }

        public string Version { get; }

        public override string ToString()
        {
            return Version;
        }
    }
}