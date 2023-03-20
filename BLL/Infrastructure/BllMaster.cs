using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public class BllMaster
    {
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

            }
            return response;
        }
    }
}
