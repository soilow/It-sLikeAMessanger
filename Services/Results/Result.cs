namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Results;

public class Result
{
    public bool IsSuccess { get; }

    public bool? Value { get; }

    public Result(bool value) : this(true, value) { }

    public Result() : this(false, null) { }

    private Result(bool isSuccess, bool? value)
    {
        IsSuccess = isSuccess;
        Value = isSuccess ? value : null;
    }
}