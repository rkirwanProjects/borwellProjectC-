namespace RoomAreaCalculator
{
    partial class CalculatorForm
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblHeoght = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidthM = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblHeightM = new System.Windows.Forms.Label();
            this.lblLengthM = new System.Windows.Forms.Label();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.lblPaintRequiredOutput = new System.Windows.Forms.Label();
            this.lblRoomVolumeOutput = new System.Windows.Forms.Label();
            this.lblFloorAreaOutput = new System.Windows.Forms.Label();
            this.lblPaintRequired = new System.Windows.Forms.Label();
            this.lblRoomVolume = new System.Windows.Forms.Label();
            this.lblfloorArea = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAssumptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOutputs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(193, 134);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(51, 16);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(186, 175);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(58, 16);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length:";
            // 
            // lblHeoght
            // 
            this.lblHeoght.AutoSize = true;
            this.lblHeoght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeoght.Location = new System.Drawing.Point(187, 220);
            this.lblHeoght.Name = "lblHeoght";
            this.lblHeoght.Size = new System.Drawing.Size(57, 16);
            this.lblHeoght.TabIndex = 2;
            this.lblHeoght.Text = "Height:";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(34, 53);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(509, 32);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Insert the measurments (in metres) of the room to calculate the area and \r\nvolume" +
    " of the room and the amount of paint required to paint all the walls.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(250, 282);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 31);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(250, 133);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // lblWidthM
            // 
            this.lblWidthM.AutoSize = true;
            this.lblWidthM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthM.Location = new System.Drawing.Point(356, 137);
            this.lblWidthM.Name = "lblWidthM";
            this.lblWidthM.Size = new System.Drawing.Size(20, 16);
            this.lblWidthM.TabIndex = 6;
            this.lblWidthM.Text = "m";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(250, 219);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(250, 174);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 8;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // lblHeightM
            // 
            this.lblHeightM.AutoSize = true;
            this.lblHeightM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightM.Location = new System.Drawing.Point(356, 223);
            this.lblHeightM.Name = "lblHeightM";
            this.lblHeightM.Size = new System.Drawing.Size(20, 16);
            this.lblHeightM.TabIndex = 9;
            this.lblHeightM.Text = "m";
            // 
            // lblLengthM
            // 
            this.lblLengthM.AutoSize = true;
            this.lblLengthM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthM.Location = new System.Drawing.Point(356, 178);
            this.lblLengthM.Name = "lblLengthM";
            this.lblLengthM.Size = new System.Drawing.Size(20, 16);
            this.lblLengthM.TabIndex = 10;
            this.lblLengthM.Text = "m";
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.lblPaintRequiredOutput);
            this.grpOutputs.Controls.Add(this.lblRoomVolumeOutput);
            this.grpOutputs.Controls.Add(this.lblFloorAreaOutput);
            this.grpOutputs.Controls.Add(this.lblPaintRequired);
            this.grpOutputs.Controls.Add(this.lblRoomVolume);
            this.grpOutputs.Controls.Add(this.lblfloorArea);
            this.grpOutputs.Location = new System.Drawing.Point(37, 347);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(506, 172);
            this.grpOutputs.TabIndex = 11;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Visible = false;
            // 
            // lblPaintRequiredOutput
            // 
            this.lblPaintRequiredOutput.AutoSize = true;
            this.lblPaintRequiredOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintRequiredOutput.Location = new System.Drawing.Point(210, 137);
            this.lblPaintRequiredOutput.Name = "lblPaintRequiredOutput";
            this.lblPaintRequiredOutput.Size = new System.Drawing.Size(0, 16);
            this.lblPaintRequiredOutput.TabIndex = 5;
            // 
            // lblRoomVolumeOutput
            // 
            this.lblRoomVolumeOutput.AutoSize = true;
            this.lblRoomVolumeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomVolumeOutput.Location = new System.Drawing.Point(210, 87);
            this.lblRoomVolumeOutput.Name = "lblRoomVolumeOutput";
            this.lblRoomVolumeOutput.Size = new System.Drawing.Size(0, 16);
            this.lblRoomVolumeOutput.TabIndex = 4;
            // 
            // lblFloorAreaOutput
            // 
            this.lblFloorAreaOutput.AutoSize = true;
            this.lblFloorAreaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorAreaOutput.Location = new System.Drawing.Point(210, 37);
            this.lblFloorAreaOutput.Name = "lblFloorAreaOutput";
            this.lblFloorAreaOutput.Size = new System.Drawing.Size(0, 16);
            this.lblFloorAreaOutput.TabIndex = 3;
            // 
            // lblPaintRequired
            // 
            this.lblPaintRequired.AutoSize = true;
            this.lblPaintRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintRequired.Location = new System.Drawing.Point(27, 137);
            this.lblPaintRequired.Name = "lblPaintRequired";
            this.lblPaintRequired.Size = new System.Drawing.Size(180, 16);
            this.lblPaintRequired.TabIndex = 2;
            this.lblPaintRequired.Text = "Amount of paint required:";
            // 
            // lblRoomVolume
            // 
            this.lblRoomVolume.AutoSize = true;
            this.lblRoomVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomVolume.Location = new System.Drawing.Point(98, 87);
            this.lblRoomVolume.Name = "lblRoomVolume";
            this.lblRoomVolume.Size = new System.Drawing.Size(109, 16);
            this.lblRoomVolume.TabIndex = 1;
            this.lblRoomVolume.Text = "Room Volume:";
            // 
            // lblfloorArea
            // 
            this.lblfloorArea.AutoSize = true;
            this.lblfloorArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfloorArea.Location = new System.Drawing.Point(117, 37);
            this.lblfloorArea.Name = "lblfloorArea";
            this.lblfloorArea.Size = new System.Drawing.Size(81, 16);
            this.lblfloorArea.TabIndex = 0;
            this.lblfloorArea.Text = "Floor Area";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAssumptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myAssumptionsToolStripMenuItem
            // 
            this.myAssumptionsToolStripMenuItem.Name = "myAssumptionsToolStripMenuItem";
            this.myAssumptionsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.myAssumptionsToolStripMenuItem.Text = "My Assumptions";
            this.myAssumptionsToolStripMenuItem.Click += new System.EventHandler(this.myAssumptionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 537);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.lblLengthM);
            this.Controls.Add(this.lblHeightM);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWidthM);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblHeoght);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Area Calculator";
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblHeoght;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidthM;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblHeightM;
        private System.Windows.Forms.Label lblLengthM;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.Label lblfloorArea;
        private System.Windows.Forms.Label lblPaintRequired;
        private System.Windows.Forms.Label lblRoomVolume;
        private System.Windows.Forms.Label lblPaintRequiredOutput;
        private System.Windows.Forms.Label lblRoomVolumeOutput;
        private System.Windows.Forms.Label lblFloorAreaOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAssumptionsToolStripMenuItem;
    }
}

