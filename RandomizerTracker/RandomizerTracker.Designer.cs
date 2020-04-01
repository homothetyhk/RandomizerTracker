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
            this.zoomToVertexSelect = new System.Windows.Forms.ComboBox();
            this.zoomToVertexButton = new System.Windows.Forms.Button();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 9;
            // 
            // Map
            // 
            this.Map.Controls.Add(this.zoomToVertexButton);
            this.Map.Controls.Add(this.zoomToVertexSelect);
            this.Map.Controls.Add(this.ToggleEdgeLabels);
            this.Map.Controls.Add(this.masterRefreshButton);
            this.Map.Controls.Add(this.elementHost1);
            this.Map.Location = new System.Drawing.Point(4, 22);
            this.Map.Name = "Map";
            this.Map.Padding = new System.Windows.Forms.Padding(3);
            this.Map.Size = new System.Drawing.Size(792, 424);
            this.Map.TabIndex = 2;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // ToggleEdgeLabels
            // 
            this.ToggleEdgeLabels.Location = new System.Drawing.Point(85, 6);
            this.ToggleEdgeLabels.Name = "ToggleEdgeLabels";
            this.ToggleEdgeLabels.Size = new System.Drawing.Size(119, 23);
            this.ToggleEdgeLabels.TabIndex = 4;
            this.ToggleEdgeLabels.Text = "Toggle Edge Labels";
            this.ToggleEdgeLabels.UseVisualStyleBackColor = true;
            this.ToggleEdgeLabels.Click += new System.EventHandler(this.ToggleEdgeLabels_Click);
            // 
            // masterRefreshButton
            // 
            this.masterRefreshButton.Location = new System.Drawing.Point(3, 6);
            this.masterRefreshButton.Name = "masterRefreshButton";
            this.masterRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.masterRefreshButton.TabIndex = 3;
            this.masterRefreshButton.Text = "Refresh";
            this.masterRefreshButton.UseVisualStyleBackColor = true;
            this.masterRefreshButton.Click += new System.EventHandler(this.masterRefreshButton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(786, 418);
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
            this.Input.Location = new System.Drawing.Point(4, 22);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(792, 424);
            this.Input.TabIndex = 3;
            this.Input.Text = "Manual Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Remove selected line:";
            // 
            // removeLineButton
            // 
            this.removeLineButton.Location = new System.Drawing.Point(257, 162);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(75, 23);
            this.removeLineButton.TabIndex = 11;
            this.removeLineButton.Text = "Remove";
            this.removeLineButton.UseVisualStyleBackColor = true;
            this.removeLineButton.Click += new System.EventHandler(this.removeLineButton_Click);
            // 
            // addItemLine
            // 
            this.addItemLine.Location = new System.Drawing.Point(257, 33);
            this.addItemLine.Name = "addItemLine";
            this.addItemLine.Size = new System.Drawing.Size(75, 21);
            this.addItemLine.TabIndex = 10;
            this.addItemLine.Text = "Add";
            this.addItemLine.UseVisualStyleBackColor = true;
            this.addItemLine.Click += new System.EventHandler(this.addItemLine_Click);
            // 
            // addTransitionLine
            // 
            this.addTransitionLine.Location = new System.Drawing.Point(257, 106);
            this.addTransitionLine.Name = "addTransitionLine";
            this.addTransitionLine.Size = new System.Drawing.Size(75, 21);
            this.addTransitionLine.TabIndex = 9;
            this.addTransitionLine.Text = "Add";
            this.addTransitionLine.UseVisualStyleBackColor = true;
            this.addTransitionLine.Click += new System.EventHandler(this.addTransitionLine_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "New transition (target)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "New transition (source)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "New location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "New item";
            // 
            // trackerLogViewer
            // 
            this.trackerLogViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackerLogViewer.FormattingEnabled = true;
            this.trackerLogViewer.Location = new System.Drawing.Point(380, 3);
            this.trackerLogViewer.Name = "trackerLogViewer";
            this.trackerLogViewer.Size = new System.Drawing.Size(409, 420);
            this.trackerLogViewer.TabIndex = 4;
            // 
            // targetTransitionSelect
            // 
            this.targetTransitionSelect.FormattingEnabled = true;
            this.targetTransitionSelect.Location = new System.Drawing.Point(130, 106);
            this.targetTransitionSelect.Name = "targetTransitionSelect";
            this.targetTransitionSelect.Size = new System.Drawing.Size(121, 21);
            this.targetTransitionSelect.TabIndex = 3;
            // 
            // sourceTransitionSelect
            // 
            this.sourceTransitionSelect.FormattingEnabled = true;
            this.sourceTransitionSelect.Location = new System.Drawing.Point(3, 106);
            this.sourceTransitionSelect.Name = "sourceTransitionSelect";
            this.sourceTransitionSelect.Size = new System.Drawing.Size(121, 21);
            this.sourceTransitionSelect.TabIndex = 2;
            // 
            // locationSelectBox
            // 
            this.locationSelectBox.FormattingEnabled = true;
            this.locationSelectBox.Location = new System.Drawing.Point(130, 33);
            this.locationSelectBox.Name = "locationSelectBox";
            this.locationSelectBox.Size = new System.Drawing.Size(121, 21);
            this.locationSelectBox.TabIndex = 1;
            // 
            // itemSelectBox
            // 
            this.itemSelectBox.FormattingEnabled = true;
            this.itemSelectBox.Location = new System.Drawing.Point(3, 33);
            this.itemSelectBox.Name = "itemSelectBox";
            this.itemSelectBox.Size = new System.Drawing.Size(121, 21);
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
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(792, 424);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // listBoxEdgeAlgo
            // 
            this.listBoxEdgeAlgo.FormattingEnabled = true;
            this.listBoxEdgeAlgo.Items.AddRange(new object[] {
            "SimpleER",
            "Bundling",
            "PathFinder",
            "None"});
            this.listBoxEdgeAlgo.Location = new System.Drawing.Point(529, 99);
            this.listBoxEdgeAlgo.Name = "listBoxEdgeAlgo";
            this.listBoxEdgeAlgo.Size = new System.Drawing.Size(120, 95);
            this.listBoxEdgeAlgo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edge Routing Algorithm";
            // 
            // filepathBox
            // 
            this.filepathBox.Location = new System.Drawing.Point(197, 24);
            this.filepathBox.Name = "filepathBox";
            this.filepathBox.Size = new System.Drawing.Size(506, 20);
            this.filepathBox.TabIndex = 4;
            this.filepathBox.TextChanged += new System.EventHandler(this.filepathBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vertex Layout Algorithm";
            // 
            // listBoxVertexAlgo
            // 
            this.listBoxVertexAlgo.FormattingEnabled = true;
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
            this.listBoxVertexAlgo.Location = new System.Drawing.Point(197, 99);
            this.listBoxVertexAlgo.Name = "listBoxVertexAlgo";
            this.listBoxVertexAlgo.Size = new System.Drawing.Size(120, 95);
            this.listBoxVertexAlgo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RandomizerTrackerLog Filepath";
            // 
            // zoomToVertexSelect
            // 
            this.zoomToVertexSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomToVertexSelect.FormattingEnabled = true;
            this.zoomToVertexSelect.Location = new System.Drawing.Point(311, 6);
            this.zoomToVertexSelect.Name = "zoomToVertexSelect";
            this.zoomToVertexSelect.Size = new System.Drawing.Size(121, 23);
            this.zoomToVertexSelect.TabIndex = 5;
            // 
            // zoomToVertexButton
            // 
            this.zoomToVertexButton.Location = new System.Drawing.Point(210, 6);
            this.zoomToVertexButton.Name = "zoomToVertexButton";
            this.zoomToVertexButton.Size = new System.Drawing.Size(95, 23);
            this.zoomToVertexButton.TabIndex = 6;
            this.zoomToVertexButton.Text = "Zoom to Vertex:";
            this.zoomToVertexButton.UseVisualStyleBackColor = true;
            this.zoomToVertexButton.Click += new System.EventHandler(this.zoomToVertexButton_Click);
            // 
            // RandomizerTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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

