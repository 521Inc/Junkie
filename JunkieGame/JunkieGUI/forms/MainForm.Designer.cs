﻿namespace JunkieGUI.forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainMenuCtrl = new JunkieGUI.controls.MainMenuCtrl();
            this.SuspendLayout();
            // 
            // mainMenuCtrl
            // 
            this.mainMenuCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuCtrl.Location = new System.Drawing.Point(0, 0);
            this.mainMenuCtrl.Name = "mainMenuCtrl";
            this.mainMenuCtrl.Size = new System.Drawing.Size(420, 318);
            this.mainMenuCtrl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 318);
            this.Controls.Add(this.mainMenuCtrl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MainMenuCtrl mainMenuCtrl;
    }
}