using CodeCompanion.Constraints;
using FluentValidation;

namespace CodeCompanion.Extensions.FluentValidation
{
    public static class IRuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> FromOptions<T>(this IRuleBuilder<T, string> builder, StringPropertyOptions options)
        {
            builder.NotNull();

            if (!options.AllowWhiteSpace)
                builder.NotWhiteSpace();

            if (options.MaxLength > 0)
                builder.MaximumLength(options.MaxLength);

            if (!string.IsNullOrEmpty(options.InvalidChars))
                builder.DoesNotContainInvalidChars(options.InvalidChars);

            return builder;
        }

        public static IRuleBuilder<T, string?> FromOptions<T>(this IRuleBuilder<T, string?> builder, NullableStringPropertyOptions options)
        {
            if (!options.AllowWhiteSpace)
                builder.NotWhiteSpace();

            if (options.MaxLength > 0)
                builder.MaximumLength(options.MaxLength);

            if (!string.IsNullOrEmpty(options.InvalidChars))
                builder.DoesNotContainInvalidChars(options.InvalidChars);

            return builder;
        }
    }
}