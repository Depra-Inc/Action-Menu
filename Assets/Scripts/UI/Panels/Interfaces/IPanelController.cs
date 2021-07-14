using System;

namespace FD.UI.Panels
{
    public interface IPanelController
    {
        Panel[] Panels { get; }
        
        Action<Panel> PanelOpened { get; set; }
        Action<Panel> PanelClosed { get; set; }
    }
}