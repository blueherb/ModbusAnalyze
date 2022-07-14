
namespace AnalyzeModbus
{
    partial class ModbusTcpForm
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
            this.tbTcpIpAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTcpPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTcpIpAddress
            // 
            this.tbTcpIpAddress.AllowDrop = true;
            this.tbTcpIpAddress.Font = new System.Drawing.Font("굴림", 9F);
            this.tbTcpIpAddress.Location = new System.Drawing.Point(140, 39);
            this.tbTcpIpAddress.MaxLength = 15;
            this.tbTcpIpAddress.Name = "tbTcpIpAddress";
            this.tbTcpIpAddress.Size = new System.Drawing.Size(117, 21);
            this.tbTcpIpAddress.TabIndex = 0;
            this.tbTcpIpAddress.TextChanged += new System.EventHandler(this.Tb_Changed);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("굴림", 9F);
            this.btnConnect.Location = new System.Drawing.Point(90, 145);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 26);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "연결하기";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "서버 IP 주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "포트 번호";
            // 
            // tbTcpPort
            // 
            this.tbTcpPort.Font = new System.Drawing.Font("굴림", 9F);
            this.tbTcpPort.Location = new System.Drawing.Point(140, 96);
            this.tbTcpPort.MaxLength = 5;
            this.tbTcpPort.Name = "tbTcpPort";
            this.tbTcpPort.Size = new System.Drawing.Size(117, 21);
            this.tbTcpPort.TabIndex = 1;
            this.tbTcpPort.TextChanged += new System.EventHandler(this.Tb_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTcpIpAddress);
            this.groupBox1.Controls.Add(this.tbTcpPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버 정보";
            // 
            // ModbusTcpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(308, 204);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModbusTcpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModbusTCP 연결";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModbusTcpForm_Close);
            this.Load += new System.EventHandler(this.ModbusTcpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTcpIpAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTcpPort;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}