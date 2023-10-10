namespace Assignment_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.convGroupBox = new System.Windows.Forms.GroupBox();
            this.convTextBox = new System.Windows.Forms.TextBox();
            this.serverMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.messageGroupBox.SuspendLayout();
            this.convGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuOption});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuOption,
            this.disconnectMenuOption,
            this.serverMenuOption,
            this.clientMenuOption});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // exitMenuOption
            // 
            this.exitMenuOption.Name = "exitMenuOption";
            this.exitMenuOption.Size = new System.Drawing.Size(180, 22);
            this.exitMenuOption.Text = "Exit";
            // 
            // connectMenuOption
            // 
            this.connectMenuOption.Name = "connectMenuOption";
            this.connectMenuOption.Size = new System.Drawing.Size(180, 22);
            this.connectMenuOption.Text = "Connect";
            // 
            // disconnectMenuOption
            // 
            this.disconnectMenuOption.Name = "disconnectMenuOption";
            this.disconnectMenuOption.Size = new System.Drawing.Size(180, 22);
            this.disconnectMenuOption.Text = "Disconnect";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(774, 28);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // messageGroupBox
            // 
            this.messageGroupBox.Controls.Add(this.messageTextBox);
            this.messageGroupBox.Controls.Add(this.sendButton);
            this.messageGroupBox.Location = new System.Drawing.Point(12, 37);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Size = new System.Drawing.Size(858, 64);
            this.messageGroupBox.TabIndex = 6;
            this.messageGroupBox.TabStop = false;
            this.messageGroupBox.Text = "Type your messages here.";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(6, 30);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(762, 20);
            this.messageTextBox.TabIndex = 4;
            // 
            // convGroupBox
            // 
            this.convGroupBox.Controls.Add(this.convTextBox);
            this.convGroupBox.Location = new System.Drawing.Point(12, 117);
            this.convGroupBox.Name = "convGroupBox";
            this.convGroupBox.Size = new System.Drawing.Size(858, 304);
            this.convGroupBox.TabIndex = 7;
            this.convGroupBox.TabStop = false;
            this.convGroupBox.Text = "Conversation";
            // 
            // convTextBox
            // 
            this.convTextBox.Location = new System.Drawing.Point(7, 20);
            this.convTextBox.Multiline = true;
            this.convTextBox.Name = "convTextBox";
            this.convTextBox.Size = new System.Drawing.Size(845, 278);
            this.convTextBox.TabIndex = 0;
            // 
            // serverMenuOption
            // 
            this.serverMenuOption.Name = "serverMenuOption";
            this.serverMenuOption.Size = new System.Drawing.Size(180, 22);
            this.serverMenuOption.Text = "Server";
            // 
            // clientMenuOption
            // 
            this.clientMenuOption.Name = "clientMenuOption";
            this.clientMenuOption.Size = new System.Drawing.Size(180, 22);
            this.clientMenuOption.Text = "Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 453);
            this.Controls.Add(this.convGroupBox);
            this.Controls.Add(this.messageGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Network Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.messageGroupBox.ResumeLayout(false);
            this.messageGroupBox.PerformLayout();
            this.convGroupBox.ResumeLayout(false);
            this.convGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuOption;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuOption;
        private System.Windows.Forms.ToolStripMenuItem disconnectMenuOption;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.GroupBox convGroupBox;
        private System.Windows.Forms.TextBox convTextBox;
        private System.Windows.Forms.ToolStripMenuItem serverMenuOption;
        private System.Windows.Forms.ToolStripMenuItem clientMenuOption;
    }
}

