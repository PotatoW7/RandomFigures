namespace RandomFigures
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
            components = new System.ComponentModel.Container();
            btnRectangle = new Button();
            btnTriangle = new Button();
            btnCircle = new Button();
            btnStop = new Button();
            timerRec = new System.Windows.Forms.Timer(components);
            timerTri = new System.Windows.Forms.Timer(components);
            timerCir = new System.Windows.Forms.Timer(components);
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(674, 12);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(94, 29);
            btnRectangle.TabIndex = 0;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Location = new Point(674, 47);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(94, 29);
            btnTriangle.TabIndex = 1;
            btnTriangle.Text = "Triangle";
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnCircle
            // 
            btnCircle.Location = new Point(674, 82);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(94, 29);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Circle";
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(674, 127);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop/Res";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // timerRec
            // 
            timerRec.Interval = 1500;
            timerRec.Tick += timerRec_Tick;
            // 
            // timerTri
            // 
            timerTri.Interval = 1500;
            timerTri.Tick += timerTri_Tick;
            // 
            // timerCir
            // 
            timerCir.Interval = 1500;
            timerCir.Tick += timerCir_Tick;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(674, 172);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 29);
            btnClearAll.TabIndex = 4;
            btnClearAll.Text = "Clear";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearAll);
            Controls.Add(btnStop);
            Controls.Add(btnCircle);
            Controls.Add(btnTriangle);
            Controls.Add(btnRectangle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRectangle;
        private Button btnTriangle;
        private Button btnCircle;
        private Button btnStop;
        private System.Windows.Forms.Timer timerRec;
        private System.Windows.Forms.Timer timerTri;
        private System.Windows.Forms.Timer timerCir;
        private Button btnClearAll;
    }
}
