
namespace tabs
{
    partial class TabUI
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
            this.tabs = new System.Windows.Forms.FlowLayoutPanel();
            this.addtab = new System.Windows.Forms.Button();
            this.Editor = new System.Windows.Forms.RichTextBox();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AutoSize = true;
            this.tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabs.Controls.Add(this.addtab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(800, 29);
            this.tabs.TabIndex = 0;
            // 
            // addtab
            // 
            this.addtab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.addtab.FlatAppearance.BorderSize = 0;
            this.addtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtab.ForeColor = System.Drawing.Color.White;
            this.addtab.Location = new System.Drawing.Point(3, 3);
            this.addtab.Name = "addtab";
            this.addtab.Size = new System.Drawing.Size(23, 23);
            this.addtab.TabIndex = 0;
            this.addtab.Text = "+";
            this.addtab.UseVisualStyleBackColor = false;
            this.addtab.Click += new System.EventHandler(this.addtab_click);
            // 
            // Editor
            // 
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.ForeColor = System.Drawing.Color.White;
            this.Editor.Location = new System.Drawing.Point(0, 29);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(800, 421);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "";
            // 
            // TabUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.tabs);
            this.Name = "TabUI";
            this.Text = "TabUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabUI_FormClosing);
            this.Load += new System.EventHandler(this.TabUI_Load);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tabs;
        private System.Windows.Forms.Button addtab;
        private System.Windows.Forms.RichTextBox Editor;
    }
}

