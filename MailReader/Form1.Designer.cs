
using System;

namespace MailReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgdffffffffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggdfggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggdggdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(-2, 1);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.display.Size = new System.Drawing.Size(349, 424);
            this.display.TabIndex = 2;
            this.display.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgdffffffffToolStripMenuItem,
            this.ggdfggToolStripMenuItem,
            this.ggdggdgToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // dgdffffffffToolStripMenuItem
            // 
            this.dgdffffffffToolStripMenuItem.Name = "dgdffffffffToolStripMenuItem";
            this.dgdffffffffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dgdffffffffToolStripMenuItem.Text = "dgdffffffff";
            // 
            // ggdfggToolStripMenuItem
            // 
            this.ggdfggToolStripMenuItem.Name = "ggdfggToolStripMenuItem";
            this.ggdfggToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ggdfggToolStripMenuItem.Text = "ggdfgg";
            // 
            // ggdggdgToolStripMenuItem
            // 
            this.ggdggdgToolStripMenuItem.Name = "ggdggdgToolStripMenuItem";
            this.ggdggdgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ggdggdgToolStripMenuItem.Text = "ggdggdg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 424);
            this.Controls.Add(this.display);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MailReader";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dgdffffffffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggdfggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggdggdgToolStripMenuItem;
    }
}

