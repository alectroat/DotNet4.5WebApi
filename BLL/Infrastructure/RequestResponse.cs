
namespace BLL.Infrastructure
{
    public class RequestResponse
    {
        public dynamic Data { get; set; } = null;
        public string Message { get; set; } = "Success";
        public string Extra { get; set; } = null;
        public int Status { get; set; } = 1;
        public int State { get; set; } = 0;
    }
}
