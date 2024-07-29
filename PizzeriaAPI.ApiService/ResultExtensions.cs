using FluentResults;

namespace PizzeriaAPI.ApiService;

public record ErrorDto(string Message);

public static class ResultExtensions
{
    public static IResult ToHttpResult<T>(this Result<T> result)
    {
        return result.IsFailed ?
            TransformFailedResultToHttpResult(result) :
            TransformOkResultToHttpResult(result);
    }

    private static IResult TransformFailedResultToHttpResult<T>(Result<T> failedResult)
    {
        //TODO manage domain errors to return the correct http error code
        var errorDtos = failedResult.Errors.Select(e => new ErrorDto(e.Message));

        return TypedResults.BadRequest(errorDtos);
    }

    private static IResult TransformOkResultToHttpResult<T>(Result<T> result)
    {
        return TypedResults.Ok(result.ValueOrDefault);
    }
}