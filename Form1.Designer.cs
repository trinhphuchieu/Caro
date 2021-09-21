
using System.Drawing;
using System.Windows.Forms;

namespace Caro_TrinhPhucHieu
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
            this.batdau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.winO = new System.Windows.Forms.Label();
            this.thoigianO = new System.Windows.Forms.Label();
            this.undo0 = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.winX = new System.Windows.Forms.Label();
            this.undoX = new System.Windows.Forms.Button();
            this.thoigianX = new System.Windows.Forms.Label();
            this.BanCoCaro = new System.Windows.Forms.FlowLayoutPanel();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.timerO = new System.Windows.Forms.Timer(this.components);
            this.thoiGianThang = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // batdau
            // 
            this.batdau.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.batdau.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batdau.ForeColor = System.Drawing.SystemColors.Desktop;
            this.batdau.Location = new System.Drawing.Point(6, 6);
            this.batdau.Name = "batdau";
            this.batdau.Size = new System.Drawing.Size(254, 65);
            this.batdau.TabIndex = 1;
            this.batdau.TabStop = false;
            this.batdau.Text = "BẮT ĐẦU";
            this.batdau.UseVisualStyleBackColor = false;
            this.batdau.Click += new System.EventHandler(this.batdau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Xoa);
            this.panel1.Controls.Add(this.batdau);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(696, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 670);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.winO);
            this.groupBox2.Controls.Add(this.thoigianO);
            this.groupBox2.Controls.Add(this.undo0);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 241);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bạn 0";
            // 
            // winO
            // 
            this.winO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.winO.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.winO.Location = new System.Drawing.Point(17, 153);
            this.winO.Name = "winO";
            this.winO.Size = new System.Drawing.Size(225, 55);
            this.winO.TabIndex = 15;
            this.winO.Text = "Win 0 / 0 Ván";
            this.winO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thoigianO
            // 
            this.thoigianO.BackColor = System.Drawing.Color.Snow;
            this.thoigianO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.thoigianO.Location = new System.Drawing.Point(17, 28);
            this.thoigianO.Name = "thoigianO";
            this.thoigianO.Size = new System.Drawing.Size(225, 55);
            this.thoigianO.TabIndex = 9;
            this.thoigianO.Text = "00:00";
            this.thoigianO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undo0
            // 
            this.undo0.Font = new System.Drawing.Font("Arial", 15.8F, System.Drawing.FontStyle.Bold);
            this.undo0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.undo0.Location = new System.Drawing.Point(17, 91);
            this.undo0.Name = "undo0";
            this.undo0.Size = new System.Drawing.Size(225, 55);
            this.undo0.TabIndex = 3;
            this.undo0.TabStop = false;
            this.undo0.Text = "Lui Lại";
            this.undo0.UseVisualStyleBackColor = true;
            this.undo0.Click += new System.EventHandler(this.undo0_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.Info;
            this.Xoa.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Xoa.Location = new System.Drawing.Point(6, 77);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(254, 65);
            this.Xoa.TabIndex = 2;
            this.Xoa.TabStop = false;
            this.Xoa.Text = "XÓA";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.winX);
            this.groupBox1.Controls.Add(this.undoX);
            this.groupBox1.Controls.Add(this.thoigianX);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(6, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 241);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn X";
            // 
            // winX
            // 
            this.winX.BackColor = System.Drawing.Color.Gainsboro;
            this.winX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.winX.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.winX.Location = new System.Drawing.Point(17, 158);
            this.winX.Name = "winX";
            this.winX.Size = new System.Drawing.Size(231, 55);
            this.winX.TabIndex = 14;
            this.winX.Text = "Win 0 / 0 Ván";
            this.winX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undoX
            // 
            this.undoX.BackColor = System.Drawing.Color.Gainsboro;
            this.undoX.Font = new System.Drawing.Font("Arial", 15.8F, System.Drawing.FontStyle.Bold);
            this.undoX.ForeColor = System.Drawing.Color.Red;
            this.undoX.Location = new System.Drawing.Point(17, 94);
            this.undoX.Name = "undoX";
            this.undoX.Size = new System.Drawing.Size(231, 55);
            this.undoX.TabIndex = 4;
            this.undoX.TabStop = false;
            this.undoX.Text = "Lui Lại";
            this.undoX.UseVisualStyleBackColor = false;
            this.undoX.Click += new System.EventHandler(this.undoX_Click);
            // 
            // thoigianX
            // 
            this.thoigianX.BackColor = System.Drawing.Color.Snow;
            this.thoigianX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.thoigianX.Location = new System.Drawing.Point(17, 32);
            this.thoigianX.Name = "thoigianX";
            this.thoigianX.Size = new System.Drawing.Size(231, 55);
            this.thoigianX.TabIndex = 10;
            this.thoigianX.Text = "00:00";
            this.thoigianX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thoigianX.Click += new System.EventHandler(this.thoigianX_Click);
            // 
            // BanCoCaro
            // 
            this.BanCoCaro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BanCoCaro.BackColor = System.Drawing.SystemColors.Control;
            this.BanCoCaro.Location = new System.Drawing.Point(11, 11);
            this.BanCoCaro.Margin = new System.Windows.Forms.Padding(0);
            this.BanCoCaro.Name = "BanCoCaro";
            this.BanCoCaro.Size = new System.Drawing.Size(675, 675);
            this.BanCoCaro.TabIndex = 2;
            // 
            // timerX
            // 
            this.timerX.Interval = 950;
            this.timerX.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // timerO
            // 
            this.timerO.Interval = 950;
            this.timerO.Tick += new System.EventHandler(this.timerO_Tick);
            // 
            // thoiGianThang
            // 
            this.thoiGianThang.Interval = 1000;
            this.thoiGianThang.Tick += new System.EventHandler(this.thoiGianThang_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 693);
            this.Controls.Add(this.BanCoCaro);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro - Phúc Hiếu";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button batdau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel BanCoCaro;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button undo0;
        private System.Windows.Forms.Label thoigianO;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.Timer timerO;
        private Label winO;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label winX;
        private Button undoX;
        private Label thoigianX;
        private Timer thoiGianThang;
    }
}

