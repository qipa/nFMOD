﻿using System;
using System.Windows.Forms;

namespace nFMOD.Spikes
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetSystemObjectWhenNotInitialized_Click(object sender, EventArgs e)
        {
            var fmod = new FmodSystem();
            fmod.Init();
            var dsp = fmod.CreateDsp(DspType.Oscillator);
            var channel = fmod.PlayDsp(dsp);

            var fmod2 = channel.SystemInstance;

            fmod.CloseSystem();
            
            
        }
    }
}
