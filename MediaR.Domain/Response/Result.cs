namespace MediaR.Domain.Response;

public class Result
{
    public bool Success { get; }
    public string Error { get; private set; }

    protected Result(bool success, string error)
    {
        if (success && error != string.Empty) throw new InvalidOperationException();
        if (!success && error == string.Empty) throw new InvalidOperationException();
        Success = success; Error = error;
    }

    public static Result Fail(string message)
    {
        return new Result(false, message);
    }

    public static Result<T> Fail<T>(string message)
    {
        return new Result<T>(false, message, default(T));
    }

    public static Result Ok()
    {
        return new Result(true, string.Empty);
    }

    //public static Result Ok(string message)
    //{
    //    return new Result(true, message);
    //}

    public static Result<T> Ok<T>(T value)
    {
        return new Result<T>(true, string.Empty, value);
    }
}

public class Result<T> : Result
{
    public T Value { get; set; }

    protected internal Result(bool success, string error, T value) : base(success, error)
    {
        Value = value;
    }
}