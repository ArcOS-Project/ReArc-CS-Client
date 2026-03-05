namespace ReArc.Shared
{
    public class CommandResult<T>
    {
        public T? Result;
        public string? ErrorMessage;
        public string? SuccessMessage;
        public bool Success = false;

        public CommandResult(T? result)
        {
            var options = CommandResultOptions.GetDefault();

            Result = result;
            SuccessMessage = options.successMessage;
            ErrorMessage = options.errorMessage;
            Success = options.success ?? false;
        }

        public CommandResult(T? result, CommandResultOptions options)
        {
            Result = result;
            SuccessMessage = options.successMessage;
            ErrorMessage = options.errorMessage;
            Success = options.success ?? false;
        }

        public CommandResult(CommandResultOptions options)
        {
            SuccessMessage = options.successMessage;
            ErrorMessage = options.errorMessage;
            Success = options.success ?? false;
        }

        public static CommandResult<T> Ok(T value)
        {
            return new CommandResult<T>(value, new CommandResultOptions
            {
                success = true
            });
        }

        public static CommandResult<T> Ok(T value, string? successMessage)
        {
            return new CommandResult<T>(value, new CommandResultOptions
            {
                successMessage = successMessage,
                success = true
            });
        }

        public static CommandResult<T> Error()
        {
            return new CommandResult<T>(new CommandResultOptions
            {
                errorMessage = "unknown error"
            });
        }

        public static CommandResult<T> Error(string? errorMessage)
        {
            return new CommandResult<T>(new CommandResultOptions
            {
                errorMessage = errorMessage ?? "Unknown error"
            });
        }
    }

    public record CommandResultOptions
    {
        public string? errorMessage { get; init; }
        public string? successMessage { get; init; }
        public bool? success { get; init; }

        public static CommandResultOptions GetDefault()
        {
            return new()
            {
                errorMessage = null,
                successMessage = null,
                success = null
            };
        }
    };
}