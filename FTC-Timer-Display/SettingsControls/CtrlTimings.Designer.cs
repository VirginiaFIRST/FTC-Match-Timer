﻿namespace FTC_Timer_Display.SettingsControls
{
    partial class CtrlTimings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlTimings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timingMatch = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingAuto = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingNocross = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingEndgame = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingDriver = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingTeamTimeout = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuarterfinalCount = new System.Windows.Forms.NumericUpDown();
            this.numSemifinalCount = new System.Windows.Forms.NumericUpDown();
            this.timingEventTimeout = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.timingCountdown = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.chkCountdown = new System.Windows.Forms.CheckBox();
            this.ctrlHeader1 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader2 = new FTC_Timer_Display.CtrlHeader();
            this.ctrlHeader3 = new FTC_Timer_Display.CtrlHeader();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnRevert = new DevComponents.DotNetBar.ButtonX();
            this.btnDefaults = new DevComponents.DotNetBar.ButtonX();
            this.timingElimTimeout = new FTC_Timer_Display.SettingsControls.CtrlTimeLengthEntry();
            this.chkUseElimTimeout = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.validator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter2 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.validatorAuto = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.validatorNocross = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.validatorEndgame = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarterfinalCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemifinalCount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.timingMatch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timingAuto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.timingNocross, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.timingEndgame, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.timingDriver, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.timingTeamTimeout, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.numQuarterfinalCount, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numSemifinalCount, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.timingEventTimeout, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.timingCountdown, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkCountdown, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ctrlHeader3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.timingElimTimeout, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkUseElimTimeout, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // timingMatch
            // 
            this.timingMatch.Caption = "Entire Match";
            this.tableLayoutPanel1.SetColumnSpan(this.timingMatch, 2);
            this.timingMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingMatch.Location = new System.Drawing.Point(3, 33);
            this.timingMatch.MaximumValue = System.TimeSpan.Parse("00:09:00");
            this.timingMatch.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingMatch.Name = "timingMatch";
            this.timingMatch.Readonly = false;
            this.timingMatch.Size = new System.Drawing.Size(294, 24);
            this.timingMatch.TabIndex = 0;
            this.timingMatch.Value = System.TimeSpan.Parse("00:00:00");
            this.timingMatch.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingAuto
            // 
            this.timingAuto.Caption = "Autonomous";
            this.tableLayoutPanel1.SetColumnSpan(this.timingAuto, 2);
            this.timingAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingAuto.Location = new System.Drawing.Point(3, 63);
            this.timingAuto.MaximumValue = System.TimeSpan.Parse("00:10:00");
            this.timingAuto.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingAuto.Name = "timingAuto";
            this.timingAuto.Readonly = false;
            this.timingAuto.Size = new System.Drawing.Size(294, 24);
            this.timingAuto.TabIndex = 1;
            this.validator.SetValidator1(this.timingAuto, this.validatorAuto);
            this.timingAuto.Value = System.TimeSpan.Parse("00:00:00");
            this.timingAuto.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingNocross
            // 
            this.timingNocross.Caption = "No Cross";
            this.tableLayoutPanel1.SetColumnSpan(this.timingNocross, 2);
            this.timingNocross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingNocross.Location = new System.Drawing.Point(3, 123);
            this.timingNocross.MaximumValue = System.TimeSpan.Parse("00:10:00");
            this.timingNocross.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingNocross.Name = "timingNocross";
            this.timingNocross.Readonly = false;
            this.timingNocross.Size = new System.Drawing.Size(294, 24);
            this.timingNocross.TabIndex = 2;
            this.validator.SetValidator1(this.timingNocross, this.validatorNocross);
            this.timingNocross.Value = System.TimeSpan.Parse("00:00:00");
            this.timingNocross.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingEndgame
            // 
            this.timingEndgame.Caption = "End Game";
            this.tableLayoutPanel1.SetColumnSpan(this.timingEndgame, 2);
            this.timingEndgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingEndgame.Location = new System.Drawing.Point(3, 153);
            this.timingEndgame.MaximumValue = System.TimeSpan.Parse("00:10:00");
            this.timingEndgame.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingEndgame.Name = "timingEndgame";
            this.timingEndgame.Readonly = false;
            this.timingEndgame.Size = new System.Drawing.Size(294, 24);
            this.timingEndgame.TabIndex = 3;
            this.validator.SetValidator1(this.timingEndgame, this.validatorEndgame);
            this.timingEndgame.Value = System.TimeSpan.Parse("00:00:00");
            this.timingEndgame.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingDriver
            // 
            this.timingDriver.Caption = "Driver Ctrl";
            this.tableLayoutPanel1.SetColumnSpan(this.timingDriver, 2);
            this.timingDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingDriver.Location = new System.Drawing.Point(3, 93);
            this.timingDriver.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timingDriver.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingDriver.Name = "timingDriver";
            this.timingDriver.Readonly = true;
            this.timingDriver.Size = new System.Drawing.Size(294, 24);
            this.timingDriver.TabIndex = 4;
            this.timingDriver.Value = System.TimeSpan.Parse("00:00:00");
            this.timingDriver.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingTeamTimeout
            // 
            this.timingTeamTimeout.Caption = "Team Timeout";
            this.tableLayoutPanel1.SetColumnSpan(this.timingTeamTimeout, 2);
            this.timingTeamTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingTeamTimeout.Location = new System.Drawing.Point(303, 33);
            this.timingTeamTimeout.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timingTeamTimeout.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingTeamTimeout.Name = "timingTeamTimeout";
            this.timingTeamTimeout.Readonly = false;
            this.timingTeamTimeout.Size = new System.Drawing.Size(294, 24);
            this.timingTeamTimeout.TabIndex = 6;
            this.timingTeamTimeout.Value = System.TimeSpan.Parse("00:00:00");
            this.timingTeamTimeout.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quarterfinals";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semifinals";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuarterfinalCount
            // 
            this.numQuarterfinalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuarterfinalCount.Location = new System.Drawing.Point(153, 243);
            this.numQuarterfinalCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numQuarterfinalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuarterfinalCount.Name = "numQuarterfinalCount";
            this.numQuarterfinalCount.Size = new System.Drawing.Size(144, 20);
            this.numQuarterfinalCount.TabIndex = 10;
            this.numQuarterfinalCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuarterfinalCount.ValueChanged += new System.EventHandler(this.numPickerChanged);
            // 
            // numSemifinalCount
            // 
            this.numSemifinalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSemifinalCount.Location = new System.Drawing.Point(153, 273);
            this.numSemifinalCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSemifinalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemifinalCount.Name = "numSemifinalCount";
            this.numSemifinalCount.Size = new System.Drawing.Size(144, 20);
            this.numSemifinalCount.TabIndex = 11;
            this.numSemifinalCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemifinalCount.ValueChanged += new System.EventHandler(this.numPickerChanged);
            // 
            // timingEventTimeout
            // 
            this.timingEventTimeout.Caption = "Event Timeout";
            this.tableLayoutPanel1.SetColumnSpan(this.timingEventTimeout, 2);
            this.timingEventTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingEventTimeout.Location = new System.Drawing.Point(303, 63);
            this.timingEventTimeout.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timingEventTimeout.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingEventTimeout.Name = "timingEventTimeout";
            this.timingEventTimeout.Readonly = false;
            this.timingEventTimeout.Size = new System.Drawing.Size(294, 24);
            this.timingEventTimeout.TabIndex = 12;
            this.timingEventTimeout.Value = System.TimeSpan.Parse("00:00:00");
            this.timingEventTimeout.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // timingCountdown
            // 
            this.timingCountdown.Caption = "       When?";
            this.tableLayoutPanel1.SetColumnSpan(this.timingCountdown, 2);
            this.timingCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingCountdown.Location = new System.Drawing.Point(303, 183);
            this.timingCountdown.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timingCountdown.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingCountdown.Name = "timingCountdown";
            this.timingCountdown.Readonly = false;
            this.timingCountdown.Size = new System.Drawing.Size(294, 24);
            this.timingCountdown.TabIndex = 13;
            this.timingCountdown.Value = System.TimeSpan.Parse("00:00:00");
            this.timingCountdown.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // chkCountdown
            // 
            this.chkCountdown.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkCountdown, 2);
            this.chkCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCountdown.Location = new System.Drawing.Point(303, 153);
            this.chkCountdown.Name = "chkCountdown";
            this.chkCountdown.Size = new System.Drawing.Size(294, 24);
            this.chkCountdown.TabIndex = 16;
            this.chkCountdown.Text = "Enable Time Remaining Countdown";
            this.chkCountdown.UseVisualStyleBackColor = true;
            this.chkCountdown.CheckedChanged += new System.EventHandler(this.chkBoxChanged);
            // 
            // ctrlHeader1
            // 
            // 
            // 
            // 
            this.ctrlHeader1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader1.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.ctrlHeader1, 2);
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader1.Location = new System.Drawing.Point(3, 3);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(294, 24);
            this.ctrlHeader1.TabIndex = 18;
            this.ctrlHeader1.Text = "Match Timing";
            this.ctrlHeader1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlHeader2
            // 
            // 
            // 
            // 
            this.ctrlHeader2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader2.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader2.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.ctrlHeader2, 2);
            this.ctrlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader2.Location = new System.Drawing.Point(303, 3);
            this.ctrlHeader2.Name = "ctrlHeader2";
            this.ctrlHeader2.Size = new System.Drawing.Size(294, 24);
            this.ctrlHeader2.TabIndex = 19;
            this.ctrlHeader2.Text = "Other Timing Options";
            this.ctrlHeader2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlHeader3
            // 
            // 
            // 
            // 
            this.ctrlHeader3.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctrlHeader3.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.ctrlHeader3.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.ctrlHeader3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.ctrlHeader3, 2);
            this.ctrlHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ctrlHeader3.Location = new System.Drawing.Point(3, 213);
            this.ctrlHeader3.Name = "ctrlHeader3";
            this.ctrlHeader3.Size = new System.Drawing.Size(294, 24);
            this.ctrlHeader3.TabIndex = 20;
            this.ctrlHeader3.Text = "Matches in Eliminations";
            this.ctrlHeader3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRevert, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDefaults, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 39);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(147, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 33);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Timing";
            this.btnSave.Click += new System.EventHandler(this.HandleButtons);
            // 
            // btnRevert
            // 
            this.btnRevert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRevert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRevert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRevert.Enabled = false;
            this.btnRevert.Location = new System.Drawing.Point(297, 3);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(144, 33);
            this.btnRevert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRevert.TabIndex = 17;
            this.btnRevert.Text = "Revert Changes";
            this.btnRevert.Click += new System.EventHandler(this.HandleButtons);
            // 
            // btnDefaults
            // 
            this.btnDefaults.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDefaults.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefaults.Location = new System.Drawing.Point(447, 3);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(144, 33);
            this.btnDefaults.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDefaults.TabIndex = 1;
            this.btnDefaults.Text = "Restore Default Timing";
            this.btnDefaults.Click += new System.EventHandler(this.HandleButtons);
            // 
            // timingElimTimeout
            // 
            this.timingElimTimeout.Caption = "Elim. Auto Timeout";
            this.tableLayoutPanel1.SetColumnSpan(this.timingElimTimeout, 2);
            this.timingElimTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingElimTimeout.Location = new System.Drawing.Point(303, 123);
            this.timingElimTimeout.MaximumValue = System.TimeSpan.Parse("00:48:05");
            this.timingElimTimeout.MinimumValue = System.TimeSpan.Parse("00:00:00");
            this.timingElimTimeout.Name = "timingElimTimeout";
            this.timingElimTimeout.Readonly = false;
            this.timingElimTimeout.Size = new System.Drawing.Size(294, 24);
            this.timingElimTimeout.TabIndex = 22;
            this.timingElimTimeout.Value = System.TimeSpan.Parse("00:00:00");
            this.timingElimTimeout.ValueChanged += new System.EventHandler<System.TimeSpan>(this.TimingValueChanged);
            // 
            // chkUseElimTimeout
            // 
            // 
            // 
            // 
            this.chkUseElimTimeout.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLayoutPanel1.SetColumnSpan(this.chkUseElimTimeout, 2);
            this.chkUseElimTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseElimTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseElimTimeout.Location = new System.Drawing.Point(303, 93);
            this.chkUseElimTimeout.Name = "chkUseElimTimeout";
            this.chkUseElimTimeout.Size = new System.Drawing.Size(294, 24);
            this.chkUseElimTimeout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkUseElimTimeout.TabIndex = 23;
            this.chkUseElimTimeout.Text = "Automatically Start Elim Cooldown Timer";
            this.chkUseElimTimeout.CheckedChanged += new System.EventHandler(this.chkBoxChanged);
            // 
            // validator
            // 
            this.validator.ContainerControl = this;
            this.validator.ErrorProvider = this.errorProvider1;
            this.validator.Highlighter = this.highlighter2;
            this.validator.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.validator.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter2
            // 
            this.highlighter2.ContainerControl = this;
            this.highlighter2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // validatorAuto
            // 
            this.validatorAuto.ErrorMessage = "Autonomous Mode must fit within the match";
            this.validatorAuto.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.validatorAuto.ValuePropertyName = "Value";
            this.validatorAuto.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidation);
            // 
            // validatorNocross
            // 
            this.validatorNocross.ErrorMessage = "No Cross time must be within Autonomous Mode.";
            this.validatorNocross.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.validatorNocross.ValuePropertyName = "Value";
            this.validatorNocross.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidation);
            // 
            // validatorEndgame
            // 
            this.validatorEndgame.ErrorMessage = "Endgame must be completely inside Driver Controlled period.";
            this.validatorEndgame.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.validatorEndgame.ValuePropertyName = "Value";
            this.validatorEndgame.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.CustomValidation);
            // 
            // CtrlTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlTimings";
            this.Size = new System.Drawing.Size(600, 370);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarterfinalCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemifinalCount)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Validator.SuperValidator validator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter2;
        private CtrlTimeLengthEntry timingMatch;
        private CtrlTimeLengthEntry timingAuto;
        private CtrlTimeLengthEntry timingNocross;
        private CtrlTimeLengthEntry timingEndgame;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Validator.CustomValidator validatorAuto;
        private DevComponents.DotNetBar.Validator.CustomValidator validatorNocross;
        private DevComponents.DotNetBar.Validator.CustomValidator validatorEndgame;
        private CtrlTimeLengthEntry timingDriver;
        private DevComponents.DotNetBar.ButtonX btnDefaults;
        private CtrlTimeLengthEntry timingTeamTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuarterfinalCount;
        private System.Windows.Forms.NumericUpDown numSemifinalCount;
        private CtrlTimeLengthEntry timingEventTimeout;
        private CtrlTimeLengthEntry timingCountdown;
        private System.Windows.Forms.CheckBox chkCountdown;
        private DevComponents.DotNetBar.ButtonX btnRevert;
        private CtrlHeader ctrlHeader1;
        private CtrlHeader ctrlHeader2;
        private CtrlHeader ctrlHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CtrlTimeLengthEntry timingElimTimeout;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUseElimTimeout;
    }
}