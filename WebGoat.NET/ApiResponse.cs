using Newtonsoft.Json;

public class ApiResponse
{
    public int StatusCode { get; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; }

    public ApiResponse(int statusCode)
    {
        // do thing
        StatusCode = statusCode;
        Message = GetDefaultMessageForStatusCode(statusCode);
    }

    private static string GetDefaultMessageForStatusCode(int statusCode)
    {
        return Microsoft.AspNetCore.WebUtilities.ReasonPhrases.GetReasonPhrase(statusCode);
    }
}
