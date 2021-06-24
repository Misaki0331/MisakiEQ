using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.SharpDeskBand;

namespace MisakiEQ
{

    public partial class Desk : UserControl
    {
        public Desk()
        {
            InitializeComponent();
        }
    }

    [ComVisible(true)]
    [DisplayName("MisakiEQ")]
    public class MisakiEQDeskBand : SharpDeskBand
    {
        protected override System.Windows.Forms.UserControl CreateDeskBand()
        {
            return new Desk();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
            {
                HasVariableHeight = false,
                IsSunken = false,
                ShowTitle = true,
                Title = "MisakiEQ",
                UseBackgroundColour = false,
                AlwaysShowGripper = true
            };
        }
    }
}
