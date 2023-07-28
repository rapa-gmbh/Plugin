using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFlex;

namespace DrawbotPlugin
{
    public class DrawbotPluginFactory : PluginFactory
    {
        public override string Name => "Drawbot Plugin";

        public override Guid ID => new Guid("40E6CCF9-F664-46E9-938A-1EDB9D74A104");

        public override Plugin CreateInstance() => (Plugin)new DrawbotPlugin((PluginFactory)this);
    }
}
