using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFlex.Rest;

namespace DrawbotPlugin.Converting
{
    public class ExportHub
    {
        public Response ExportPDF(Request request)
        {
            /*
             * Exporting certain pages as pdf
             */
            return new Response(ResponseStatus.Success);
        }

        public Response ExportDXF(Request request)
        {
            /*
             * Exporting certain pages as dxf
             */
            return new Response(ResponseStatus.Success);
        }
    }
}
