namespace CodeCompanion.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsOpenGeneric(this Type type) => type.IsGenericTypeDefinition || type.ContainsGenericParameters;

        public static bool IsConcreteImplementationOf(this Type type, Type contractType) => 
            !type.IsOpenGeneric()
            && type.GetInterfaces().Any(interfaceType =>
                interfaceType.IsGenericType
                && interfaceType.GetGenericTypeDefinition().Equals(contractType)
            );
    }
}