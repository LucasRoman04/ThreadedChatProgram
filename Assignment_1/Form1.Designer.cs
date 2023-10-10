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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendButton = new System.Windows.Forms.Button();
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.conversationGroupBox = new System.Windows.Forms.GroupBox();
            this.convTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.messageGroupBox.SuspendLayout();
            this.conversationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gameLabel.Location = new System.Drawing.Point(12, 24);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(944, 307);
            this.gameLabel.TabIndex = 1;
            this.gameLabel.Text = "Game Goes Here";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(843, 28);
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
            this.messageGroupBox.Location = new System.Drawing.Point(19, 345);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Size = new System.Drawing.Size(924, 64);
            this.messageGroupBox.TabIndex = 6;
            this.messageGroupBox.TabStop = false;
            this.messageGroupBox.Text = "Type your messages here.";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(6, 30);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(818, 20);
            this.messageTextBox.TabIndex = 4;
            // 
            // conversationGroupBox
            // 
            this.conversationGroupBox.Controls.Add(this.convTextBox);
            this.conversationGroupBox.Location = new System.Drawing.Point(19, 425);
            this.conversationGroupBox.Name = "conversationGroupBox";
            this.conversationGroupBox.Size = new System.Drawing.Size(924, 304);
            this.conversationGroupBox.TabIndex = 7;
            this.conversationGroupBox.TabStop = false;
            this.conversationGroupBox.Text = "Conversation";
            // 
            // convTextBox
            // 
            this.convTextBox.Location = new System.Drawing.Point(7, 20);
            this.convTextBox.Multiline = true;
            this.convTextBox.Name = "convTextBox";
            this.convTextBox.Size = new System.Drawing.Size(911, 278);
            this.convTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 741);
            this.Controls.Add(this.conversationGroupBox);
            this.Controls.Add(this.messageGroupBox);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Network Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.messageGroupBox.ResumeLayout(false);
            this.messageGroupBox.PerformLayout();
            this.conversationGroupBox.ResumeLayout(false);
            this.conversationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.GroupBox conversationGroupBox;
        private System.Windows.Forms.TextBox convTextBox;
    }
}

