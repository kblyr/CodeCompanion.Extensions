using Microsoft.AspNetCore.Mvc;

namespace CodeCompanion.Extensions.AspNetCore
{
    public static class ProblemDetailsExtensions
    {
        public static ProblemDetails AddExtension(this ProblemDetails details, string name, object value)
        {
            details.Extensions.Add(name, value);
            return details;
        }

        public static ProblemDetails AddExtension(this ProblemDetails details, KeyValuePair<string, object?> pair)
        {
            details.Extensions.Add(pair);
            return details;
        }
    }
}