using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TFlex;
using TFlex.Rest;

namespace DrawbotPlugin.Modeling
{
    public class ModelModifier
    {
        public Response UpdateModelAndDrawings(Request request)
        {
            if(request.Format.Equals("xml")) return new Response(ResponseStatus.NotSupportedFormat);
            try
            {
                /*
                 * Doing some work here
                 */
                return new Response(ResponseStatus.Success);
            }
            catch(ArgumentNullException anex)
            {
                return new Response(ResponseStatus.InvalidArgument);
            }
            catch(JsonException jex)
            {
                return new Response(ResponseStatus.InvalidArgument);
            }
            catch(NotSupportedException nsex)
            {
                return new Response(ResponseStatus.NotSupportedRequest);
            }

        }
    }
}
