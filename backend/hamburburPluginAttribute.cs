using System;

namespace hamburburPluginTemplate.Backend;

public enum PluginCategory
{
    OP,
}

[AttributeUsage(AttributeTargets.Class)]
public class hamburburPluginAttribute(PluginCategory category) : Attribute
{
    public PluginCategory Category { get; } = category;
}
