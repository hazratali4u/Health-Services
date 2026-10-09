/// <summary>
/// Summary description for ResponseData
/// </summary>
public class ResponseData
{
    public string Message { get; set; }
    public object Data { get; set; }
    public string Status { get; set; }

    public ResponseData()
    {
    }
    public ResponseData(string status, string message, string data)
    {
        this.Status = status;
        this.Message = message;
        this.Data = data;
    }
}