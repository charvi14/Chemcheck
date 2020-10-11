﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Indoor_Balanced_Verification recording.
    /// </summary>
    [TestModule("7b641a0d-d952-4b2c-923c-11eeac2baeb2", ModuleType.Recording, 1)]
    public partial class Indoor_Balanced_Verification : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest2Repository repository.
        /// </summary>
        public static MyTest2Repository repo = MyTest2Repository.Instance;

        static Indoor_Balanced_Verification instance = new Indoor_Balanced_Verification();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Indoor_Balanced_Verification()
        {
            pHBalanced = "yourValue";
            ChlorineBalanced = "yourValue";
            totalchbalanced = "yourValue";
            TotalAlkabalanced = "yourValue";
            calciumbalanced = "yourValue";
            Cyanuricbalaned = "yourValue";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Indoor_Balanced_Verification Instance
        {
            get { return instance; }
        }

#region Variables

        string _pHBalanced;

        /// <summary>
        /// Gets or sets the value of variable pHBalanced.
        /// </summary>
        [TestVariable("93c9b398-8e9f-4510-9a55-9abe80155c5e")]
        public string pHBalanced
        {
            get { return _pHBalanced; }
            set { _pHBalanced = value; }
        }

        string _ChlorineBalanced;

        /// <summary>
        /// Gets or sets the value of variable ChlorineBalanced.
        /// </summary>
        [TestVariable("a9fb75ee-2302-4a27-bc91-e9288d79ddfc")]
        public string ChlorineBalanced
        {
            get { return _ChlorineBalanced; }
            set { _ChlorineBalanced = value; }
        }

        string _totalchbalanced;

        /// <summary>
        /// Gets or sets the value of variable totalchbalanced.
        /// </summary>
        [TestVariable("377f66ef-875e-4974-8961-2d1c6787ac26")]
        public string totalchbalanced
        {
            get { return _totalchbalanced; }
            set { _totalchbalanced = value; }
        }

        string _TotalAlkabalanced;

        /// <summary>
        /// Gets or sets the value of variable TotalAlkabalanced.
        /// </summary>
        [TestVariable("cd3e26b2-a8ce-4e0b-80f1-825b434771a7")]
        public string TotalAlkabalanced
        {
            get { return _TotalAlkabalanced; }
            set { _TotalAlkabalanced = value; }
        }

        string _calciumbalanced;

        /// <summary>
        /// Gets or sets the value of variable calciumbalanced.
        /// </summary>
        [TestVariable("46d2c9a7-4077-4772-8009-bb9dd3e0c028")]
        public string calciumbalanced
        {
            get { return _calciumbalanced; }
            set { _calciumbalanced = value; }
        }

        string _Cyanuricbalaned;

        /// <summary>
        /// Gets or sets the value of variable Cyanuricbalaned.
        /// </summary>
        [TestVariable("ce5e7181-97ab-4d25-bf94-423aa2832f23")]
        public string Cyanuricbalaned
        {
            get { return _Cyanuricbalaned; }
            set { _Cyanuricbalaned = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '100' with swipe duration'800ms' and step count '0' on item 'ComPentairPentairhome.Sanitizer'.", repo.ComPentairPentairhome.SanitizerInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome.Sanitizer.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "100"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "800ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.WaterQuality' at Center", repo.ComPentairPentairhome.WaterQualityInfo, new RecordItemIndex(1));
            repo.ComPentairPentairhome.WaterQuality.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.TESTSTRIP' at Center", repo.ComPentairPentairhome.TESTSTRIPInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.TESTSTRIP.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$pHBalanced' on item 'Water_Quality.RCTUITextField'.", repo.Water_Quality.RCTUITextFieldInfo, new RecordItemIndex(4));
            repo.Water_Quality.RCTUITextField.Element.SetAttributeValue("Text", pHBalanced);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$ChlorineBalanced' on item 'Water_Quality.Chlorine'.", repo.Water_Quality.ChlorineInfo, new RecordItemIndex(5));
            repo.Water_Quality.Chlorine.Element.SetAttributeValue("Text", ChlorineBalanced);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$totalchbalanced' on item 'Water_Quality.TotalChlorine'.", repo.Water_Quality.TotalChlorineInfo, new RecordItemIndex(6));
            repo.Water_Quality.TotalChlorine.Element.SetAttributeValue("Text", totalchbalanced);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$TotalAlkabalanced' on item 'Water_Quality.TotalAlkalinity'.", repo.Water_Quality.TotalAlkalinityInfo, new RecordItemIndex(7));
            repo.Water_Quality.TotalAlkalinity.Element.SetAttributeValue("Text", TotalAlkabalanced);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$calciumbalanced' on item 'Water_Quality.Calcium'.", repo.Water_Quality.CalciumInfo, new RecordItemIndex(8));
            repo.Water_Quality.Calcium.Element.SetAttributeValue("Text", calciumbalanced);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Water_Quality.TotalAlkalinitylabel' at Center", repo.Water_Quality.TotalAlkalinitylabelInfo, new RecordItemIndex(9));
            repo.Water_Quality.TotalAlkalinitylabel.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Water_Quality.Save' at Center", repo.Water_Quality.SaveInfo, new RecordItemIndex(10));
            repo.Water_Quality.Save.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Water_Quality.CONTINUE' at Center", repo.Water_Quality.CONTINUEInfo, new RecordItemIndex(12));
            repo.Water_Quality.CONTINUE.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(13));
            Delay.Duration(10000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.Water_Quality.Screenshot_balanced, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibilityLabel='Balanced Water') on item 'Water_Quality.BalancedWater'.", repo.Water_Quality.BalancedWaterInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.Water_Quality.BalancedWaterInfo, "AccessibilityLabel", "Balanced Water");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'Water_Quality.Savebalanced' at Center", repo.Water_Quality.SavebalancedInfo, new RecordItemIndex(16));
            repo.Water_Quality.Savebalanced.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
