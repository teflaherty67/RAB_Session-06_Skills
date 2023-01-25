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

            RibbonPanel panel1 = a.CreateRibbonPanel("Revit Add-in Bootcamp", "Panel 1");
            RibbonPanel panel2 = a.CreateRibbonPanel("Revit Add-in Bootcamp", "Panel 2");
            RibbonPanel panel3 = a.CreateRibbonPanel("Panel 3");

            // step 3: create button data instances

            PushButtonData pData1 = new PushButtonData("button1", "Button 1", assemblyName, "RAB_Session_06_Skills.cmdCommand1");
            PushButtonData pData2 = new PushButtonData("button2", "Button 2", assemblyName, "RAB_Session_06_Skills.cmdCommand2");
            PushButtonData pData3 = new PushButtonData("button3", "Button 3", assemblyName, "RAB_Session_06_Skills.cmdCommand1");
            PushButtonData pData4 = new PushButtonData("button4", "Button 4", assemblyName, "RAB_Session_06_Skills.cmdCommand2");
            PushButtonData pData5 = new PushButtonData("button5", "Button 5", assemblyName, "RAB_Session_06_Skills.cmdCommand1");
            PushButtonData pData6 = new PushButtonData("button6", "This is \rButton 6", assemblyName, "RAB_Session_06_Skills.cmdCommand2");

            PulldownButtonData pullDownData1 = new PulldownButtonData("pulldown1", "Pulldown Button");

            SplitButtonData splitData1 = new SplitButtonData("split1", "Split Button");

            // step 4: add images

            pData1.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Blue_32);
            pData1.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Blue_16);
            pData2.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Red_32);
            pData2.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Red_16);
            pData3.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Yellow_32);
            pData3.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Yellow_16);
            pData4.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Green_32);
            pData4.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Green_16);
            pData5.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Blue_32);
            pData5.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Blue_16);
            pData6.LargeImage = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Red_32);
            pData6.Image = Utils.BitmapToImageSource(RAB_Session_06_Skills.Properties.Resources.Red_16);

            // step 5: add tool tips

            pData1.ToolTip = "Button 1 tool tip";
            pData2.ToolTip = "Button 2 tool tip";

            // step 6: create buttons

            panel1.AddItem(pData1);
            panel1.AddItem(pData2);

            SplitButton split1 = panel1.AddItem(splitData1) as SplitButton;
            split1.AddPushButton(pData3);
            split1.AddPushButton(pData4);

            PulldownButton pull1 = panel2.AddItem(pullDownData1) as PulldownButton;
            pull1.AddPushButton(pData5);
            pull1.AddPushButton(pData6);

            panel3.AddStackedItems(pData1, pData2, pData3);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
