﻿namespace MissionPlanner.GCSViews
{
    partial class ConfigREPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigREPL));
            this.TXT_terminal = new System.Windows.Forms.RichTextBox();
            this.BUT_ConnectAPM = new MissionPlanner.Controls.MyButton();
            this.BUT_disconnect = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // TXT_terminal
            // 
            resources.ApplyResources(this.TXT_terminal, "TXT_terminal");
            this.TXT_terminal.AutoWordSelection = true;
            this.TXT_terminal.BackColor = System.Drawing.Color.Black;
            this.TXT_terminal.ForeColor = System.Drawing.Color.White;
            this.TXT_terminal.Name = "TXT_terminal";
            this.TXT_terminal.Click += new System.EventHandler(this.TXT_terminal_Click);
            this.TXT_terminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_terminal_KeyDown);
            this.TXT_terminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_terminal_KeyPress);
            // 
            // BUT_ConnectAPM
            // 
            resources.ApplyResources(this.BUT_ConnectAPM, "BUT_ConnectAPM");
            this.BUT_ConnectAPM.Name = "BUT_ConnectAPM";
            this.BUT_ConnectAPM.UseVisualStyleBackColor = true;
            this.BUT_ConnectAPM.Click += new System.EventHandler(this.BUT_RebootAPM_Click);
            // 
            // BUT_disconnect
            // 
            resources.ApplyResources(this.BUT_disconnect, "BUT_disconnect");
            this.BUT_disconnect.Name = "BUT_disconnect";
            this.BUT_disconnect.UseVisualStyleBackColor = true;
            this.BUT_disconnect.Click += new System.EventHandler(this.BUT_disconnect_Click);
            // 
            // ConfigREPL
            // 
            this.Controls.Add(this.BUT_disconnect);
            this.Controls.Add(this.BUT_ConnectAPM);
            this.Controls.Add(this.TXT_terminal);
            this.Name = "ConfigREPL";
            resources.ApplyResources(this, "$this");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Terminal_FormClosing);
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TXT_terminal;
        private Controls.MyButton BUT_ConnectAPM;
        private Controls.MyButton BUT_disconnect;
    }
}