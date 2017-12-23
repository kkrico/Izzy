using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Izzy.Core.Mensagem;

namespace Izzy.Api.Filters
{
    public class ValidaNullFilter : ActionFilterAttribute
    {
        public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                if (actionContext.ActionArguments.Any(kv => kv.Value == null))
                {
                    actionContext.Response =
                        actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, MensagemInterna.MsgDev001);
                }

                if (actionContext.ModelState.IsValid == false)
                {
                    actionContext.Response =
                        actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
                }
            }, cancellationToken);
        }
    }
}