using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFlex.Rest;
using TFlex;
using DrawbotPlugin.Converting;
using DrawbotPlugin.Modeling;

namespace DrawbotPlugin
{
    public class DrawbotPlugin : Plugin
    {
        private ModelModifier modelModifier;
        private ExportHub exportHub;

        public DrawbotPlugin(PluginFactory Factory) : base(Factory)
        {
            this.modelModifier = new ModelModifier();
            this.exportHub = new ExportHub();
        }

        protected override Response OnCallRestCallback(Request request)
        {
            switch(request.Id)
            {
                case "UpdateModelAndDrawings":
                    return modelModifier.UpdateModelAndDrawings(request);
                case "ExportPDF":
                    return exportHub.ExportPDF(request);
                case "ExportDXF":
                    return exportHub.ExportDXF(request);
                default:
                    return base.OnCallRestCallback(request);
            }
        }
    }
}
