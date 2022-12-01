namespace Tannenbaum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.widthlabel = new System.Windows.Forms.Label();
            this.trunkheight = new System.Windows.Forms.Label();
            this.crownheight = new System.Windows.Forms.Label();
            this.execute = new System.Windows.Forms.Button();
            this.drawingoutput = new System.Windows.Forms.TextBox();
            this.widthinput = new System.Windows.Forms.NumericUpDown();
            this.trunkheightinput = new System.Windows.Forms.NumericUpDown();
            this.crownheightinput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkheightinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownheightinput)).BeginInit();
            this.SuspendLayout();
            // 
            // widthlabel
            // 
            this.widthlabel.AutoSize = true;
            this.widthlabel.Location = new System.Drawing.Point(26, 31);
            this.widthlabel.Name = "widthlabel";
            this.widthlabel.Size = new System.Drawing.Size(75, 15);
            this.widthlabel.TabIndex = 0;
            this.widthlabel.Text = "Stammbreite";
            // 
            // trunkheight
            // 
            this.trunkheight.AutoSize = true;
            this.trunkheight.Location = new System.Drawing.Point(23, 60);
            this.trunkheight.Name = "trunkheight";
            this.trunkheight.Size = new System.Drawing.Size(78, 15);
            this.trunkheight.TabIndex = 1;
            this.trunkheight.Text = "Stammhoehe";
            // 
            // crownheight
            // 
            this.crownheight.AutoSize = true;
            this.crownheight.Location = new System.Drawing.Point(23, 90);
            this.crownheight.Name = "crownheight";
            this.crownheight.Size = new System.Drawing.Size(78, 15);
            this.crownheight.TabIndex = 2;
            this.crownheight.Text = "Kronenhoehe";
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(239, 87);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(130, 23);
            this.execute.TabIndex = 6;
            this.execute.Text = "Tanne zeichnen";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // drawingoutput
            // 
            this.drawingoutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawingoutput.Location = new System.Drawing.Point(23, 127);
            this.drawingoutput.Multiline = true;
            this.drawingoutput.Name = "drawingoutput";
            this.drawingoutput.Size = new System.Drawing.Size(346, 311);
            this.drawingoutput.TabIndex = 7;
            // 
            // widthinput
            // 
            this.widthinput.Location = new System.Drawing.Point(107, 29);
            this.widthinput.Name = "widthinput";
            this.widthinput.Size = new System.Drawing.Size(120, 23);
            this.widthinput.TabIndex = 8;
            // 
            // trunkheightinput
            // 
            this.trunkheightinput.Location = new System.Drawing.Point(107, 58);
            this.trunkheightinput.Name = "trunkheightinput";
            this.trunkheightinput.Size = new System.Drawing.Size(120, 23);
            this.trunkheightinput.TabIndex = 9;
            // 
            // crownheightinput
            // 
            this.crownheightinput.Location = new System.Drawing.Point(107, 87);
            this.crownheightinput.Name = "crownheightinput";
            this.crownheightinput.Size = new System.Drawing.Size(120, 23);
            this.crownheightinput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.crownheightinput);
            this.Controls.Add(this.trunkheightinput);
            this.Controls.Add(this.widthinput);
            this.Controls.Add(this.drawingoutput);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.crownheight);
            this.Controls.Add(this.trunkheight);
            this.Controls.Add(this.widthlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.widthinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkheightinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownheightinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label widthlabel;
        private Label trunkheight;
        private Label crownheight;
        private Button execute;
        private TextBox drawingoutput;
        private NumericUpDown widthinput;
        private NumericUpDown trunkheightinput;
        private NumericUpDown crownheightinput;
    }
}