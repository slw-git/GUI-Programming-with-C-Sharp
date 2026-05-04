namespace Hello_World {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            this.txtName = new TextBox();
            buttonGreet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 204);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(193, 201);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(150, 31);
            this.txtName.TabIndex = 1;
            // 
            // buttonGreet
            // 
            buttonGreet.Location = new Point(361, 201);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Size = new Size(112, 34);
            buttonGreet.TabIndex = 2;
            buttonGreet.Text = "Greet";
            buttonGreet.UseVisualStyleBackColor = true;
            buttonGreet.Click += buttonGreet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGreet);
            Controls.Add(this.txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button buttonGreet;
    }
}
