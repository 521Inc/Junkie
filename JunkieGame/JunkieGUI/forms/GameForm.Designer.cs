namespace JunkieGUI.forms {
    partial class GameForm {
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
            this.gameFieldCtrl = new JunkieGame.controls.GameFieldCtrl();
            this.SuspendLayout();
            // 
            // gameFieldCtrl
            // 
            this.gameFieldCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameFieldCtrl.Location = new System.Drawing.Point(0, 0);
            this.gameFieldCtrl.Name = "gameFieldCtrl";
            this.gameFieldCtrl.Size = new System.Drawing.Size(464, 306);
            this.gameFieldCtrl.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 306);
            this.Controls.Add(this.gameFieldCtrl);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private JunkieGame.controls.GameFieldCtrl gameFieldCtrl;
    }
}