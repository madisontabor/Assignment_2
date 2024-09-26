using System.Drawing;

namespace Assignment_2
{
    partial class Assignment_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment_2));
            this.lstMakeAndModel = new System.Windows.Forms.ListBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMakeAndModel = new System.Windows.Forms.Label();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.rbtnBlack = new System.Windows.Forms.RadioButton();
            this.rbtnSilver = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.grpFeatures = new System.Windows.Forms.GroupBox();
            this.chkPowerWindows = new System.Windows.Forms.CheckBox();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.chkSiriusRadio = new System.Windows.Forms.CheckBox();
            this.chkLaneAssistance = new System.Windows.Forms.CheckBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblPurchaseSummary = new System.Windows.Forms.Label();
            this.grpColors.SuspendLayout();
            this.grpFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMakeAndModel
            // 
            resources.ApplyResources(this.lstMakeAndModel, "lstMakeAndModel");
            this.lstMakeAndModel.FormattingEnabled = true;
            this.lstMakeAndModel.Name = "lstMakeAndModel";
            // 
            // tbxYear
            // 
            resources.ApplyResources(this.tbxYear, "tbxYear");
            this.tbxYear.Name = "tbxYear";
            // 
            // lblYear
            // 
            resources.ApplyResources(this.lblYear, "lblYear");
            this.lblYear.Name = "lblYear";
            // 
            // lblMakeAndModel
            // 
            resources.ApplyResources(this.lblMakeAndModel, "lblMakeAndModel");
            this.lblMakeAndModel.Name = "lblMakeAndModel";
            // 
            // grpColors
            // 
            resources.ApplyResources(this.grpColors, "grpColors");
            this.grpColors.Controls.Add(this.rbtnBlack);
            this.grpColors.Controls.Add(this.rbtnSilver);
            this.grpColors.Controls.Add(this.rbtnBlue);
            this.grpColors.Controls.Add(this.rbtnRed);
            this.grpColors.Name = "grpColors";
            this.grpColors.TabStop = false;
            // 
            // rbtnBlack
            // 
            resources.ApplyResources(this.rbtnBlack, "rbtnBlack");
            this.rbtnBlack.Name = "rbtnBlack";
            this.rbtnBlack.TabStop = true;
            this.rbtnBlack.UseVisualStyleBackColor = true;
            // 
            // rbtnSilver
            // 
            resources.ApplyResources(this.rbtnSilver, "rbtnSilver");
            this.rbtnSilver.Name = "rbtnSilver";
            this.rbtnSilver.TabStop = true;
            this.rbtnSilver.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            resources.ApplyResources(this.rbtnBlue, "rbtnBlue");
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            resources.ApplyResources(this.rbtnRed, "rbtnRed");
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.TabStop = true;
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // grpFeatures
            // 
            resources.ApplyResources(this.grpFeatures, "grpFeatures");
            this.grpFeatures.Controls.Add(this.chkPowerWindows);
            this.grpFeatures.Controls.Add(this.chkAC);
            this.grpFeatures.Controls.Add(this.chkSiriusRadio);
            this.grpFeatures.Controls.Add(this.chkLaneAssistance);
            this.grpFeatures.Name = "grpFeatures";
            this.grpFeatures.TabStop = false;
            // 
            // chkPowerWindows
            // 
            resources.ApplyResources(this.chkPowerWindows, "chkPowerWindows");
            this.chkPowerWindows.Name = "chkPowerWindows";
            this.chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            resources.ApplyResources(this.chkAC, "chkAC");
            this.chkAC.Name = "chkAC";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // chkSiriusRadio
            // 
            resources.ApplyResources(this.chkSiriusRadio, "chkSiriusRadio");
            this.chkSiriusRadio.Name = "chkSiriusRadio";
            this.chkSiriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkLaneAssistance
            // 
            resources.ApplyResources(this.chkLaneAssistance, "chkLaneAssistance");
            this.chkLaneAssistance.Name = "chkLaneAssistance";
            this.chkLaneAssistance.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            resources.ApplyResources(this.btnPurchase, "btnPurchase");
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // lblPurchaseSummary
            // 
            this.lblPurchaseSummary.AutoSize = true;
            this.lblPurchaseSummary.Location = new System.Drawing.Point(200, 300);
            this.lblPurchaseSummary.ForeColor = System.Drawing.Color.Black;
            this.lblPurchaseSummary.Name = "lblPurchaseSummary";
            // 
            // Assignment_2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPurchaseSummary);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.grpFeatures);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.lblMakeAndModel);
            this.Controls.Add(this.lstMakeAndModel);
            this.Name = "Assignment_2";
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpFeatures.ResumeLayout(false);
            this.grpFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMakeAndModel;
        private System.Windows.Forms.Label lblMakeAndModel;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton rbtnBlack;
        private System.Windows.Forms.RadioButton rbtnSilver;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnRed; 
        private System.Windows.Forms.GroupBox grpFeatures;
        private System.Windows.Forms.CheckBox chkPowerWindows;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.CheckBox chkSiriusRadio;
        private System.Windows.Forms.CheckBox chkLaneAssistance;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblPurchaseSummary;
    }
}

