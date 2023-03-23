using Entities.Context;
using System;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public class BllMaster
    {
        public BllMaster(MyContext Context)
        {
            this.Context = Context;
        }
        protected MyContext Context;
        protected async Task<RequestResponse> SendResponse(Func<Task<dynamic>> f)
        {
            RequestResponse response = new RequestResponse();

            try
            {
                response.Data = await f();
            }
            catch (Exception)
            {
                response.Status = 0;
            }
            return response;
        }
    }
}
