using System.Reflection;

namespace CodeCompanion.Extensions
{
    public static class AssemblyExtensions
    {
        public static IEnumerable<Type> GetConcreteImplementationsOf(this Assembly assembly, Type contractType) => assembly.GetTypes().Where(type => type.IsConcreteImplementationOf(contractType)) ?? Enumerable.Empty<Type>();
    }
}