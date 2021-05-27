
namespace obs_control
{
    partial class b
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Camera 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Camera 2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Camera 3");
            this.btnToggleStream = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTimeLastTransition = new System.Windows.Forms.Label();
            this.lblTimeTotal = new System.Windows.Forms.Label();
            this.lblLastTransition = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rdbtnCamera3 = new System.Windows.Forms.RadioButton();
            this.rdbtnCamera2 = new System.Windows.Forms.RadioButton();
            this.rdbtnCamera1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chklbSceneSelection = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbxSerialRemotePort = new System.Windows.Forms.TextBox();
            this.txtbxOBSserver = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOBSServer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleStream
            // 
            this.btnToggleStream.Location = new System.Drawing.Point(6, 22);
            this.btnToggleStream.Name = "btnToggleStream";
            this.btnToggleStream.Size = new System.Drawing.Size(61, 23);
            this.btnToggleStream.TabIndex = 1;
            this.btnToggleStream.Text = "Stream";
            this.btnToggleStream.UseVisualStyleBackColor = true;
            this.btnToggleStream.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimeLastTransition);
            this.groupBox1.Controls.Add(this.lblTimeTotal);
            this.groupBox1.Controls.Add(this.lblLastTransition);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnToggleStream);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broadcast";
            // 
            // lblTimeLastTransition
            // 
            this.lblTimeLastTransition.AutoSize = true;
            this.lblTimeLastTransition.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLastTransition.Location = new System.Drawing.Point(233, 42);
            this.lblTimeLastTransition.Name = "lblTimeLastTransition";
            this.lblTimeLastTransition.Size = new System.Drawing.Size(112, 32);
            this.lblTimeLastTransition.TabIndex = 8;
            this.lblTimeLastTransition.Text = "00:00:00";
            // 
            // lblTimeTotal
            // 
            this.lblTimeTotal.AutoSize = true;
            this.lblTimeTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeTotal.Location = new System.Drawing.Point(233, 11);
            this.lblTimeTotal.Name = "lblTimeTotal";
            this.lblTimeTotal.Size = new System.Drawing.Size(112, 32);
            this.lblTimeTotal.TabIndex = 7;
            this.lblTimeTotal.Text = "00:00:00";
            // 
            // lblLastTransition
            // 
            this.lblLastTransition.AutoSize = true;
            this.lblLastTransition.Location = new System.Drawing.Point(115, 56);
            this.lblLastTransition.Name = "lblLastTransition";
            this.lblLastTransition.Size = new System.Drawing.Size(122, 15);
            this.lblLastTransition.TabIndex = 4;
            this.lblLastTransition.Text = "Time (Last Transition):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(165, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Time (Total):";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cameras";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 352);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(223, 9);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 15;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(223, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(223, 121);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(223, 177);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(123, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "→";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(11, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "←";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(67, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = " ↓";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(67, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = " ↑";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(67, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 4;
            this.button6.Text = " HOLD";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.rdbtnCamera3);
            this.tabPage2.Controls.Add(this.rdbtnCamera2);
            this.tabPage2.Controls.Add(this.rdbtnCamera1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(6, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 237);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "trcCamera1Speaker";
            treeNode2.Text = "Camera 1";
            treeNode3.Name = "trnCamera2";
            treeNode3.Text = "Camera 2";
            treeNode4.Name = "trnCamera3";
            treeNode4.Text = "Camera 3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 10;
            // 
            // rdbtnCamera3
            // 
            this.rdbtnCamera3.AutoSize = true;
            this.rdbtnCamera3.Location = new System.Drawing.Point(6, 56);
            this.rdbtnCamera3.Name = "rdbtnCamera3";
            this.rdbtnCamera3.Size = new System.Drawing.Size(75, 19);
            this.rdbtnCamera3.TabIndex = 2;
            this.rdbtnCamera3.Text = "Camera 3";
            this.rdbtnCamera3.UseVisualStyleBackColor = true;
            this.rdbtnCamera3.CheckedChanged += new System.EventHandler(this.rdbtnCamera3_CheckedChanged);
            // 
            // rdbtnCamera2
            // 
            this.rdbtnCamera2.AutoSize = true;
            this.rdbtnCamera2.Location = new System.Drawing.Point(6, 31);
            this.rdbtnCamera2.Name = "rdbtnCamera2";
            this.rdbtnCamera2.Size = new System.Drawing.Size(75, 19);
            this.rdbtnCamera2.TabIndex = 1;
            this.rdbtnCamera2.Text = "Camera 2";
            this.rdbtnCamera2.UseVisualStyleBackColor = true;
            // 
            // rdbtnCamera1
            // 
            this.rdbtnCamera1.AutoSize = true;
            this.rdbtnCamera1.Checked = true;
            this.rdbtnCamera1.Location = new System.Drawing.Point(6, 6);
            this.rdbtnCamera1.Name = "rdbtnCamera1";
            this.rdbtnCamera1.Size = new System.Drawing.Size(75, 19);
            this.rdbtnCamera1.TabIndex = 0;
            this.rdbtnCamera1.TabStop = true;
            this.rdbtnCamera1.Text = "Camera 1";
            this.rdbtnCamera1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chklbSceneSelection);
            this.groupBox3.Location = new System.Drawing.Point(632, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 380);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio";
            // 
            // chklbSceneSelection
            // 
            this.chklbSceneSelection.FormattingEnabled = true;
            this.chklbSceneSelection.Location = new System.Drawing.Point(6, 22);
            this.chklbSceneSelection.Name = "chklbSceneSelection";
            this.chklbSceneSelection.Size = new System.Drawing.Size(292, 346);
            this.chklbSceneSelection.TabIndex = 0;
            this.chklbSceneSelection.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbxSerialRemotePort);
            this.groupBox4.Controls.Add(this.txtbxOBSserver);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnOBSServer);
            this.groupBox4.Location = new System.Drawing.Point(369, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 85);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connections";
            // 
            // txtbxSerialRemotePort
            // 
            this.txtbxSerialRemotePort.Location = new System.Drawing.Point(104, 51);
            this.txtbxSerialRemotePort.Name = "txtbxSerialRemotePort";
            this.txtbxSerialRemotePort.Size = new System.Drawing.Size(106, 23);
            this.txtbxSerialRemotePort.TabIndex = 3;
            this.txtbxSerialRemotePort.Text = "COM PORT";
            // 
            // txtbxOBSserver
            // 
            this.txtbxOBSserver.Location = new System.Drawing.Point(104, 22);
            this.txtbxOBSserver.Name = "txtbxOBSserver";
            this.txtbxOBSserver.Size = new System.Drawing.Size(106, 23);
            this.txtbxOBSserver.TabIndex = 2;
            this.txtbxOBSserver.Text = "IP:PORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Serial Remote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOBSServer
            // 
            this.btnOBSServer.Location = new System.Drawing.Point(6, 22);
            this.btnOBSServer.Name = "btnOBSServer";
            this.btnOBSServer.Size = new System.Drawing.Size(92, 23);
            this.btnOBSServer.TabIndex = 0;
            this.btnOBSServer.Text = "OBS Server";
            this.btnOBSServer.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Location = new System.Drawing.Point(322, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 380);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Scenes";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Chyron",
            "Subtitles",
            "Music Title"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(292, 346);
            this.checkedListBox1.TabIndex = 0;
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 556);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "b";
            this.Text = "OBS Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToggleStream;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLastTransition;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOBSServer;
        private System.Windows.Forms.TextBox txtbxSerialRemotePort;
        private System.Windows.Forms.TextBox txtbxOBSserver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimeLastTransition;
        private System.Windows.Forms.Label lblTimeTotal;
        private System.Windows.Forms.CheckedListBox chklbSceneSelection;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton rdbtnCamera2;
        private System.Windows.Forms.RadioButton rdbtnCamera1;
        private System.Windows.Forms.RadioButton rdbtnCamera3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

