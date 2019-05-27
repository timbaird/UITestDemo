namespace UITestDemoTests
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


    public partial class UIMap
    {

        /// <summary>
        /// SimpleUITest - Use 'SimpleUITestParams' to pass parameters into this method.
        /// </summary>
        public void SimpleUITest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Source\Repos\UITestDemo\UITestDemo\UITestDemo\bin\Debug\UITestDemo.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleUITestParams.UIMainWindowWindowExePath, this.SimpleUITestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(113, 13));


            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleUITestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(31, 4));
        }

        public virtual SimpleUITestParams SimpleUITestParams
        {
            get
            {
                if ((this.mSimpleUITestParams == null))
                {
                    this.mSimpleUITestParams = new SimpleUITestParams();
                }
                return this.mSimpleUITestParams;
            }
        }

        private SimpleUITestParams mSimpleUITestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleUITest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SimpleUITestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Source\Repos\UITestDemo\UITestDemo\UITestDemo\bin\Debug\UITestDemo.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\tbaird\\Source\\Repos\\UITestDemo\\UITestDemo\\UITestDemo\\bin\\Debug\\UITestDem" +
            "o.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\Source\Repos\UITestDemo\UITestDemo\UITestDemo\bin\Debug\UITestDemo.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Source\\Repos\\UITestDemo\\UITestDemo\\UITestDemo\\bin\\Debug\\UITestDemo." +
            "exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
