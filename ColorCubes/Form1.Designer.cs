
namespace SandBoxProjects
{
    partial class MainForm
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
            this.lblPos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ColorDefault = new System.Windows.Forms.Button();
            this.ColorsLabel = new System.Windows.Forms.Label();
            this.ColorSwap = new System.Windows.Forms.Button();
            this.ColorHalf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(13, 13);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(0, 13);
            this.lblPos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 435);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(720, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 435);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 1);
            this.panel4.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExitButton.Location = new System.Drawing.Point(699, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(17, 16);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ColorDefault
            // 
            this.ColorDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorDefault.ForeColor = System.Drawing.Color.White;
            this.ColorDefault.Location = new System.Drawing.Point(699, 28);
            this.ColorDefault.Name = "ColorDefault";
            this.ColorDefault.Size = new System.Drawing.Size(17, 17);
            this.ColorDefault.TabIndex = 7;
            this.ColorDefault.UseVisualStyleBackColor = true;
            this.ColorDefault.Click += new System.EventHandler(this.ColorDefault_Click);
            // 
            // ColorsLabel
            // 
            this.ColorsLabel.AutoSize = true;
            this.ColorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorsLabel.Location = new System.Drawing.Point(5, 4);
            this.ColorsLabel.Name = "ColorsLabel";
            this.ColorsLabel.Size = new System.Drawing.Size(10, 13);
            this.ColorsLabel.TabIndex = 8;
            this.ColorsLabel.Text = "-";
            // 
            // ColorSwap
            // 
            this.ColorSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColorSwap.Location = new System.Drawing.Point(699, 47);
            this.ColorSwap.Name = "ColorSwap";
            this.ColorSwap.Size = new System.Drawing.Size(17, 17);
            this.ColorSwap.TabIndex = 9;
            this.ColorSwap.UseVisualStyleBackColor = true;
            this.ColorSwap.Click += new System.EventHandler(this.ColorRed_Click);
            // 
            // ColorHalf
            // 
            this.ColorHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorHalf.ForeColor = System.Drawing.Color.Lime;
            this.ColorHalf.Location = new System.Drawing.Point(699, 66);
            this.ColorHalf.Name = "ColorHalf";
            this.ColorHalf.Size = new System.Drawing.Size(17, 17);
            this.ColorHalf.TabIndex = 10;
            this.ColorHalf.UseVisualStyleBackColor = true;
            this.ColorHalf.Click += new System.EventHandler(this.Color_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(721, 436);
            this.Controls.Add(this.ColorHalf);
            this.Controls.Add(this.ColorSwap);
            this.Controls.Add(this.ColorsLabel);
            this.Controls.Add(this.ColorDefault);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ColorDefault;
        private System.Windows.Forms.Label ColorsLabel;
        private System.Windows.Forms.Button ColorSwap;
        private System.Windows.Forms.Button ColorHalf;
    }
}

