namespace DeltixTest2
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.channelsCountLabel = new System.Windows.Forms.Label();
            this.channelsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.senderDataLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalEdit = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clientsCountLabel = new System.Windows.Forms.Label();
            this.clientsList = new System.Windows.Forms.ListBox();
            this.clientsChannelsCountLabel = new System.Windows.Forms.Label();
            this.clientsChannelsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.addClientButton = new System.Windows.Forms.Button();
            this.removeClientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.receiverDataLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.latencyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalEdit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data sender";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.73399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.26601F));
            this.tableLayoutPanel1.Controls.Add(this.channelsCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.channelsList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.928854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.07114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 222);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // channelsCountLabel
            // 
            this.channelsCountLabel.AutoSize = true;
            this.channelsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelsCountLabel.Location = new System.Drawing.Point(3, 0);
            this.channelsCountLabel.Name = "channelsCountLabel";
            this.channelsCountLabel.Size = new System.Drawing.Size(137, 13);
            this.channelsCountLabel.TabIndex = 1;
            this.channelsCountLabel.Text = "Channels:";
            // 
            // channelsList
            // 
            this.channelsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelsList.FormattingEnabled = true;
            this.channelsList.Location = new System.Drawing.Point(3, 16);
            this.channelsList.Name = "channelsList";
            this.channelsList.Size = new System.Drawing.Size(137, 203);
            this.channelsList.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.35714F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.64286F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.senderDataLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.intervalEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(143, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.4058F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(669, 209);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 185);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // senderDataLabel
            // 
            this.senderDataLabel.AutoSize = true;
            this.senderDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderDataLabel.Location = new System.Drawing.Point(105, 24);
            this.senderDataLabel.Name = "senderDataLabel";
            this.senderDataLabel.Size = new System.Drawing.Size(561, 185);
            this.senderDataLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval (ms):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalEdit
            // 
            this.intervalEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.intervalEdit.Enabled = false;
            this.intervalEdit.Location = new System.Drawing.Point(105, 3);
            this.intervalEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.intervalEdit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intervalEdit.Name = "intervalEdit";
            this.intervalEdit.Size = new System.Drawing.Size(108, 20);
            this.intervalEdit.TabIndex = 5;
            this.intervalEdit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data receivers";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.68647F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.31353F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tableLayoutPanel3.Controls.Add(this.clientsCountLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.clientsList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.clientsChannelsCountLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.clientsChannelsList, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.339449F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66055F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(812, 222);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // clientsCountLabel
            // 
            this.clientsCountLabel.AutoSize = true;
            this.clientsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsCountLabel.Location = new System.Drawing.Point(3, 0);
            this.clientsCountLabel.Name = "clientsCountLabel";
            this.clientsCountLabel.Size = new System.Drawing.Size(276, 16);
            this.clientsCountLabel.TabIndex = 0;
            this.clientsCountLabel.Text = "Clients:";
            // 
            // clientsList
            // 
            this.clientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsList.FormattingEnabled = true;
            this.clientsList.Location = new System.Drawing.Point(3, 19);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(276, 200);
            this.clientsList.TabIndex = 1;
            // 
            // clientsChannelsCountLabel
            // 
            this.clientsChannelsCountLabel.AutoSize = true;
            this.clientsChannelsCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsChannelsCountLabel.Location = new System.Drawing.Point(285, 0);
            this.clientsChannelsCountLabel.Name = "clientsChannelsCountLabel";
            this.clientsChannelsCountLabel.Size = new System.Drawing.Size(147, 16);
            this.clientsChannelsCountLabel.TabIndex = 2;
            this.clientsChannelsCountLabel.Text = "Channels:";
            // 
            // clientsChannelsList
            // 
            this.clientsChannelsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsChannelsList.FormattingEnabled = true;
            this.clientsChannelsList.Location = new System.Drawing.Point(285, 19);
            this.clientsChannelsList.Name = "clientsChannelsList";
            this.clientsChannelsList.Size = new System.Drawing.Size(147, 200);
            this.clientsChannelsList.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.41203F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(435, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(377, 206);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.96953F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.03047F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.Controls.Add(this.unsubscribeButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.subscribeButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(377, 29);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unsubscribeButton.Location = new System.Drawing.Point(187, 3);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(171, 23);
            this.unsubscribeButton.TabIndex = 1;
            this.unsubscribeButton.Text = "Unsubscribe from all channels";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            // 
            // subscribeButton
            // 
            this.subscribeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscribeButton.Location = new System.Drawing.Point(3, 3);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(178, 23);
            this.subscribeButton.TabIndex = 0;
            this.subscribeButton.Text = "Subscribe to a random channel";
            this.subscribeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.28033F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.71967F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel6.Controls.Add(this.addClientButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.removeClientButton, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(377, 29);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // addClientButton
            // 
            this.addClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addClientButton.Location = new System.Drawing.Point(3, 3);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(82, 23);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Add client";
            this.addClientButton.UseVisualStyleBackColor = true;
            // 
            // removeClientButton
            // 
            this.removeClientButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeClientButton.Location = new System.Drawing.Point(91, 3);
            this.removeClientButton.Name = "removeClientButton";
            this.removeClientButton.Size = new System.Drawing.Size(92, 23);
            this.removeClientButton.TabIndex = 1;
            this.removeClientButton.Text = "Remove client";
            this.removeClientButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83186F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.16814F));
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.receiverDataLabel, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(377, 148);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 148);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data:";
            // 
            // receiverDataLabel
            // 
            this.receiverDataLabel.AutoSize = true;
            this.receiverDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiverDataLabel.Location = new System.Drawing.Point(51, 0);
            this.receiverDataLabel.Name = "receiverDataLabel";
            this.receiverDataLabel.Size = new System.Drawing.Size(323, 148);
            this.receiverDataLabel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latencyLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 20);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // latencyLabel
            // 
            this.latencyLabel.Name = "latencyLabel";
            this.latencyLabel.Size = new System.Drawing.Size(86, 15);
            this.latencyLabel.Text = "Avarage latency";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(824, 514);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 514);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "MainWindow";
            this.Text = "Deltix-Test2";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalEdit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox channelsList;
        private System.Windows.Forms.Label channelsCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label senderDataLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intervalEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label clientsCountLabel;
        private System.Windows.Forms.ListBox clientsList;
        private System.Windows.Forms.Label clientsChannelsCountLabel;
        private System.Windows.Forms.ListBox clientsChannelsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button removeClientButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label receiverDataLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel latencyLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;

    }
}

