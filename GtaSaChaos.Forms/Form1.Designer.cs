namespace GtaChaos.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMainToggle = new System.Windows.Forms.Button();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.checkBoxShowLastEffectsMain = new System.Windows.Forms.CheckBox();
            this.buttonResetMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMainCooldown = new System.Windows.Forms.ComboBox();
            this.listLastEffectsMain = new System.Windows.Forms.ListBox();
            this.tabTwitch = new System.Windows.Forms.TabPage();
            this.checkBoxTwitchEnableMultipleEffects = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitch3TimesCooldown = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTwitchChannel = new System.Windows.Forms.TextBox();
            this.buttonResetTwitch = new System.Windows.Forms.Button();
            this.checkBoxTwitchAllowOnlyEnabledEffects = new System.Windows.Forms.CheckBox();
            this.checkBoxShowLastEffectsTwitch = new System.Windows.Forms.CheckBox();
            this.labelTwitchCurrentMode = new System.Windows.Forms.Label();
            this.buttonTwitchToggle = new System.Windows.Forms.Button();
            this.comboBoxVotingCooldown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVotingTime = new System.Windows.Forms.ComboBox();
            this.progressBarTwitch = new System.Windows.Forms.ProgressBar();
            this.listLastEffectsTwitch = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTwitchOAuth = new System.Windows.Forms.TextBox();
            this.textBoxTwitchUsername = new System.Windows.Forms.TextBox();
            this.buttonConnectTwitch = new System.Windows.Forms.Button();
            this.tabPolls = new System.Windows.Forms.TabPage();
            this.checkBoxTwitchPollsPostMessages = new System.Windows.Forms.CheckBox();
            this.labelTwitchPollsPassphrase = new System.Windows.Forms.Label();
            this.textBoxTwitchPollsPassphrase = new System.Windows.Forms.TextBox();
            this.labelTwitchPollsBitsCost = new System.Windows.Forms.Label();
            this.checkBoxTwitchPollsSubcriberMultiplier = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchPollsSubscriberOnly = new System.Windows.Forms.CheckBox();
            this.numericUpDownTwitchPollsBitsCost = new System.Windows.Forms.NumericUpDown();
            this.tabEffects = new System.Windows.Forms.TabPage();
            this.buttonEffectsToggleAll = new System.Windows.Forms.Button();
            this.enabledEffectsView = new System.Windows.Forms.TreeView();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.checkBoxPlayAudioForEffects = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchAppendFakePassCurrentMission = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchUsePolls = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchCombineVotingMessages = new System.Windows.Forms.CheckBox();
            this.checkBoxContinueTimer = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.tabMultiplayer = new System.Windows.Forms.TabPage();
            this.buttonMultiplayerSend = new System.Windows.Forms.Button();
            this.textBoxMultiplayerChat = new System.Windows.Forms.TextBox();
            this.listBoxMultiplayerChat = new System.Windows.Forms.ListBox();
            this.labelMultiplayerHost = new System.Windows.Forms.Label();
            this.textBoxMultiplayerUsername = new System.Windows.Forms.TextBox();
            this.labelMultiplayerUsername = new System.Windows.Forms.Label();
            this.labelMultiplayerChannel = new System.Windows.Forms.Label();
            this.textBoxMultiplayerChannel = new System.Windows.Forms.TextBox();
            this.labelMultiplayerServer = new System.Windows.Forms.Label();
            this.textBoxMultiplayerServer = new System.Windows.Forms.TextBox();
            this.buttonMultiplayerConnect = new System.Windows.Forms.Button();
            this.tabExperimental = new System.Windows.Forms.TabPage();
            this.checkBoxExperimental_TwitchDisableRapidFire = new System.Windows.Forms.CheckBox();
            this.buttonExperimentalRunEffect = new System.Windows.Forms.Button();
            this.textBoxExperimentalEffectName = new System.Windows.Forms.TextBox();
            this.checkBoxExperimental_TwitchAnarchyMode = new System.Windows.Forms.CheckBox();
            this.checkBoxExperimental_RunEffectOnAutoStart = new System.Windows.Forms.CheckBox();
            this.checkBoxExperimental_EnableAllEffects = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viceCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanAndreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipHandler = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAutoStart = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonSwitchMode = new System.Windows.Forms.Button();
            this.checkBoxRunEffectsWhenZeroVotes = new System.Windows.Forms.CheckBox();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTwitch.SuspendLayout();
            this.tabPolls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwitchPollsBitsCost)).BeginInit();
            this.tabEffects.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabMultiplayer.SuspendLayout();
            this.tabExperimental.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainToggle
            // 
            this.buttonMainToggle.Location = new System.Drawing.Point(6, 6);
            this.buttonMainToggle.Name = "buttonMainToggle";
            this.buttonMainToggle.Size = new System.Drawing.Size(94, 23);
            this.buttonMainToggle.TabIndex = 0;
            this.buttonMainToggle.Text = "Start / Resume";
            this.buttonMainToggle.UseVisualStyleBackColor = true;
            this.buttonMainToggle.Click += new System.EventHandler(this.ButtonMainToggle_Click);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(206, 6);
            this.progressBarMain.Maximum = 60;
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(240, 23);
            this.progressBarMain.Step = 1;
            this.progressBarMain.TabIndex = 1;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMain);
            this.tabs.Controls.Add(this.tabTwitch);
            this.tabs.Controls.Add(this.tabPolls);
            this.tabs.Controls.Add(this.tabEffects);
            this.tabs.Controls.Add(this.tabSettings);
            this.tabs.Controls.Add(this.tabMultiplayer);
            this.tabs.Controls.Add(this.tabExperimental);
            this.tabs.Location = new System.Drawing.Point(12, 56);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(460, 257);
            this.tabs.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Transparent;
            this.tabMain.Controls.Add(this.checkBoxShowLastEffectsMain);
            this.tabMain.Controls.Add(this.buttonResetMain);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.comboBoxMainCooldown);
            this.tabMain.Controls.Add(this.buttonMainToggle);
            this.tabMain.Controls.Add(this.listLastEffectsMain);
            this.tabMain.Controls.Add(this.progressBarMain);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(452, 231);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // checkBoxShowLastEffectsMain
            // 
            this.checkBoxShowLastEffectsMain.AutoSize = true;
            this.checkBoxShowLastEffectsMain.Checked = true;
            this.checkBoxShowLastEffectsMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLastEffectsMain.Location = new System.Drawing.Point(6, 107);
            this.checkBoxShowLastEffectsMain.Name = "checkBoxShowLastEffectsMain";
            this.checkBoxShowLastEffectsMain.Size = new System.Drawing.Size(112, 17);
            this.checkBoxShowLastEffectsMain.TabIndex = 8;
            this.checkBoxShowLastEffectsMain.Text = "Show Last Effects";
            this.checkBoxShowLastEffectsMain.UseVisualStyleBackColor = true;
            this.checkBoxShowLastEffectsMain.CheckedChanged += new System.EventHandler(this.CheckBoxShowLastEffectsMain_CheckedChanged);
            // 
            // buttonResetMain
            // 
            this.buttonResetMain.Location = new System.Drawing.Point(106, 6);
            this.buttonResetMain.Name = "buttonResetMain";
            this.buttonResetMain.Size = new System.Drawing.Size(94, 23);
            this.buttonResetMain.TabIndex = 7;
            this.buttonResetMain.Text = "Reset";
            this.buttonResetMain.UseVisualStyleBackColor = true;
            this.buttonResetMain.Click += new System.EventHandler(this.ButtonResetMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cooldown:";
            // 
            // comboBoxMainCooldown
            // 
            this.comboBoxMainCooldown.FormattingEnabled = true;
            this.comboBoxMainCooldown.Location = new System.Drawing.Point(325, 35);
            this.comboBoxMainCooldown.Name = "comboBoxMainCooldown";
            this.comboBoxMainCooldown.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMainCooldown.TabIndex = 5;
            this.comboBoxMainCooldown.SelectedIndexChanged += new System.EventHandler(this.MainCooldownComboBox_SelectedIndexChanged);
            // 
            // listLastEffectsMain
            // 
            this.listLastEffectsMain.FormattingEnabled = true;
            this.listLastEffectsMain.Location = new System.Drawing.Point(6, 130);
            this.listLastEffectsMain.Name = "listLastEffectsMain";
            this.listLastEffectsMain.Size = new System.Drawing.Size(440, 95);
            this.listLastEffectsMain.TabIndex = 4;
            // 
            // tabTwitch
            // 
            this.tabTwitch.BackColor = System.Drawing.Color.Transparent;
            this.tabTwitch.Controls.Add(this.checkBoxTwitchEnableMultipleEffects);
            this.tabTwitch.Controls.Add(this.checkBoxTwitch3TimesCooldown);
            this.tabTwitch.Controls.Add(this.label3);
            this.tabTwitch.Controls.Add(this.textBoxTwitchChannel);
            this.tabTwitch.Controls.Add(this.buttonResetTwitch);
            this.tabTwitch.Controls.Add(this.checkBoxTwitchAllowOnlyEnabledEffects);
            this.tabTwitch.Controls.Add(this.checkBoxShowLastEffectsTwitch);
            this.tabTwitch.Controls.Add(this.labelTwitchCurrentMode);
            this.tabTwitch.Controls.Add(this.buttonTwitchToggle);
            this.tabTwitch.Controls.Add(this.comboBoxVotingCooldown);
            this.tabTwitch.Controls.Add(this.label7);
            this.tabTwitch.Controls.Add(this.label6);
            this.tabTwitch.Controls.Add(this.comboBoxVotingTime);
            this.tabTwitch.Controls.Add(this.progressBarTwitch);
            this.tabTwitch.Controls.Add(this.listLastEffectsTwitch);
            this.tabTwitch.Controls.Add(this.label5);
            this.tabTwitch.Controls.Add(this.label4);
            this.tabTwitch.Controls.Add(this.textBoxTwitchOAuth);
            this.tabTwitch.Controls.Add(this.textBoxTwitchUsername);
            this.tabTwitch.Controls.Add(this.buttonConnectTwitch);
            this.tabTwitch.Location = new System.Drawing.Point(4, 22);
            this.tabTwitch.Name = "tabTwitch";
            this.tabTwitch.Size = new System.Drawing.Size(452, 231);
            this.tabTwitch.TabIndex = 2;
            this.tabTwitch.Text = "Twitch";
            // 
            // checkBoxTwitchEnableMultipleEffects
            // 
            this.checkBoxTwitchEnableMultipleEffects.AutoSize = true;
            this.checkBoxTwitchEnableMultipleEffects.Location = new System.Drawing.Point(323, 87);
            this.checkBoxTwitchEnableMultipleEffects.Name = "checkBoxTwitchEnableMultipleEffects";
            this.checkBoxTwitchEnableMultipleEffects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchEnableMultipleEffects.Size = new System.Drawing.Size(126, 17);
            this.checkBoxTwitchEnableMultipleEffects.TabIndex = 25;
            this.checkBoxTwitchEnableMultipleEffects.Text = "Allow Multiple Effects";
            this.checkBoxTwitchEnableMultipleEffects.UseVisualStyleBackColor = true;
            this.checkBoxTwitchEnableMultipleEffects.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchEnableMultipleEffects_CheckedChanged);
            // 
            // checkBoxTwitch3TimesCooldown
            // 
            this.checkBoxTwitch3TimesCooldown.AutoSize = true;
            this.checkBoxTwitch3TimesCooldown.Location = new System.Drawing.Point(362, 104);
            this.checkBoxTwitch3TimesCooldown.Name = "checkBoxTwitch3TimesCooldown";
            this.checkBoxTwitch3TimesCooldown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitch3TimesCooldown.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTwitch3TimesCooldown.TabIndex = 24;
            this.checkBoxTwitch3TimesCooldown.Text = "3x Cooldown";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitch3TimesCooldown, "When enabled effects will have 3x their cooldown.\r\n(Cooldown in this case is the " +
        "Voting Time + Voting Cooldown)");
            this.checkBoxTwitch3TimesCooldown.UseVisualStyleBackColor = true;
            this.checkBoxTwitch3TimesCooldown.CheckedChanged += new System.EventHandler(this.CheckBoxTwitch3TimesCooldown_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Channel:";
            // 
            // textBoxTwitchChannel
            // 
            this.textBoxTwitchChannel.Location = new System.Drawing.Point(83, 3);
            this.textBoxTwitchChannel.Name = "textBoxTwitchChannel";
            this.textBoxTwitchChannel.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchChannel.TabIndex = 1;
            this.textBoxTwitchChannel.TextChanged += new System.EventHandler(this.TextBoxTwitchChannel_TextChanged);
            // 
            // buttonResetTwitch
            // 
            this.buttonResetTwitch.Enabled = false;
            this.buttonResetTwitch.Location = new System.Drawing.Point(294, 58);
            this.buttonResetTwitch.Name = "buttonResetTwitch";
            this.buttonResetTwitch.Size = new System.Drawing.Size(155, 23);
            this.buttonResetTwitch.TabIndex = 21;
            this.buttonResetTwitch.Text = "Reset";
            this.buttonResetTwitch.UseVisualStyleBackColor = true;
            this.buttonResetTwitch.Click += new System.EventHandler(this.ButtonResetTwitch_Click);
            // 
            // checkBoxTwitchAllowOnlyEnabledEffects
            // 
            this.checkBoxTwitchAllowOnlyEnabledEffects.AutoSize = true;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Location = new System.Drawing.Point(137, 81);
            this.checkBoxTwitchAllowOnlyEnabledEffects.Name = "checkBoxTwitchAllowOnlyEnabledEffects";
            this.checkBoxTwitchAllowOnlyEnabledEffects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Size = new System.Drawing.Size(148, 17);
            this.checkBoxTwitchAllowOnlyEnabledEffects.TabIndex = 19;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Text = "Only Enabled Effects (RF)";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchAllowOnlyEnabledEffects, "Only allow effects that are enabled\r\nin the currently active preset during Rapid-" +
        "Fire.");
            this.checkBoxTwitchAllowOnlyEnabledEffects.UseVisualStyleBackColor = true;
            this.checkBoxTwitchAllowOnlyEnabledEffects.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchAllowOnlyEnabledEffects_CheckedChanged);
            // 
            // checkBoxShowLastEffectsTwitch
            // 
            this.checkBoxShowLastEffectsTwitch.AutoSize = true;
            this.checkBoxShowLastEffectsTwitch.Checked = true;
            this.checkBoxShowLastEffectsTwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLastEffectsTwitch.Location = new System.Drawing.Point(3, 81);
            this.checkBoxShowLastEffectsTwitch.Name = "checkBoxShowLastEffectsTwitch";
            this.checkBoxShowLastEffectsTwitch.Size = new System.Drawing.Size(112, 17);
            this.checkBoxShowLastEffectsTwitch.TabIndex = 18;
            this.checkBoxShowLastEffectsTwitch.Text = "Show Last Effects";
            this.checkBoxShowLastEffectsTwitch.UseVisualStyleBackColor = true;
            this.checkBoxShowLastEffectsTwitch.CheckedChanged += new System.EventHandler(this.CheckBoxShowLastEffectsTwitch_CheckedChanged);
            // 
            // labelTwitchCurrentMode
            // 
            this.labelTwitchCurrentMode.AutoSize = true;
            this.labelTwitchCurrentMode.Location = new System.Drawing.Point(5, 208);
            this.labelTwitchCurrentMode.Name = "labelTwitchCurrentMode";
            this.labelTwitchCurrentMode.Size = new System.Drawing.Size(124, 13);
            this.labelTwitchCurrentMode.TabIndex = 17;
            this.labelTwitchCurrentMode.Text = "Current Mode: Cooldown";
            // 
            // buttonTwitchToggle
            // 
            this.buttonTwitchToggle.Enabled = false;
            this.buttonTwitchToggle.Location = new System.Drawing.Point(294, 29);
            this.buttonTwitchToggle.Name = "buttonTwitchToggle";
            this.buttonTwitchToggle.Size = new System.Drawing.Size(155, 23);
            this.buttonTwitchToggle.TabIndex = 15;
            this.buttonTwitchToggle.Text = "Start / Resume";
            this.buttonTwitchToggle.UseVisualStyleBackColor = true;
            this.buttonTwitchToggle.Click += new System.EventHandler(this.ButtonTwitchToggle_Click);
            // 
            // comboBoxVotingCooldown
            // 
            this.comboBoxVotingCooldown.FormattingEnabled = true;
            this.comboBoxVotingCooldown.Location = new System.Drawing.Point(294, 178);
            this.comboBoxVotingCooldown.Name = "comboBoxVotingCooldown";
            this.comboBoxVotingCooldown.Size = new System.Drawing.Size(155, 21);
            this.comboBoxVotingCooldown.TabIndex = 14;
            this.comboBoxVotingCooldown.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVotingCooldown_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Voting Cooldown:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Voting Time:";
            // 
            // comboBoxVotingTime
            // 
            this.comboBoxVotingTime.FormattingEnabled = true;
            this.comboBoxVotingTime.Location = new System.Drawing.Point(294, 138);
            this.comboBoxVotingTime.Name = "comboBoxVotingTime";
            this.comboBoxVotingTime.Size = new System.Drawing.Size(155, 21);
            this.comboBoxVotingTime.TabIndex = 11;
            this.comboBoxVotingTime.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVotingTime_SelectedIndexChanged);
            // 
            // progressBarTwitch
            // 
            this.progressBarTwitch.Location = new System.Drawing.Point(3, 205);
            this.progressBarTwitch.Name = "progressBarTwitch";
            this.progressBarTwitch.Size = new System.Drawing.Size(446, 23);
            this.progressBarTwitch.TabIndex = 10;
            // 
            // listLastEffectsTwitch
            // 
            this.listLastEffectsTwitch.FormattingEnabled = true;
            this.listLastEffectsTwitch.Location = new System.Drawing.Point(3, 104);
            this.listLastEffectsTwitch.Name = "listLastEffectsTwitch";
            this.listLastEffectsTwitch.Size = new System.Drawing.Size(282, 95);
            this.listLastEffectsTwitch.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "OAuth Token:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // textBoxTwitchOAuth
            // 
            this.textBoxTwitchOAuth.Location = new System.Drawing.Point(83, 58);
            this.textBoxTwitchOAuth.Name = "textBoxTwitchOAuth";
            this.textBoxTwitchOAuth.PasswordChar = '*';
            this.textBoxTwitchOAuth.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchOAuth.TabIndex = 3;
            this.textBoxTwitchOAuth.TextChanged += new System.EventHandler(this.TextBoxOAuth_TextChanged);
            // 
            // textBoxTwitchUsername
            // 
            this.textBoxTwitchUsername.Location = new System.Drawing.Point(83, 29);
            this.textBoxTwitchUsername.Name = "textBoxTwitchUsername";
            this.textBoxTwitchUsername.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchUsername.TabIndex = 2;
            this.textBoxTwitchUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // buttonConnectTwitch
            // 
            this.buttonConnectTwitch.Enabled = false;
            this.buttonConnectTwitch.Location = new System.Drawing.Point(294, 2);
            this.buttonConnectTwitch.Name = "buttonConnectTwitch";
            this.buttonConnectTwitch.Size = new System.Drawing.Size(155, 23);
            this.buttonConnectTwitch.TabIndex = 1;
            this.buttonConnectTwitch.Text = "Connect to Twitch";
            this.buttonConnectTwitch.UseVisualStyleBackColor = true;
            this.buttonConnectTwitch.Click += new System.EventHandler(this.ButtonConnectTwitch_Click);
            // 
            // tabPolls
            // 
            this.tabPolls.BackColor = System.Drawing.Color.Transparent;
            this.tabPolls.Controls.Add(this.checkBoxTwitchPollsPostMessages);
            this.tabPolls.Controls.Add(this.labelTwitchPollsPassphrase);
            this.tabPolls.Controls.Add(this.textBoxTwitchPollsPassphrase);
            this.tabPolls.Controls.Add(this.labelTwitchPollsBitsCost);
            this.tabPolls.Controls.Add(this.checkBoxTwitchPollsSubcriberMultiplier);
            this.tabPolls.Controls.Add(this.checkBoxTwitchPollsSubscriberOnly);
            this.tabPolls.Controls.Add(this.numericUpDownTwitchPollsBitsCost);
            this.tabPolls.Location = new System.Drawing.Point(4, 22);
            this.tabPolls.Name = "tabPolls";
            this.tabPolls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPolls.Size = new System.Drawing.Size(452, 231);
            this.tabPolls.TabIndex = 5;
            this.tabPolls.Text = "Polls";
            // 
            // checkBoxTwitchPollsPostMessages
            // 
            this.checkBoxTwitchPollsPostMessages.AutoSize = true;
            this.checkBoxTwitchPollsPostMessages.Location = new System.Drawing.Point(298, 206);
            this.checkBoxTwitchPollsPostMessages.Name = "checkBoxTwitchPollsPostMessages";
            this.checkBoxTwitchPollsPostMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchPollsPostMessages.Size = new System.Drawing.Size(148, 17);
            this.checkBoxTwitchPollsPostMessages.TabIndex = 6;
            this.checkBoxTwitchPollsPostMessages.Text = "Post Vote Options In Chat";
            this.checkBoxTwitchPollsPostMessages.UseVisualStyleBackColor = true;
            this.checkBoxTwitchPollsPostMessages.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchPollsPostMessages_CheckedChanged);
            // 
            // labelTwitchPollsPassphrase
            // 
            this.labelTwitchPollsPassphrase.AutoSize = true;
            this.labelTwitchPollsPassphrase.Location = new System.Drawing.Point(3, 9);
            this.labelTwitchPollsPassphrase.Name = "labelTwitchPollsPassphrase";
            this.labelTwitchPollsPassphrase.Size = new System.Drawing.Size(65, 13);
            this.labelTwitchPollsPassphrase.TabIndex = 5;
            this.labelTwitchPollsPassphrase.Text = "Passphrase:";
            // 
            // textBoxTwitchPollsPassphrase
            // 
            this.textBoxTwitchPollsPassphrase.Location = new System.Drawing.Point(74, 6);
            this.textBoxTwitchPollsPassphrase.Name = "textBoxTwitchPollsPassphrase";
            this.textBoxTwitchPollsPassphrase.Size = new System.Drawing.Size(149, 20);
            this.textBoxTwitchPollsPassphrase.TabIndex = 4;
            this.textBoxTwitchPollsPassphrase.TextChanged += new System.EventHandler(this.TextBoxTwitchPollsPassphrase_TextChanged);
            // 
            // labelTwitchPollsBitsCost
            // 
            this.labelTwitchPollsBitsCost.AutoSize = true;
            this.labelTwitchPollsBitsCost.Location = new System.Drawing.Point(3, 189);
            this.labelTwitchPollsBitsCost.Name = "labelTwitchPollsBitsCost";
            this.labelTwitchPollsBitsCost.Size = new System.Drawing.Size(197, 13);
            this.labelTwitchPollsBitsCost.TabIndex = 3;
            this.labelTwitchPollsBitsCost.Text = "Bits Cost For Voting Again (0 = Disabled)";
            // 
            // checkBoxTwitchPollsSubcriberMultiplier
            // 
            this.checkBoxTwitchPollsSubcriberMultiplier.AutoSize = true;
            this.checkBoxTwitchPollsSubcriberMultiplier.Location = new System.Drawing.Point(6, 168);
            this.checkBoxTwitchPollsSubcriberMultiplier.Name = "checkBoxTwitchPollsSubcriberMultiplier";
            this.checkBoxTwitchPollsSubcriberMultiplier.Size = new System.Drawing.Size(151, 17);
            this.checkBoxTwitchPollsSubcriberMultiplier.TabIndex = 2;
            this.checkBoxTwitchPollsSubcriberMultiplier.Text = "Subscriber Votes Count 2x";
            this.checkBoxTwitchPollsSubcriberMultiplier.UseVisualStyleBackColor = true;
            this.checkBoxTwitchPollsSubcriberMultiplier.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchPollsSubcriberBonus_CheckedChanged);
            // 
            // checkBoxTwitchPollsSubscriberOnly
            // 
            this.checkBoxTwitchPollsSubscriberOnly.AutoSize = true;
            this.checkBoxTwitchPollsSubscriberOnly.Location = new System.Drawing.Point(6, 145);
            this.checkBoxTwitchPollsSubscriberOnly.Name = "checkBoxTwitchPollsSubscriberOnly";
            this.checkBoxTwitchPollsSubscriberOnly.Size = new System.Drawing.Size(125, 17);
            this.checkBoxTwitchPollsSubscriberOnly.TabIndex = 1;
            this.checkBoxTwitchPollsSubscriberOnly.Text = "Subscriber Only Polls";
            this.checkBoxTwitchPollsSubscriberOnly.UseVisualStyleBackColor = true;
            this.checkBoxTwitchPollsSubscriberOnly.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchPollsSubscriberOnly_CheckedChanged);
            // 
            // numericUpDownTwitchPollsBitsCost
            // 
            this.numericUpDownTwitchPollsBitsCost.Location = new System.Drawing.Point(6, 205);
            this.numericUpDownTwitchPollsBitsCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTwitchPollsBitsCost.Name = "numericUpDownTwitchPollsBitsCost";
            this.numericUpDownTwitchPollsBitsCost.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownTwitchPollsBitsCost.TabIndex = 0;
            this.numericUpDownTwitchPollsBitsCost.ValueChanged += new System.EventHandler(this.NumericUpDownTwitchPollsBitsCost_ValueChanged);
            // 
            // tabEffects
            // 
            this.tabEffects.BackColor = System.Drawing.Color.Transparent;
            this.tabEffects.Controls.Add(this.buttonEffectsToggleAll);
            this.tabEffects.Controls.Add(this.enabledEffectsView);
            this.tabEffects.Location = new System.Drawing.Point(4, 22);
            this.tabEffects.Name = "tabEffects";
            this.tabEffects.Padding = new System.Windows.Forms.Padding(3);
            this.tabEffects.Size = new System.Drawing.Size(452, 231);
            this.tabEffects.TabIndex = 1;
            this.tabEffects.Text = "Effects";
            // 
            // buttonEffectsToggleAll
            // 
            this.buttonEffectsToggleAll.Location = new System.Drawing.Point(6, 202);
            this.buttonEffectsToggleAll.Name = "buttonEffectsToggleAll";
            this.buttonEffectsToggleAll.Size = new System.Drawing.Size(440, 23);
            this.buttonEffectsToggleAll.TabIndex = 7;
            this.buttonEffectsToggleAll.Text = "Toggle All";
            this.buttonEffectsToggleAll.UseVisualStyleBackColor = true;
            this.buttonEffectsToggleAll.Click += new System.EventHandler(this.ButtonEffectsToggleAll_Click);
            // 
            // enabledEffectsView
            // 
            this.enabledEffectsView.CheckBoxes = true;
            this.enabledEffectsView.Location = new System.Drawing.Point(6, 6);
            this.enabledEffectsView.Name = "enabledEffectsView";
            this.enabledEffectsView.Size = new System.Drawing.Size(440, 190);
            this.enabledEffectsView.TabIndex = 3;
            this.enabledEffectsView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.EnabledEffectsView_AfterCheck);
            this.enabledEffectsView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.EnabledEffectsView_NodeMouseDoubleClick);
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.Transparent;
            this.tabSettings.Controls.Add(this.checkBoxRunEffectsWhenZeroVotes);
            this.tabSettings.Controls.Add(this.checkBoxPlayAudioForEffects);
            this.tabSettings.Controls.Add(this.checkBoxTwitchAppendFakePassCurrentMission);
            this.tabSettings.Controls.Add(this.checkBoxTwitchUsePolls);
            this.tabSettings.Controls.Add(this.checkBoxTwitchCombineVotingMessages);
            this.tabSettings.Controls.Add(this.checkBoxContinueTimer);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.textBoxSeed);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(452, 231);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            // 
            // checkBoxPlayAudioForEffects
            // 
            this.checkBoxPlayAudioForEffects.AutoSize = true;
            this.checkBoxPlayAudioForEffects.Checked = true;
            this.checkBoxPlayAudioForEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayAudioForEffects.Location = new System.Drawing.Point(6, 185);
            this.checkBoxPlayAudioForEffects.Name = "checkBoxPlayAudioForEffects";
            this.checkBoxPlayAudioForEffects.Size = new System.Drawing.Size(130, 17);
            this.checkBoxPlayAudioForEffects.TabIndex = 8;
            this.checkBoxPlayAudioForEffects.Text = "Play Audio For Effects";
            this.toolTipHandler.SetToolTip(this.checkBoxPlayAudioForEffects, "Some effects play a sound clip when\r\nthey get activated. Check this to have\r\nthem" +
        " play.");
            this.checkBoxPlayAudioForEffects.UseVisualStyleBackColor = true;
            this.checkBoxPlayAudioForEffects.CheckedChanged += new System.EventHandler(this.CheckBoxPlayAudioForEffects_CheckedChanged);
            // 
            // checkBoxTwitchAppendFakePassCurrentMission
            // 
            this.checkBoxTwitchAppendFakePassCurrentMission.AutoSize = true;
            this.checkBoxTwitchAppendFakePassCurrentMission.Location = new System.Drawing.Point(206, 162);
            this.checkBoxTwitchAppendFakePassCurrentMission.Name = "checkBoxTwitchAppendFakePassCurrentMission";
            this.checkBoxTwitchAppendFakePassCurrentMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchAppendFakePassCurrentMission.Size = new System.Drawing.Size(240, 17);
            this.checkBoxTwitchAppendFakePassCurrentMission.TabIndex = 7;
            this.checkBoxTwitchAppendFakePassCurrentMission.Text = "Append \"Fake\" to Fake Pass Current Mission";
            this.checkBoxTwitchAppendFakePassCurrentMission.UseVisualStyleBackColor = true;
            this.checkBoxTwitchAppendFakePassCurrentMission.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchAppendFakePassCurrentMission_CheckedChanged);
            // 
            // checkBoxTwitchUsePolls
            // 
            this.checkBoxTwitchUsePolls.AutoSize = true;
            this.checkBoxTwitchUsePolls.Location = new System.Drawing.Point(293, 185);
            this.checkBoxTwitchUsePolls.Name = "checkBoxTwitchUsePolls";
            this.checkBoxTwitchUsePolls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchUsePolls.Size = new System.Drawing.Size(153, 17);
            this.checkBoxTwitchUsePolls.TabIndex = 6;
            this.checkBoxTwitchUsePolls.Text = "Use Twitch Polls For Votes";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchUsePolls, "This will force majority voting,\r\nno matter what the checkbox is.\r\nThere is no in" +
        "formation on\r\nwhich user voted for which vote.");
            this.checkBoxTwitchUsePolls.UseVisualStyleBackColor = true;
            this.checkBoxTwitchUsePolls.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchUsePolls_CheckedChanged);
            // 
            // checkBoxTwitchCombineVotingMessages
            // 
            this.checkBoxTwitchCombineVotingMessages.AutoSize = true;
            this.checkBoxTwitchCombineVotingMessages.Location = new System.Drawing.Point(260, 208);
            this.checkBoxTwitchCombineVotingMessages.Name = "checkBoxTwitchCombineVotingMessages";
            this.checkBoxTwitchCombineVotingMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchCombineVotingMessages.Size = new System.Drawing.Size(186, 17);
            this.checkBoxTwitchCombineVotingMessages.TabIndex = 5;
            this.checkBoxTwitchCombineVotingMessages.Text = "Combine Twitch Voting Messages";
            this.checkBoxTwitchCombineVotingMessages.UseVisualStyleBackColor = true;
            this.checkBoxTwitchCombineVotingMessages.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchCombineVotingMessages_CheckedChanged);
            // 
            // checkBoxContinueTimer
            // 
            this.checkBoxContinueTimer.AutoSize = true;
            this.checkBoxContinueTimer.Checked = true;
            this.checkBoxContinueTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContinueTimer.Location = new System.Drawing.Point(6, 208);
            this.checkBoxContinueTimer.Name = "checkBoxContinueTimer";
            this.checkBoxContinueTimer.Size = new System.Drawing.Size(210, 17);
            this.checkBoxContinueTimer.TabIndex = 4;
            this.checkBoxContinueTimer.Text = "Continue Timer on Game Close / Crash";
            this.checkBoxContinueTimer.UseVisualStyleBackColor = true;
            this.checkBoxContinueTimer.CheckedChanged += new System.EventHandler(this.CheckBoxContinueTimer_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(47, 6);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(399, 20);
            this.textBoxSeed.TabIndex = 1;
            this.textBoxSeed.TextChanged += new System.EventHandler(this.TextBoxSeed_TextChanged);
            // 
            // tabMultiplayer
            // 
            this.tabMultiplayer.BackColor = System.Drawing.Color.Transparent;
            this.tabMultiplayer.Controls.Add(this.buttonMultiplayerSend);
            this.tabMultiplayer.Controls.Add(this.textBoxMultiplayerChat);
            this.tabMultiplayer.Controls.Add(this.listBoxMultiplayerChat);
            this.tabMultiplayer.Controls.Add(this.labelMultiplayerHost);
            this.tabMultiplayer.Controls.Add(this.textBoxMultiplayerUsername);
            this.tabMultiplayer.Controls.Add(this.labelMultiplayerUsername);
            this.tabMultiplayer.Controls.Add(this.labelMultiplayerChannel);
            this.tabMultiplayer.Controls.Add(this.textBoxMultiplayerChannel);
            this.tabMultiplayer.Controls.Add(this.labelMultiplayerServer);
            this.tabMultiplayer.Controls.Add(this.textBoxMultiplayerServer);
            this.tabMultiplayer.Controls.Add(this.buttonMultiplayerConnect);
            this.tabMultiplayer.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplayer.Name = "tabMultiplayer";
            this.tabMultiplayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMultiplayer.Size = new System.Drawing.Size(452, 231);
            this.tabMultiplayer.TabIndex = 6;
            this.tabMultiplayer.Text = "Multiplayer";
            // 
            // buttonMultiplayerSend
            // 
            this.buttonMultiplayerSend.Enabled = false;
            this.buttonMultiplayerSend.Location = new System.Drawing.Point(359, 205);
            this.buttonMultiplayerSend.Name = "buttonMultiplayerSend";
            this.buttonMultiplayerSend.Size = new System.Drawing.Size(87, 20);
            this.buttonMultiplayerSend.TabIndex = 10;
            this.buttonMultiplayerSend.Text = "Send";
            this.buttonMultiplayerSend.UseVisualStyleBackColor = true;
            this.buttonMultiplayerSend.Click += new System.EventHandler(this.ButtonMultiplayerSend_Click);
            // 
            // textBoxMultiplayerChat
            // 
            this.textBoxMultiplayerChat.Location = new System.Drawing.Point(6, 205);
            this.textBoxMultiplayerChat.MaxLength = 128;
            this.textBoxMultiplayerChat.Name = "textBoxMultiplayerChat";
            this.textBoxMultiplayerChat.Size = new System.Drawing.Size(347, 20);
            this.textBoxMultiplayerChat.TabIndex = 9;
            this.textBoxMultiplayerChat.TextChanged += new System.EventHandler(this.TextBoxMultiplayerChat_TextChanged);
            this.textBoxMultiplayerChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMultiplayerChat_KeyDown);
            // 
            // listBoxMultiplayerChat
            // 
            this.listBoxMultiplayerChat.FormattingEnabled = true;
            this.listBoxMultiplayerChat.Location = new System.Drawing.Point(6, 104);
            this.listBoxMultiplayerChat.Name = "listBoxMultiplayerChat";
            this.listBoxMultiplayerChat.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMultiplayerChat.Size = new System.Drawing.Size(440, 95);
            this.listBoxMultiplayerChat.TabIndex = 8;
            // 
            // labelMultiplayerHost
            // 
            this.labelMultiplayerHost.AutoSize = true;
            this.labelMultiplayerHost.Location = new System.Drawing.Point(234, 10);
            this.labelMultiplayerHost.Name = "labelMultiplayerHost";
            this.labelMultiplayerHost.Size = new System.Drawing.Size(87, 13);
            this.labelMultiplayerHost.TabIndex = 7;
            this.labelMultiplayerHost.Text = "Not connected...";
            // 
            // textBoxMultiplayerUsername
            // 
            this.textBoxMultiplayerUsername.Location = new System.Drawing.Point(70, 34);
            this.textBoxMultiplayerUsername.MaxLength = 16;
            this.textBoxMultiplayerUsername.Name = "textBoxMultiplayerUsername";
            this.textBoxMultiplayerUsername.Size = new System.Drawing.Size(158, 20);
            this.textBoxMultiplayerUsername.TabIndex = 2;
            this.textBoxMultiplayerUsername.TextChanged += new System.EventHandler(this.TextBoxMultiplayerUsername_TextChanged);
            // 
            // labelMultiplayerUsername
            // 
            this.labelMultiplayerUsername.AutoSize = true;
            this.labelMultiplayerUsername.Location = new System.Drawing.Point(6, 37);
            this.labelMultiplayerUsername.Name = "labelMultiplayerUsername";
            this.labelMultiplayerUsername.Size = new System.Drawing.Size(58, 13);
            this.labelMultiplayerUsername.TabIndex = 5;
            this.labelMultiplayerUsername.Text = "Username:";
            // 
            // labelMultiplayerChannel
            // 
            this.labelMultiplayerChannel.AutoSize = true;
            this.labelMultiplayerChannel.Location = new System.Drawing.Point(6, 63);
            this.labelMultiplayerChannel.Name = "labelMultiplayerChannel";
            this.labelMultiplayerChannel.Size = new System.Drawing.Size(49, 13);
            this.labelMultiplayerChannel.TabIndex = 4;
            this.labelMultiplayerChannel.Text = "Channel:";
            // 
            // textBoxMultiplayerChannel
            // 
            this.textBoxMultiplayerChannel.Location = new System.Drawing.Point(70, 60);
            this.textBoxMultiplayerChannel.MaxLength = 16;
            this.textBoxMultiplayerChannel.Name = "textBoxMultiplayerChannel";
            this.textBoxMultiplayerChannel.Size = new System.Drawing.Size(158, 20);
            this.textBoxMultiplayerChannel.TabIndex = 3;
            this.textBoxMultiplayerChannel.TextChanged += new System.EventHandler(this.TextBoxMultiplayerChannel_TextChanged);
            // 
            // labelMultiplayerServer
            // 
            this.labelMultiplayerServer.AutoSize = true;
            this.labelMultiplayerServer.Location = new System.Drawing.Point(6, 10);
            this.labelMultiplayerServer.Name = "labelMultiplayerServer";
            this.labelMultiplayerServer.Size = new System.Drawing.Size(41, 13);
            this.labelMultiplayerServer.TabIndex = 2;
            this.labelMultiplayerServer.Text = "Server:";
            // 
            // textBoxMultiplayerServer
            // 
            this.textBoxMultiplayerServer.Location = new System.Drawing.Point(70, 7);
            this.textBoxMultiplayerServer.Name = "textBoxMultiplayerServer";
            this.textBoxMultiplayerServer.Size = new System.Drawing.Size(158, 20);
            this.textBoxMultiplayerServer.TabIndex = 1;
            this.textBoxMultiplayerServer.TextChanged += new System.EventHandler(this.TextBoxMultiplayerServer_TextChanged);
            // 
            // buttonMultiplayerConnect
            // 
            this.buttonMultiplayerConnect.Enabled = false;
            this.buttonMultiplayerConnect.Location = new System.Drawing.Point(234, 33);
            this.buttonMultiplayerConnect.Name = "buttonMultiplayerConnect";
            this.buttonMultiplayerConnect.Size = new System.Drawing.Size(87, 20);
            this.buttonMultiplayerConnect.TabIndex = 4;
            this.buttonMultiplayerConnect.Text = "Connect";
            this.buttonMultiplayerConnect.UseVisualStyleBackColor = true;
            this.buttonMultiplayerConnect.Click += new System.EventHandler(this.ButtonMultiplayerConnect_Click);
            // 
            // tabExperimental
            // 
            this.tabExperimental.BackColor = System.Drawing.Color.Transparent;
            this.tabExperimental.Controls.Add(this.checkBoxExperimental_TwitchDisableRapidFire);
            this.tabExperimental.Controls.Add(this.buttonExperimentalRunEffect);
            this.tabExperimental.Controls.Add(this.textBoxExperimentalEffectName);
            this.tabExperimental.Controls.Add(this.checkBoxExperimental_TwitchAnarchyMode);
            this.tabExperimental.Controls.Add(this.checkBoxExperimental_RunEffectOnAutoStart);
            this.tabExperimental.Controls.Add(this.checkBoxExperimental_EnableAllEffects);
            this.tabExperimental.Location = new System.Drawing.Point(4, 22);
            this.tabExperimental.Name = "tabExperimental";
            this.tabExperimental.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperimental.Size = new System.Drawing.Size(452, 231);
            this.tabExperimental.TabIndex = 7;
            this.tabExperimental.Text = "Experimental";
            // 
            // checkBoxExperimental_TwitchDisableRapidFire
            // 
            this.checkBoxExperimental_TwitchDisableRapidFire.AutoSize = true;
            this.checkBoxExperimental_TwitchDisableRapidFire.Location = new System.Drawing.Point(6, 75);
            this.checkBoxExperimental_TwitchDisableRapidFire.Name = "checkBoxExperimental_TwitchDisableRapidFire";
            this.checkBoxExperimental_TwitchDisableRapidFire.Size = new System.Drawing.Size(236, 17);
            this.checkBoxExperimental_TwitchDisableRapidFire.TabIndex = 16;
            this.checkBoxExperimental_TwitchDisableRapidFire.Text = "EXPERIMENTAL: Twitch Disable Rapid-Fire";
            this.checkBoxExperimental_TwitchDisableRapidFire.UseVisualStyleBackColor = true;
            this.checkBoxExperimental_TwitchDisableRapidFire.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchDisableRapidFire_CheckedChanged);
            // 
            // buttonExperimentalRunEffect
            // 
            this.buttonExperimentalRunEffect.Location = new System.Drawing.Point(371, 205);
            this.buttonExperimentalRunEffect.Name = "buttonExperimentalRunEffect";
            this.buttonExperimentalRunEffect.Size = new System.Drawing.Size(75, 23);
            this.buttonExperimentalRunEffect.TabIndex = 15;
            this.buttonExperimentalRunEffect.Text = "Run";
            this.buttonExperimentalRunEffect.UseVisualStyleBackColor = true;
            this.buttonExperimentalRunEffect.Click += new System.EventHandler(this.ButtonExperimentalRunEffect_Click);
            // 
            // textBoxExperimentalEffectName
            // 
            this.textBoxExperimentalEffectName.Location = new System.Drawing.Point(6, 205);
            this.textBoxExperimentalEffectName.Name = "textBoxExperimentalEffectName";
            this.textBoxExperimentalEffectName.Size = new System.Drawing.Size(359, 20);
            this.textBoxExperimentalEffectName.TabIndex = 14;
            // 
            // checkBoxExperimental_TwitchAnarchyMode
            // 
            this.checkBoxExperimental_TwitchAnarchyMode.AutoSize = true;
            this.checkBoxExperimental_TwitchAnarchyMode.Location = new System.Drawing.Point(6, 52);
            this.checkBoxExperimental_TwitchAnarchyMode.Name = "checkBoxExperimental_TwitchAnarchyMode";
            this.checkBoxExperimental_TwitchAnarchyMode.Size = new System.Drawing.Size(219, 17);
            this.checkBoxExperimental_TwitchAnarchyMode.TabIndex = 13;
            this.checkBoxExperimental_TwitchAnarchyMode.Text = "EXPERIMENTAL: Twitch Anarchy Mode";
            this.checkBoxExperimental_TwitchAnarchyMode.UseVisualStyleBackColor = true;
            this.checkBoxExperimental_TwitchAnarchyMode.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchAnarchyMode_CheckedChanged);
            // 
            // checkBoxExperimental_RunEffectOnAutoStart
            // 
            this.checkBoxExperimental_RunEffectOnAutoStart.AutoSize = true;
            this.checkBoxExperimental_RunEffectOnAutoStart.Location = new System.Drawing.Point(6, 29);
            this.checkBoxExperimental_RunEffectOnAutoStart.Name = "checkBoxExperimental_RunEffectOnAutoStart";
            this.checkBoxExperimental_RunEffectOnAutoStart.Size = new System.Drawing.Size(246, 17);
            this.checkBoxExperimental_RunEffectOnAutoStart.TabIndex = 12;
            this.checkBoxExperimental_RunEffectOnAutoStart.Text = "EXPERIMENTAL: Enable Effect On Auto-Start";
            this.toolTipHandler.SetToolTip(this.checkBoxExperimental_RunEffectOnAutoStart, "When auto-start kicks in\r\nit will enable an effect immediately\r\ninstead of only s" +
        "tarting the\r\ntimer.\r\nDoesn\'t work for Twitch mode.");
            this.checkBoxExperimental_RunEffectOnAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxExperimental_RunEffectOnAutoStart.Click += new System.EventHandler(this.CheckBoxExperimental_EnableEffectOnAutoStart_CheckedChanged);
            // 
            // checkBoxExperimental_EnableAllEffects
            // 
            this.checkBoxExperimental_EnableAllEffects.AutoSize = true;
            this.checkBoxExperimental_EnableAllEffects.Location = new System.Drawing.Point(6, 6);
            this.checkBoxExperimental_EnableAllEffects.Name = "checkBoxExperimental_EnableAllEffects";
            this.checkBoxExperimental_EnableAllEffects.Size = new System.Drawing.Size(198, 17);
            this.checkBoxExperimental_EnableAllEffects.TabIndex = 11;
            this.checkBoxExperimental_EnableAllEffects.Text = "EXPERIMENTAL: Enable All Effects";
            this.toolTipHandler.SetToolTip(this.checkBoxExperimental_EnableAllEffects, "When the cooldown runs out it\r\nwill enable all effects that were\r\nselected.\r\nUsef" +
        "ul for \"constant effect\" runs.");
            this.checkBoxExperimental_EnableAllEffects.UseVisualStyleBackColor = true;
            this.checkBoxExperimental_EnableAllEffects.Click += new System.EventHandler(this.CheckBoxExperimental_EnableAllEffects_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetToolStripMenuItem,
            this.savePresetToolStripMenuItem,
            this.experimentalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPresetToolStripMenuItem
            // 
            this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
            this.loadPresetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadPresetToolStripMenuItem.Text = "Load Preset";
            this.loadPresetToolStripMenuItem.Click += new System.EventHandler(this.LoadPresetToolStripMenuItem_Click);
            // 
            // savePresetToolStripMenuItem
            // 
            this.savePresetToolStripMenuItem.Name = "savePresetToolStripMenuItem";
            this.savePresetToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.savePresetToolStripMenuItem.Text = "Save Preset";
            this.savePresetToolStripMenuItem.Click += new System.EventHandler(this.SavePresetToolStripMenuItem_Click);
            // 
            // experimentalToolStripMenuItem
            // 
            this.experimentalToolStripMenuItem.Name = "experimentalToolStripMenuItem";
            this.experimentalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.experimentalToolStripMenuItem.Text = "Experimental";
            this.experimentalToolStripMenuItem.Click += new System.EventHandler(this.ExperimentalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viceCityToolStripMenuItem,
            this.sanAndreasToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // viceCityToolStripMenuItem
            // 
            this.viceCityToolStripMenuItem.Name = "viceCityToolStripMenuItem";
            this.viceCityToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viceCityToolStripMenuItem.Text = "Vice City";
            this.viceCityToolStripMenuItem.Click += new System.EventHandler(this.ViceCityToolStripMenuItem_Click);
            // 
            // sanAndreasToolStripMenuItem
            // 
            this.sanAndreasToolStripMenuItem.Name = "sanAndreasToolStripMenuItem";
            this.sanAndreasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sanAndreasToolStripMenuItem.Text = "San Andreas";
            this.sanAndreasToolStripMenuItem.Click += new System.EventHandler(this.SanAndreasToolStripMenuItem_Click);
            // 
            // buttonAutoStart
            // 
            this.buttonAutoStart.Location = new System.Drawing.Point(12, 27);
            this.buttonAutoStart.Name = "buttonAutoStart";
            this.buttonAutoStart.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoStart.TabIndex = 6;
            this.buttonAutoStart.Text = "Auto-Start";
            this.buttonAutoStart.UseVisualStyleBackColor = true;
            this.buttonAutoStart.Click += new System.EventHandler(this.ButtonAutoStart_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 10;
            this.timerMain.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // buttonSwitchMode
            // 
            this.buttonSwitchMode.Location = new System.Drawing.Point(393, 27);
            this.buttonSwitchMode.Name = "buttonSwitchMode";
            this.buttonSwitchMode.Size = new System.Drawing.Size(75, 23);
            this.buttonSwitchMode.TabIndex = 7;
            this.buttonSwitchMode.Text = "Twitch";
            this.buttonSwitchMode.UseVisualStyleBackColor = true;
            this.buttonSwitchMode.Click += new System.EventHandler(this.ButtonSwitchMode_Click);
            // 
            // checkBoxRunEffectsWhenZeroVotes
            // 
            this.checkBoxRunEffectsWhenZeroVotes.AutoSize = true;
            this.checkBoxRunEffectsWhenZeroVotes.Location = new System.Drawing.Point(293, 139);
            this.checkBoxRunEffectsWhenZeroVotes.Name = "checkBoxRunEffectsWhenZeroVotes";
            this.checkBoxRunEffectsWhenZeroVotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRunEffectsWhenZeroVotes.Size = new System.Drawing.Size(153, 17);
            this.checkBoxRunEffectsWhenZeroVotes.TabIndex = 9;
            this.checkBoxRunEffectsWhenZeroVotes.Text = "Run Effects When 0 Votes";
            this.toolTipHandler.SetToolTip(this.checkBoxRunEffectsWhenZeroVotes, "When enabled it will run effects when 0 votes in total happen.\r\nOtherwise no effe" +
        "ct will be enabled.\r\nUseful for when a poll fails.");
            this.checkBoxRunEffectsWhenZeroVotes.UseVisualStyleBackColor = true;
            this.checkBoxRunEffectsWhenZeroVotes.CheckedChanged += new System.EventHandler(this.checkBoxRunEffectWhenZeroVotes_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 325);
            this.Controls.Add(this.buttonSwitchMode);
            this.Controls.Add(this.buttonAutoStart);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GTA:SA Chaos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabTwitch.ResumeLayout(false);
            this.tabTwitch.PerformLayout();
            this.tabPolls.ResumeLayout(false);
            this.tabPolls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwitchPollsBitsCost)).EndInit();
            this.tabEffects.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabMultiplayer.ResumeLayout(false);
            this.tabMultiplayer.PerformLayout();
            this.tabExperimental.ResumeLayout(false);
            this.tabExperimental.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainToggle;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabEffects;
        private System.Windows.Forms.TreeView enabledEffectsView;
        private System.Windows.Forms.ListBox listLastEffectsMain;
        private System.Windows.Forms.ComboBox comboBoxMainCooldown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabTwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTwitchOAuth;
        private System.Windows.Forms.TextBox textBoxTwitchUsername;
        private System.Windows.Forms.Button buttonConnectTwitch;
        private System.Windows.Forms.ListBox listLastEffectsTwitch;
        private System.Windows.Forms.ToolTip toolTipHandler;
        private System.Windows.Forms.ComboBox comboBoxVotingCooldown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVotingTime;
        private System.Windows.Forms.ProgressBar progressBarTwitch;
        private System.Windows.Forms.Button buttonTwitchToggle;
        private System.Windows.Forms.Button buttonAutoStart;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSwitchMode;
        private System.Windows.Forms.Label labelTwitchCurrentMode;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Button buttonResetMain;
        private System.Windows.Forms.CheckBox checkBoxContinueTimer;
        private System.Windows.Forms.CheckBox checkBoxShowLastEffectsMain;
        private System.Windows.Forms.CheckBox checkBoxShowLastEffectsTwitch;
        private System.Windows.Forms.CheckBox checkBoxTwitchAllowOnlyEnabledEffects;
        private System.Windows.Forms.Button buttonResetTwitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTwitchChannel;
        private System.Windows.Forms.CheckBox checkBoxTwitch3TimesCooldown;
        private System.Windows.Forms.Button buttonEffectsToggleAll;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viceCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanAndreasToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxTwitchCombineVotingMessages;
        private System.Windows.Forms.CheckBox checkBoxTwitchUsePolls;
        private System.Windows.Forms.CheckBox checkBoxTwitchEnableMultipleEffects;
        private System.Windows.Forms.TabPage tabPolls;
        private System.Windows.Forms.Label labelTwitchPollsBitsCost;
        private System.Windows.Forms.CheckBox checkBoxTwitchPollsSubcriberMultiplier;
        private System.Windows.Forms.CheckBox checkBoxTwitchPollsSubscriberOnly;
        private System.Windows.Forms.NumericUpDown numericUpDownTwitchPollsBitsCost;
        private System.Windows.Forms.Label labelTwitchPollsPassphrase;
        private System.Windows.Forms.TextBox textBoxTwitchPollsPassphrase;
        private System.Windows.Forms.CheckBox checkBoxTwitchPollsPostMessages;
        private System.Windows.Forms.CheckBox checkBoxTwitchAppendFakePassCurrentMission;
        private System.Windows.Forms.CheckBox checkBoxPlayAudioForEffects;
        private System.Windows.Forms.TabPage tabMultiplayer;
        private System.Windows.Forms.TextBox textBoxMultiplayerUsername;
        private System.Windows.Forms.Label labelMultiplayerUsername;
        private System.Windows.Forms.Label labelMultiplayerChannel;
        private System.Windows.Forms.TextBox textBoxMultiplayerChannel;
        private System.Windows.Forms.Label labelMultiplayerServer;
        private System.Windows.Forms.TextBox textBoxMultiplayerServer;
        private System.Windows.Forms.Button buttonMultiplayerConnect;
        private System.Windows.Forms.Label labelMultiplayerHost;
        private System.Windows.Forms.Button buttonMultiplayerSend;
        private System.Windows.Forms.TextBox textBoxMultiplayerChat;
        private System.Windows.Forms.ListBox listBoxMultiplayerChat;
        private System.Windows.Forms.TabPage tabExperimental;
        private System.Windows.Forms.ToolStripMenuItem experimentalToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxExperimental_RunEffectOnAutoStart;
        private System.Windows.Forms.CheckBox checkBoxExperimental_EnableAllEffects;
        private System.Windows.Forms.CheckBox checkBoxExperimental_TwitchAnarchyMode;
        private System.Windows.Forms.Button buttonExperimentalRunEffect;
        private System.Windows.Forms.TextBox textBoxExperimentalEffectName;
        private System.Windows.Forms.CheckBox checkBoxExperimental_TwitchDisableRapidFire;
        private System.Windows.Forms.CheckBox checkBoxRunEffectsWhenZeroVotes;
    }
}

