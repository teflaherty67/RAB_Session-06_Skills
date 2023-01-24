#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RAB_Session_06_Skills
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            string assemblyName = Utils.GetAssemblyName();
            
            // step 1: create ribbon tab (if needed)

            a.CreateRibbonTab("Revit Add-in Bootcamp");

            // step 2: create ribbon panel(s)

            a.CreateRibbonPanel("Revit Add-in Bootcamp", "Panel 1");
            a.CreateRibbonPanel("Revit Add-in Bootcamp", "Panel 2");
            a.CreateRibbonPanel("Panel 3");

            // step 3: create button data instances

            PushButtonData pData1 = new PushButtonData("button1", "Button 1", 
                assemblyName, "RAB_Session_06_Skills.cmdCommand1");
            PushButtonData pData2 = new PushButtonData("button2", "Button 2",
                assemblyName, "RAB_Session_06_Skills.cmdCommand2");

            // step 4: add images

            // step 5: add tool tips

            // step 6: create buttons         

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
