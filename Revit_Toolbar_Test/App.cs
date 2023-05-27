#region Namespaces
using Autodesk.Revit.UI;
using System;
using System.Diagnostics;

#endregion

namespace Revit_Toolbar_Test
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // 1. Create ribbon tab
            try
            {
                app.CreateRibbonTab("Revit Add-in Bootcamp");
            }
            catch (Exception)
            {
                Debug.Print("Tab already exists.");
            }

            // 2. Create ribbon panel 
            RibbonPanel panel = Utils.CreateRibbonPanel(app, "Revit Add-in Bootcamp", "Revit Tools");

            // 3. Create button data instances
            ButtonDataClass myButtonData1 = new ButtonDataClass("btn1", "Tool 1", Command1.GetMethod(), Properties.Resources.Blue_32, Properties.Resources.Blue_16, "Tooltip 1");
            ButtonDataClass myButtonData2 = new ButtonDataClass("btn2", "Tool 2", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData3 = new ButtonDataClass("btn3", "Tool 3", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData4 = new ButtonDataClass("btn4", "Tool 4", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData5 = new ButtonDataClass("btn5", "Tool 5", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData6 = new ButtonDataClass("btn6", "Tool 6", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData7 = new ButtonDataClass("btn7", "Tool 7", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData8 = new ButtonDataClass("btn8", "Tool 8", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData9 = new ButtonDataClass("btn9", "Tool 9", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");
            ButtonDataClass myButtonData10 = new ButtonDataClass("btn10", "Tool 10", Command2.GetMethod(), Properties.Resources.Red_32, Properties.Resources.Red_16, "Tooltip 2");

            // 4. Create buttons
            PushButton myButton1 = panel.AddItem(myButtonData1.Data) as PushButton;
            PushButton myButton2 = panel.AddItem(myButtonData2.Data) as PushButton;
            //5. Split buttons
            SplitButtonData splitButtonData = new SplitButtonData("split1", "Split\rButton");
            SplitButton splitButton = panel.AddItem(splitButtonData) as SplitButton;
            splitButton.AddPushButton(myButtonData6.Data);
            splitButton.AddPushButton(myButtonData7.Data);
            //6. Pulldown Buttons
            PulldownButtonData pullDownData = new PulldownButtonData("pulldown1", "More Tools");
            pullDownData.LargeImage = ButtonDataClass.BitmapToImageSource(Properties.Resources.Red_32);
            pullDownData.Image = ButtonDataClass.BitmapToImageSource(Properties.Resources.Red_16);
            PulldownButton pullDownButton = panel.AddItem(pullDownData) as PulldownButton;
            pullDownButton.AddPushButton(myButtonData8.Data);
            pullDownButton.AddPushButton(myButtonData9.Data);
            pullDownButton.AddPushButton(myButtonData10.Data);
            //7. Stacked Row
            panel.AddStackedItems(myButtonData3.Data, myButtonData4.Data, myButtonData5.Data);

            // NOTE:
            // To create a new tool, copy lines 35 and 39 and rename the variables to "myButtonData3" and "myButton3". 
            // Change the name of the tool in the arguments of line 

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }


    }
}
