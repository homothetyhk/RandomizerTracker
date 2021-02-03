namespace RandomizerTracker
{
    partial class RandomizerTracker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Map = new System.Windows.Forms.TabPage();
            this.zoomToVertexButton = new System.Windows.Forms.Button();
            this.zoomToVertexSelect = new System.Windows.Forms.ComboBox();
            this.ToggleEdgeLabels = new System.Windows.Forms.Button();
            this.masterRefreshButton = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.Input = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.removeLineButton = new System.Windows.Forms.Button();
            this.addItemLine = new System.Windows.Forms.Button();
            this.addTransitionLine = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackerLogViewer = new System.Windows.Forms.ListBox();
            this.targetTransitionSelect = new System.Windows.Forms.ComboBox();
            this.sourceTransitionSelect = new System.Windows.Forms.ComboBox();
            this.locationSelectBox = new System.Windows.Forms.ComboBox();
            this.itemSelectBox = new System.Windows.Forms.ComboBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.listBoxEdgeAlgo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filepathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVertexAlgo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Map.SuspendLayout();
            this.Input.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Map);
            this.tabControl1.Controls.Add(this.Input);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 9;
            // 
            // Map
            // 
            this.Map.Controls.Add(this.zoomToVertexButton);
            this.Map.Controls.Add(this.zoomToVertexSelect);
            this.Map.Controls.Add(this.ToggleEdgeLabels);
            this.Map.Controls.Add(this.masterRefreshButton);
            this.Map.Controls.Add(this.elementHost1);
            this.Map.Location = new System.Drawing.Point(4, 25);
            this.Map.Margin = new System.Windows.Forms.Padding(4);
            this.Map.Name = "Map";
            this.Map.Padding = new System.Windows.Forms.Padding(4);
            this.Map.Size = new System.Drawing.Size(1059, 525);
            this.Map.TabIndex = 2;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // zoomToVertexButton
            // 
            this.zoomToVertexButton.Location = new System.Drawing.Point(280, 7);
            this.zoomToVertexButton.Margin = new System.Windows.Forms.Padding(4);
            this.zoomToVertexButton.Name = "zoomToVertexButton";
            this.zoomToVertexButton.Size = new System.Drawing.Size(127, 28);
            this.zoomToVertexButton.TabIndex = 6;
            this.zoomToVertexButton.Text = "Zoom to Vertex:";
            this.zoomToVertexButton.UseVisualStyleBackColor = true;
            this.zoomToVertexButton.Click += new System.EventHandler(this.zoomToVertexButton_Click);
            // 
            // zoomToVertexSelect
            // 
            this.zoomToVertexSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomToVertexSelect.FormattingEnabled = true;
            this.zoomToVertexSelect.Location = new System.Drawing.Point(415, 7);
            this.zoomToVertexSelect.Margin = new System.Windows.Forms.Padding(4);
            this.zoomToVertexSelect.Name = "zoomToVertexSelect";
            this.zoomToVertexSelect.Size = new System.Drawing.Size(318, 26);
            this.zoomToVertexSelect.TabIndex = 5;
            // 
            // ToggleEdgeLabels
            // 
            this.ToggleEdgeLabels.Location = new System.Drawing.Point(113, 7);
            this.ToggleEdgeLabels.Margin = new System.Windows.Forms.Padding(4);
            this.ToggleEdgeLabels.Name = "ToggleEdgeLabels";
            this.ToggleEdgeLabels.Size = new System.Drawing.Size(159, 28);
            this.ToggleEdgeLabels.TabIndex = 4;
            this.ToggleEdgeLabels.Text = "Toggle Edge Labels";
            this.ToggleEdgeLabels.UseVisualStyleBackColor = true;
            this.ToggleEdgeLabels.Click += new System.EventHandler(this.ToggleEdgeLabels_Click);
            // 
            // masterRefreshButton
            // 
            this.masterRefreshButton.Location = new System.Drawing.Point(4, 7);
            this.masterRefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.masterRefreshButton.Name = "masterRefreshButton";
            this.masterRefreshButton.Size = new System.Drawing.Size(100, 28);
            this.masterRefreshButton.TabIndex = 3;
            this.masterRefreshButton.Text = "Refresh";
            this.masterRefreshButton.UseVisualStyleBackColor = true;
            this.masterRefreshButton.Click += new System.EventHandler(this.masterRefreshButton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(4, 4);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1051, 517);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.label8);
            this.Input.Controls.Add(this.removeLineButton);
            this.Input.Controls.Add(this.addItemLine);
            this.Input.Controls.Add(this.addTransitionLine);
            this.Input.Controls.Add(this.label7);
            this.Input.Controls.Add(this.label6);
            this.Input.Controls.Add(this.label5);
            this.Input.Controls.Add(this.label3);
            this.Input.Controls.Add(this.trackerLogViewer);
            this.Input.Controls.Add(this.targetTransitionSelect);
            this.Input.Controls.Add(this.sourceTransitionSelect);
            this.Input.Controls.Add(this.locationSelectBox);
            this.Input.Controls.Add(this.itemSelectBox);
            this.Input.Location = new System.Drawing.Point(4, 25);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(1059, 525);
            this.Input.TabIndex = 3;
            this.Input.Text = "Manual Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Remove selected line:";
            // 
            // removeLineButton
            // 
            this.removeLineButton.Location = new System.Drawing.Point(343, 199);
            this.removeLineButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(100, 28);
            this.removeLineButton.TabIndex = 11;
            this.removeLineButton.Text = "Remove";
            this.removeLineButton.UseVisualStyleBackColor = true;
            this.removeLineButton.Click += new System.EventHandler(this.removeLineButton_Click);
            // 
            // addItemLine
            // 
            this.addItemLine.Location = new System.Drawing.Point(343, 41);
            this.addItemLine.Margin = new System.Windows.Forms.Padding(4);
            this.addItemLine.Name = "addItemLine";
            this.addItemLine.Size = new System.Drawing.Size(100, 26);
            this.addItemLine.TabIndex = 10;
            this.addItemLine.Text = "Add";
            this.addItemLine.UseVisualStyleBackColor = true;
            this.addItemLine.Click += new System.EventHandler(this.addItemLine_Click);
            // 
            // addTransitionLine
            // 
            this.addTransitionLine.Location = new System.Drawing.Point(343, 130);
            this.addTransitionLine.Margin = new System.Windows.Forms.Padding(4);
            this.addTransitionLine.Name = "addTransitionLine";
            this.addTransitionLine.Size = new System.Drawing.Size(100, 26);
            this.addTransitionLine.TabIndex = 9;
            this.addTransitionLine.Text = "Add";
            this.addTransitionLine.UseVisualStyleBackColor = true;
            this.addTransitionLine.Click += new System.EventHandler(this.addTransitionLine_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "New transition (target)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "New transition (source)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "New location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New item";
            // 
            // trackerLogViewer
            // 
            this.trackerLogViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackerLogViewer.FormattingEnabled = true;
            this.trackerLogViewer.ItemHeight = 16;
            this.trackerLogViewer.Location = new System.Drawing.Point(507, 4);
            this.trackerLogViewer.Margin = new System.Windows.Forms.Padding(4);
            this.trackerLogViewer.Name = "trackerLogViewer";
            this.trackerLogViewer.Size = new System.Drawing.Size(544, 516);
            this.trackerLogViewer.TabIndex = 4;
            // 
            // targetTransitionSelect
            // 
            this.targetTransitionSelect.FormattingEnabled = true;
            this.targetTransitionSelect.Location = new System.Drawing.Point(173, 130);
            this.targetTransitionSelect.Margin = new System.Windows.Forms.Padding(4);
            this.targetTransitionSelect.Name = "targetTransitionSelect";
            this.targetTransitionSelect.Size = new System.Drawing.Size(160, 24);
            this.targetTransitionSelect.TabIndex = 3;
            // 
            // sourceTransitionSelect
            // 
            this.sourceTransitionSelect.FormattingEnabled = true;
            this.sourceTransitionSelect.Location = new System.Drawing.Point(4, 130);
            this.sourceTransitionSelect.Margin = new System.Windows.Forms.Padding(4);
            this.sourceTransitionSelect.Name = "sourceTransitionSelect";
            this.sourceTransitionSelect.Size = new System.Drawing.Size(160, 24);
            this.sourceTransitionSelect.TabIndex = 2;
            // 
            // locationSelectBox
            // 
            this.locationSelectBox.FormattingEnabled = true;
            this.locationSelectBox.Location = new System.Drawing.Point(173, 41);
            this.locationSelectBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationSelectBox.Name = "locationSelectBox";
            this.locationSelectBox.Size = new System.Drawing.Size(160, 24);
            this.locationSelectBox.TabIndex = 1;
            // 
            // itemSelectBox
            // 
            this.itemSelectBox.FormattingEnabled = true;
            this.itemSelectBox.Location = new System.Drawing.Point(4, 41);
            this.itemSelectBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemSelectBox.Name = "itemSelectBox";
            this.itemSelectBox.Size = new System.Drawing.Size(160, 24);
            this.itemSelectBox.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.listBoxEdgeAlgo);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.filepathBox);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.listBoxVertexAlgo);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(4);
            this.Settings.Size = new System.Drawing.Size(1059, 525);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // listBoxEdgeAlgo
            // 
            this.listBoxEdgeAlgo.FormattingEnabled = true;
            this.listBoxEdgeAlgo.ItemHeight = 16;
            this.listBoxEdgeAlgo.Items.AddRange(new object[] {
            "SimpleER",
            "Bundling",
            "PathFinder",
            "None"});
            this.listBoxEdgeAlgo.Location = new System.Drawing.Point(705, 122);
            this.listBoxEdgeAlgo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEdgeAlgo.Name = "listBoxEdgeAlgo";
            this.listBoxEdgeAlgo.Size = new System.Drawing.Size(159, 116);
            this.listBoxEdgeAlgo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edge Routing Algorithm";
            // 
            // filepathBox
            // 
            this.filepathBox.Location = new System.Drawing.Point(263, 30);
            this.filepathBox.Margin = new System.Windows.Forms.Padding(4);
            this.filepathBox.Name = "filepathBox";
            this.filepathBox.Size = new System.Drawing.Size(673, 22);
            this.filepathBox.TabIndex = 4;
            this.filepathBox.TextChanged += new System.EventHandler(this.filepathBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vertex Layout Algorithm";
            // 
            // listBoxVertexAlgo
            // 
            this.listBoxVertexAlgo.FormattingEnabled = true;
            this.listBoxVertexAlgo.ItemHeight = 16;
            this.listBoxVertexAlgo.Items.AddRange(new object[] {
            "LinLog",
            "BoundedFR",
            "Circular",
            "CompoundFDP",
            "EfficientSugiyama",
            "FR",
            "ISOM",
            "KK",
            "SimpleRandom",
            "Sugiyama"});
            this.listBoxVertexAlgo.Location = new System.Drawing.Point(263, 122);
            this.listBoxVertexAlgo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVertexAlgo.Name = "listBoxVertexAlgo";
            this.listBoxVertexAlgo.Size = new System.Drawing.Size(159, 116);
            this.listBoxVertexAlgo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RandomizerTrackerLog Filepath";
            // 
            // RandomizerTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RandomizerTracker";
            this.Text = "Hollow Knight Randomizer 3 Tracker";
            this.tabControl1.ResumeLayout(false);
            this.Map.ResumeLayout(false);
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Map;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxVertexAlgo;
        private System.Windows.Forms.TextBox filepathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxEdgeAlgo;
        private System.Windows.Forms.Button masterRefreshButton;
        private System.Windows.Forms.Button ToggleEdgeLabels;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.ComboBox targetTransitionSelect;
        private System.Windows.Forms.ComboBox sourceTransitionSelect;
        private System.Windows.Forms.ComboBox locationSelectBox;
        private System.Windows.Forms.ComboBox itemSelectBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removeLineButton;
        private System.Windows.Forms.Button addItemLine;
        private System.Windows.Forms.Button addTransitionLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox trackerLogViewer;
        private System.Windows.Forms.Button zoomToVertexButton;
        private System.Windows.Forms.ComboBox zoomToVertexSelect;
    }
}

