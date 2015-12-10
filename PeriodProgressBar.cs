﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public partial class PeriodProgressBar : UserControl
    {
        public PeriodProgressBar()
        {
            InitializeComponent();
        }

        public void SetMatchProgress(MatchData data)
        {
            int step = (int)data.matchPeriod;
            int stepPercent = MatchTimingData.percentPeriodComplete(data.timerValue, data.matchPeriod);
            foreach (StepItem b in progressSteps.Items)
            {
                int i = int.Parse(b.Tag.ToString());
                if (step == i)
                {
                    // We treat step 1 (Auto) special, because of NoCross.
                    bool noCrossing = data.noCrossActive;
                    int partPercent = MatchTimingData.percentAutoPartComplete(data.timerValue, noCrossing);
                    if (step == 1 && b.Equals(stepNoCross))
                    {
                        if (noCrossing) b.Value = partPercent;
                        else b.Value = 100;
                    }
                    else if (step == 1 && b.Equals(stepAuto))
                    {
                        if (noCrossing) b.Value = 0;
                        else b.Value = partPercent;
                    }
                    else b.Value = stepPercent;
                }
                else if (step >= i || i == 0) b.Value = 100;
                else b.Value = 0;
            }
        }
    }
}
