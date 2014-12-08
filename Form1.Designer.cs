﻿namespace VTC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelMultiTransFile = new System.Windows.Forms.Label();
            this.buttonMultiTransFile = new System.Windows.Forms.Button();
            this.panelTranscode = new System.Windows.Forms.Panel();
            this.labelOutTransFile = new System.Windows.Forms.Label();
            this.labelInputTransFile = new System.Windows.Forms.Label();
            this.buttonOutTransFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRemoveSubtitle = new System.Windows.Forms.Button();
            this.labelAddSubtitle = new System.Windows.Forms.Label();
            this.buttonAddSubtitle = new System.Windows.Forms.Button();
            this.labelInputConv = new System.Windows.Forms.Label();
            this.labelMultiConv = new System.Windows.Forms.Label();
            this.groupBoxVideoOrAudio = new System.Windows.Forms.GroupBox();
            this.checkBoxAudioOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxVideoOnly = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.labelPreset = new System.Windows.Forms.Label();
            this.labelQuality = new System.Windows.Forms.Label();
            this.labelAudio = new System.Windows.Forms.Label();
            this.comboBoxPreset = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioBitRate = new System.Windows.Forms.ComboBox();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.groupBoxAudio = new System.Windows.Forms.GroupBox();
            this.radioButtonCopyAudio = new System.Windows.Forms.RadioButton();
            this.radioButtonMP3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAAC = new System.Windows.Forms.RadioButton();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.radioButtonCopyVideo = new System.Windows.Forms.RadioButton();
            this.radioButtonMP4 = new System.Windows.Forms.RadioButton();
            this.radioButtonMKV = new System.Windows.Forms.RadioButton();
            this.labelTextBoxConv = new System.Windows.Forms.Label();
            this.labelOutConvFile = new System.Windows.Forms.Label();
            this.labelInputConvFile = new System.Windows.Forms.Label();
            this.buttonAddBatchConv = new System.Windows.Forms.Button();
            this.buttonMultiConvFiles = new System.Windows.Forms.Button();
            this.panelConvert = new System.Windows.Forms.Panel();
            this.richTextBoxConv = new System.Windows.Forms.RichTextBox();
            this.buttonOutConvFile = new System.Windows.Forms.Button();
            this.buttonInputConvFile = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelBatch = new System.Windows.Forms.Panel();
            this.buttonUnselectAll = new System.Windows.Forms.Button();
            this.buttonSellectAllQueue = new System.Windows.Forms.Button();
            this.dataGridViewBatch = new System.Windows.Forms.DataGridView();
            this.check_cell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.no_cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteQueue = new System.Windows.Forms.Button();
            this.buttonCancelBatch = new System.Windows.Forms.Button();
            this.buttonStartQueue = new System.Windows.Forms.Button();
            this.timerBatch = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxVideoOrAudio.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxAudio.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
            this.panelConvert.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(7, 3, 1, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.buttonHelp);
            this.tabPage1.Controls.Add(this.buttonAbout);
            this.tabPage1.Controls.Add(this.labelMultiTransFile);
            this.tabPage1.Controls.Add(this.buttonMultiTransFile);
            this.tabPage1.Controls.Add(this.panelTranscode);
            this.tabPage1.Controls.Add(this.labelOutTransFile);
            this.tabPage1.Controls.Add(this.labelInputTransFile);
            this.tabPage1.Controls.Add(this.buttonOutTransFile);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click_1);
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelMultiTransFile
            // 
            resources.ApplyResources(this.labelMultiTransFile, "labelMultiTransFile");
            this.labelMultiTransFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMultiTransFile.Name = "labelMultiTransFile";
            // 
            // buttonMultiTransFile
            // 
            resources.ApplyResources(this.buttonMultiTransFile, "buttonMultiTransFile");
            this.buttonMultiTransFile.AllowDrop = true;
            this.buttonMultiTransFile.Name = "buttonMultiTransFile";
            this.buttonMultiTransFile.UseVisualStyleBackColor = true;
            this.buttonMultiTransFile.Click += new System.EventHandler(this.buttonMultiTransFile_Click);
            // 
            // panelTranscode
            // 
            resources.ApplyResources(this.panelTranscode, "panelTranscode");
            this.panelTranscode.Name = "panelTranscode";
            // 
            // labelOutTransFile
            // 
            resources.ApplyResources(this.labelOutTransFile, "labelOutTransFile");
            this.labelOutTransFile.Name = "labelOutTransFile";
            // 
            // labelInputTransFile
            // 
            resources.ApplyResources(this.labelInputTransFile, "labelInputTransFile");
            this.labelInputTransFile.Name = "labelInputTransFile";
            // 
            // buttonOutTransFile
            // 
            resources.ApplyResources(this.buttonOutTransFile, "buttonOutTransFile");
            this.buttonOutTransFile.Name = "buttonOutTransFile";
            this.buttonOutTransFile.UseVisualStyleBackColor = true;
            this.buttonOutTransFile.Click += new System.EventHandler(this.buttonOutTransFile_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.buttonRemoveSubtitle);
            this.tabPage2.Controls.Add(this.labelAddSubtitle);
            this.tabPage2.Controls.Add(this.buttonAddSubtitle);
            this.tabPage2.Controls.Add(this.labelInputConv);
            this.tabPage2.Controls.Add(this.labelMultiConv);
            this.tabPage2.Controls.Add(this.groupBoxVideoOrAudio);
            this.tabPage2.Controls.Add(this.groupBoxOptions);
            this.tabPage2.Controls.Add(this.groupBoxAudio);
            this.tabPage2.Controls.Add(this.groupBoxContainer);
            this.tabPage2.Controls.Add(this.labelTextBoxConv);
            this.tabPage2.Controls.Add(this.labelOutConvFile);
            this.tabPage2.Controls.Add(this.labelInputConvFile);
            this.tabPage2.Controls.Add(this.buttonAddBatchConv);
            this.tabPage2.Controls.Add(this.buttonMultiConvFiles);
            this.tabPage2.Controls.Add(this.panelConvert);
            this.tabPage2.Controls.Add(this.buttonOutConvFile);
            this.tabPage2.Controls.Add(this.buttonInputConvFile);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSubtitle
            // 
            resources.ApplyResources(this.buttonRemoveSubtitle, "buttonRemoveSubtitle");
            this.buttonRemoveSubtitle.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSubtitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRemoveSubtitle.Name = "buttonRemoveSubtitle";
            this.buttonRemoveSubtitle.UseVisualStyleBackColor = true;
            this.buttonRemoveSubtitle.Click += new System.EventHandler(this.buttonRemoveSubtitle_Click);
            // 
            // labelAddSubtitle
            // 
            resources.ApplyResources(this.labelAddSubtitle, "labelAddSubtitle");
            this.labelAddSubtitle.Name = "labelAddSubtitle";
            // 
            // buttonAddSubtitle
            // 
            resources.ApplyResources(this.buttonAddSubtitle, "buttonAddSubtitle");
            this.buttonAddSubtitle.Name = "buttonAddSubtitle";
            this.buttonAddSubtitle.UseVisualStyleBackColor = true;
            this.buttonAddSubtitle.Click += new System.EventHandler(this.buttonAddSubtitle_Click);
            // 
            // labelInputConv
            // 
            resources.ApplyResources(this.labelInputConv, "labelInputConv");
            this.labelInputConv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInputConv.Name = "labelInputConv";
            // 
            // labelMultiConv
            // 
            resources.ApplyResources(this.labelMultiConv, "labelMultiConv");
            this.labelMultiConv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMultiConv.Name = "labelMultiConv";
            // 
            // groupBoxVideoOrAudio
            // 
            resources.ApplyResources(this.groupBoxVideoOrAudio, "groupBoxVideoOrAudio");
            this.groupBoxVideoOrAudio.Controls.Add(this.checkBoxAudioOnly);
            this.groupBoxVideoOrAudio.Controls.Add(this.checkBoxVideoOnly);
            this.groupBoxVideoOrAudio.Name = "groupBoxVideoOrAudio";
            this.groupBoxVideoOrAudio.TabStop = false;
            // 
            // checkBoxAudioOnly
            // 
            resources.ApplyResources(this.checkBoxAudioOnly, "checkBoxAudioOnly");
            this.checkBoxAudioOnly.Name = "checkBoxAudioOnly";
            this.checkBoxAudioOnly.UseVisualStyleBackColor = true;
            this.checkBoxAudioOnly.CheckedChanged += new System.EventHandler(this.checkBoxAudioOnly_CheckedChanged);
            // 
            // checkBoxVideoOnly
            // 
            resources.ApplyResources(this.checkBoxVideoOnly, "checkBoxVideoOnly");
            this.checkBoxVideoOnly.Name = "checkBoxVideoOnly";
            this.checkBoxVideoOnly.UseVisualStyleBackColor = true;
            this.checkBoxVideoOnly.CheckedChanged += new System.EventHandler(this.checkBoxVideoOnly_CheckedChanged);
            // 
            // groupBoxOptions
            // 
            resources.ApplyResources(this.groupBoxOptions, "groupBoxOptions");
            this.groupBoxOptions.Controls.Add(this.labelPreset);
            this.groupBoxOptions.Controls.Add(this.labelQuality);
            this.groupBoxOptions.Controls.Add(this.labelAudio);
            this.groupBoxOptions.Controls.Add(this.comboBoxPreset);
            this.groupBoxOptions.Controls.Add(this.comboBoxAudioBitRate);
            this.groupBoxOptions.Controls.Add(this.comboBoxQuality);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.TabStop = false;
            // 
            // labelPreset
            // 
            resources.ApplyResources(this.labelPreset, "labelPreset");
            this.labelPreset.Name = "labelPreset";
            // 
            // labelQuality
            // 
            resources.ApplyResources(this.labelQuality, "labelQuality");
            this.labelQuality.Name = "labelQuality";
            // 
            // labelAudio
            // 
            resources.ApplyResources(this.labelAudio, "labelAudio");
            this.labelAudio.Name = "labelAudio";
            // 
            // comboBoxPreset
            // 
            resources.ApplyResources(this.comboBoxPreset, "comboBoxPreset");
            this.comboBoxPreset.FormattingEnabled = true;
            this.comboBoxPreset.Items.AddRange(new object[] {
            resources.GetString("comboBoxPreset.Items"),
            resources.GetString("comboBoxPreset.Items1"),
            resources.GetString("comboBoxPreset.Items2"),
            resources.GetString("comboBoxPreset.Items3"),
            resources.GetString("comboBoxPreset.Items4"),
            resources.GetString("comboBoxPreset.Items5"),
            resources.GetString("comboBoxPreset.Items6"),
            resources.GetString("comboBoxPreset.Items7")});
            this.comboBoxPreset.Name = "comboBoxPreset";
            this.comboBoxPreset.SelectedIndexChanged += new System.EventHandler(this.comboBoxPreset_SelectedIndexChanged);
            // 
            // comboBoxAudioBitRate
            // 
            resources.ApplyResources(this.comboBoxAudioBitRate, "comboBoxAudioBitRate");
            this.comboBoxAudioBitRate.FormattingEnabled = true;
            this.comboBoxAudioBitRate.Items.AddRange(new object[] {
            resources.GetString("comboBoxAudioBitRate.Items"),
            resources.GetString("comboBoxAudioBitRate.Items1"),
            resources.GetString("comboBoxAudioBitRate.Items2"),
            resources.GetString("comboBoxAudioBitRate.Items3"),
            resources.GetString("comboBoxAudioBitRate.Items4"),
            resources.GetString("comboBoxAudioBitRate.Items5"),
            resources.GetString("comboBoxAudioBitRate.Items6"),
            resources.GetString("comboBoxAudioBitRate.Items7")});
            this.comboBoxAudioBitRate.Name = "comboBoxAudioBitRate";
            this.comboBoxAudioBitRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioBitRate_SelectedIndexChanged);
            // 
            // comboBoxQuality
            // 
            resources.ApplyResources(this.comboBoxQuality, "comboBoxQuality");
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Items.AddRange(new object[] {
            resources.GetString("comboBoxQuality.Items"),
            resources.GetString("comboBoxQuality.Items1"),
            resources.GetString("comboBoxQuality.Items2"),
            resources.GetString("comboBoxQuality.Items3"),
            resources.GetString("comboBoxQuality.Items4"),
            resources.GetString("comboBoxQuality.Items5"),
            resources.GetString("comboBoxQuality.Items6"),
            resources.GetString("comboBoxQuality.Items7"),
            resources.GetString("comboBoxQuality.Items8")});
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuality_SelectedIndexChanged);
            // 
            // groupBoxAudio
            // 
            resources.ApplyResources(this.groupBoxAudio, "groupBoxAudio");
            this.groupBoxAudio.Controls.Add(this.radioButtonCopyAudio);
            this.groupBoxAudio.Controls.Add(this.radioButtonMP3);
            this.groupBoxAudio.Controls.Add(this.radioButtonAAC);
            this.groupBoxAudio.Name = "groupBoxAudio";
            this.groupBoxAudio.TabStop = false;
            // 
            // radioButtonCopyAudio
            // 
            resources.ApplyResources(this.radioButtonCopyAudio, "radioButtonCopyAudio");
            this.radioButtonCopyAudio.Name = "radioButtonCopyAudio";
            this.radioButtonCopyAudio.TabStop = true;
            this.radioButtonCopyAudio.UseVisualStyleBackColor = true;
            this.radioButtonCopyAudio.CheckedChanged += new System.EventHandler(this.radioButtonCopyAudio_CheckedChanged);
            // 
            // radioButtonMP3
            // 
            resources.ApplyResources(this.radioButtonMP3, "radioButtonMP3");
            this.radioButtonMP3.Checked = true;
            this.radioButtonMP3.Name = "radioButtonMP3";
            this.radioButtonMP3.TabStop = true;
            this.radioButtonMP3.UseVisualStyleBackColor = true;
            this.radioButtonMP3.CheckedChanged += new System.EventHandler(this.radioButtonMP3_CheckedChanged);
            // 
            // radioButtonAAC
            // 
            resources.ApplyResources(this.radioButtonAAC, "radioButtonAAC");
            this.radioButtonAAC.Name = "radioButtonAAC";
            this.radioButtonAAC.UseVisualStyleBackColor = true;
            this.radioButtonAAC.CheckedChanged += new System.EventHandler(this.radioButtonAAC_CheckedChanged);
            // 
            // groupBoxContainer
            // 
            resources.ApplyResources(this.groupBoxContainer, "groupBoxContainer");
            this.groupBoxContainer.Controls.Add(this.radioButtonCopyVideo);
            this.groupBoxContainer.Controls.Add(this.radioButtonMP4);
            this.groupBoxContainer.Controls.Add(this.radioButtonMKV);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.TabStop = false;
            // 
            // radioButtonCopyVideo
            // 
            resources.ApplyResources(this.radioButtonCopyVideo, "radioButtonCopyVideo");
            this.radioButtonCopyVideo.Name = "radioButtonCopyVideo";
            this.radioButtonCopyVideo.TabStop = true;
            this.radioButtonCopyVideo.UseVisualStyleBackColor = true;
            this.radioButtonCopyVideo.CheckedChanged += new System.EventHandler(this.radioButtonCopyVideo_CheckedChanged);
            // 
            // radioButtonMP4
            // 
            resources.ApplyResources(this.radioButtonMP4, "radioButtonMP4");
            this.radioButtonMP4.Name = "radioButtonMP4";
            this.radioButtonMP4.TabStop = true;
            this.radioButtonMP4.UseVisualStyleBackColor = true;
            this.radioButtonMP4.CheckedChanged += new System.EventHandler(this.radioButtonMP4_CheckedChanged);
            // 
            // radioButtonMKV
            // 
            resources.ApplyResources(this.radioButtonMKV, "radioButtonMKV");
            this.radioButtonMKV.Checked = true;
            this.radioButtonMKV.Name = "radioButtonMKV";
            this.radioButtonMKV.TabStop = true;
            this.radioButtonMKV.UseVisualStyleBackColor = true;
            this.radioButtonMKV.CheckedChanged += new System.EventHandler(this.radioButtonMKV_CheckedChanged);
            // 
            // labelTextBoxConv
            // 
            resources.ApplyResources(this.labelTextBoxConv, "labelTextBoxConv");
            this.labelTextBoxConv.Name = "labelTextBoxConv";
            // 
            // labelOutConvFile
            // 
            resources.ApplyResources(this.labelOutConvFile, "labelOutConvFile");
            this.labelOutConvFile.Name = "labelOutConvFile";
            // 
            // labelInputConvFile
            // 
            resources.ApplyResources(this.labelInputConvFile, "labelInputConvFile");
            this.labelInputConvFile.Name = "labelInputConvFile";
            // 
            // buttonAddBatchConv
            // 
            resources.ApplyResources(this.buttonAddBatchConv, "buttonAddBatchConv");
            this.buttonAddBatchConv.Name = "buttonAddBatchConv";
            this.buttonAddBatchConv.UseVisualStyleBackColor = true;
            this.buttonAddBatchConv.Click += new System.EventHandler(this.buttonAddBatchConv_Click);
            // 
            // buttonMultiConvFiles
            // 
            resources.ApplyResources(this.buttonMultiConvFiles, "buttonMultiConvFiles");
            this.buttonMultiConvFiles.AllowDrop = true;
            this.buttonMultiConvFiles.Name = "buttonMultiConvFiles";
            this.buttonMultiConvFiles.UseVisualStyleBackColor = true;
            this.buttonMultiConvFiles.Click += new System.EventHandler(this.buttonMultiConvFiles_Click);
            // 
            // panelConvert
            // 
            resources.ApplyResources(this.panelConvert, "panelConvert");
            this.panelConvert.Controls.Add(this.richTextBoxConv);
            this.panelConvert.Name = "panelConvert";
            // 
            // richTextBoxConv
            // 
            resources.ApplyResources(this.richTextBoxConv, "richTextBoxConv");
            this.richTextBoxConv.Name = "richTextBoxConv";
            // 
            // buttonOutConvFile
            // 
            resources.ApplyResources(this.buttonOutConvFile, "buttonOutConvFile");
            this.buttonOutConvFile.Name = "buttonOutConvFile";
            this.buttonOutConvFile.UseVisualStyleBackColor = true;
            this.buttonOutConvFile.Click += new System.EventHandler(this.buttonOutConvFile_Click);
            // 
            // buttonInputConvFile
            // 
            resources.ApplyResources(this.buttonInputConvFile, "buttonInputConvFile");
            this.buttonInputConvFile.AllowDrop = true;
            this.buttonInputConvFile.Name = "buttonInputConvFile";
            this.buttonInputConvFile.UseVisualStyleBackColor = true;
            this.buttonInputConvFile.Click += new System.EventHandler(this.buttonInputConvFile_Click);
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.panelBatch);
            this.tabPage3.Name = "tabPage3";
            // 
            // panelBatch
            // 
            resources.ApplyResources(this.panelBatch, "panelBatch");
            this.panelBatch.Controls.Add(this.buttonUnselectAll);
            this.panelBatch.Controls.Add(this.buttonSellectAllQueue);
            this.panelBatch.Controls.Add(this.dataGridViewBatch);
            this.panelBatch.Controls.Add(this.buttonDeleteQueue);
            this.panelBatch.Controls.Add(this.buttonCancelBatch);
            this.panelBatch.Controls.Add(this.buttonStartQueue);
            this.panelBatch.Name = "panelBatch";
            // 
            // buttonUnselectAll
            // 
            resources.ApplyResources(this.buttonUnselectAll, "buttonUnselectAll");
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.UseVisualStyleBackColor = true;
            this.buttonUnselectAll.Click += new System.EventHandler(this.buttonUnselectAll_Click);
            // 
            // buttonSellectAllQueue
            // 
            resources.ApplyResources(this.buttonSellectAllQueue, "buttonSellectAllQueue");
            this.buttonSellectAllQueue.Name = "buttonSellectAllQueue";
            this.buttonSellectAllQueue.UseVisualStyleBackColor = true;
            this.buttonSellectAllQueue.Click += new System.EventHandler(this.buttonSellectAllQueue_Click);
            // 
            // dataGridViewBatch
            // 
            resources.ApplyResources(this.dataGridViewBatch, "dataGridViewBatch");
            this.dataGridViewBatch.AllowUserToAddRows = false;
            this.dataGridViewBatch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBatch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_cell,
            this.no_cell,
            this.task_cell});
            this.dataGridViewBatch.Name = "dataGridViewBatch";
            this.dataGridViewBatch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // check_cell
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            this.check_cell.DefaultCellStyle = dataGridViewCellStyle2;
            this.check_cell.Frozen = true;
            resources.ApplyResources(this.check_cell, "check_cell");
            this.check_cell.Name = "check_cell";
            this.check_cell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // no_cell
            // 
            this.no_cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.no_cell.Frozen = true;
            resources.ApplyResources(this.no_cell, "no_cell");
            this.no_cell.MaxInputLength = 255;
            this.no_cell.Name = "no_cell";
            this.no_cell.ReadOnly = true;
            this.no_cell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no_cell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // task_cell
            // 
            this.task_cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.task_cell, "task_cell");
            this.task_cell.Name = "task_cell";
            this.task_cell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // buttonDeleteQueue
            // 
            resources.ApplyResources(this.buttonDeleteQueue, "buttonDeleteQueue");
            this.buttonDeleteQueue.Name = "buttonDeleteQueue";
            this.buttonDeleteQueue.UseVisualStyleBackColor = true;
            this.buttonDeleteQueue.Click += new System.EventHandler(this.buttonDeleteQueue_Click);
            // 
            // buttonCancelBatch
            // 
            resources.ApplyResources(this.buttonCancelBatch, "buttonCancelBatch");
            this.buttonCancelBatch.Name = "buttonCancelBatch";
            this.buttonCancelBatch.UseVisualStyleBackColor = true;
            this.buttonCancelBatch.Click += new System.EventHandler(this.buttonCancelBatch_Click);
            // 
            // buttonStartQueue
            // 
            resources.ApplyResources(this.buttonStartQueue, "buttonStartQueue");
            this.buttonStartQueue.Name = "buttonStartQueue";
            this.buttonStartQueue.UseVisualStyleBackColor = true;
            this.buttonStartQueue.Click += new System.EventHandler(this.buttonStartQueue_Click);
            // 
            // timerBatch
            // 
            this.timerBatch.Interval = 1000;
            this.timerBatch.Tick += new System.EventHandler(this.timerBatch_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxVideoOrAudio.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxAudio.ResumeLayout(false);
            this.groupBoxAudio.PerformLayout();
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            this.panelConvert.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelBatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewBatch;
        private System.Windows.Forms.Button buttonDeleteQueue;
        private System.Windows.Forms.Label labelOutTransFile;
        private System.Windows.Forms.Label labelInputTransFile;
        private System.Windows.Forms.Button buttonOutTransFile;
        private System.Windows.Forms.Button buttonStartQueue;
        private System.Windows.Forms.Timer timerBatch;
        private System.Windows.Forms.Button buttonCancelBatch;
        private System.Windows.Forms.Panel panelTranscode;
        private System.Windows.Forms.Panel panelBatch;
        private System.Windows.Forms.Label labelMultiTransFile;
        private System.Windows.Forms.Button buttonMultiTransFile;
        private System.Windows.Forms.Button buttonAddBatchConv;
        private System.Windows.Forms.Button buttonMultiConvFiles;
        private System.Windows.Forms.Panel panelConvert;
        private System.Windows.Forms.RichTextBox richTextBoxConv;
        private System.Windows.Forms.Button buttonOutConvFile;
        private System.Windows.Forms.Button buttonInputConvFile;
        private System.Windows.Forms.Label labelTextBoxConv;
        private System.Windows.Forms.Label labelOutConvFile;
        private System.Windows.Forms.Label labelInputConvFile;
        private System.Windows.Forms.GroupBox groupBoxAudio;
        private System.Windows.Forms.RadioButton radioButtonMP3;
        private System.Windows.Forms.RadioButton radioButtonAAC;
        private System.Windows.Forms.GroupBox groupBoxContainer;
        private System.Windows.Forms.RadioButton radioButtonMP4;
        private System.Windows.Forms.RadioButton radioButtonMKV;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.ComboBox comboBoxAudioBitRate;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.RadioButton radioButtonCopyAudio;
        private System.Windows.Forms.RadioButton radioButtonCopyVideo;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonSellectAllQueue;
        private System.Windows.Forms.Button buttonUnselectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_cell;
        private System.Windows.Forms.GroupBox groupBoxVideoOrAudio;
        private System.Windows.Forms.CheckBox checkBoxAudioOnly;
        private System.Windows.Forms.CheckBox checkBoxVideoOnly;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelInputConv;
        private System.Windows.Forms.Label labelMultiConv;
        private System.Windows.Forms.Button buttonRemoveSubtitle;
        private System.Windows.Forms.Label labelAddSubtitle;
        private System.Windows.Forms.Button buttonAddSubtitle;

    }
}

