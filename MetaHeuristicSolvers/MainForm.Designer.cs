
namespace MetaHeuristicSolvers
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProblem_openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.open_openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bestSolution_SSA_label = new System.Windows.Forms.Label();
            this.bestObjValue_SSA_label = new System.Windows.Forms.Label();
            this.run2EndSSA_btn = new System.Windows.Forms.Button();
            this.runOneIterationSSA_btn = new System.Windows.Forms.Button();
            this.resetSSA_btn = new System.Windows.Forms.Button();
            this.createSSA_btn = new System.Windows.Forms.Button();
            this.SSApropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SSAchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bestSolution_PSO_label = new System.Windows.Forms.Label();
            this.bestObjValue_PSO_label = new System.Windows.Forms.Label();
            this.run2EndPSO_btn = new System.Windows.Forms.Button();
            this.runOneIterationPSO_btn = new System.Windows.Forms.Button();
            this.resetPSO_btn = new System.Windows.Forms.Button();
            this.createPSO_btn = new System.Windows.Forms.Button();
            this.PSOpropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.PSOchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GApropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.bestSolution_GA_label = new System.Windows.Forms.Label();
            this.bestObjValue_GA_label = new System.Windows.Forms.Label();
            this.GAchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.run2EndGA_btn = new System.Windows.Forms.Button();
            this.runOneIterationGA_btn = new System.Windows.Forms.Button();
            this.resetGA_btn = new System.Windows.Forms.Button();
            this.createGA_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSAchart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSOchart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GAchart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProblem_openToolStrip,
            this.open_openToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createProblem_openToolStrip
            // 
            this.createProblem_openToolStrip.Name = "createProblem_openToolStrip";
            this.createProblem_openToolStrip.Size = new System.Drawing.Size(236, 26);
            this.createProblem_openToolStrip.Text = "Create New Problem";
            this.createProblem_openToolStrip.Click += new System.EventHandler(this.createProblem_openToolStrip_Click);
            // 
            // open_openToolStrip
            // 
            this.open_openToolStrip.Name = "open_openToolStrip";
            this.open_openToolStrip.Size = new System.Drawing.Size(236, 26);
            this.open_openToolStrip.Text = "Open";
            this.open_openToolStrip.Click += new System.EventHandler(this.open_openToolStrip_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1518, 754);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Size = new System.Drawing.Size(1173, 754);
            this.splitContainer2.SplitterDistance = 401;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1169, 397);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.bestSolution_SSA_label);
            this.tabPage1.Controls.Add(this.bestObjValue_SSA_label);
            this.tabPage1.Controls.Add(this.run2EndSSA_btn);
            this.tabPage1.Controls.Add(this.runOneIterationSSA_btn);
            this.tabPage1.Controls.Add(this.resetSSA_btn);
            this.tabPage1.Controls.Add(this.createSSA_btn);
            this.tabPage1.Controls.Add(this.SSApropertyGrid);
            this.tabPage1.Controls.Add(this.SSAchart);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SSA";
            // 
            // bestSolution_SSA_label
            // 
            this.bestSolution_SSA_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestSolution_SSA_label.AutoSize = true;
            this.bestSolution_SSA_label.Location = new System.Drawing.Point(270, 353);
            this.bestSolution_SSA_label.Name = "bestSolution_SSA_label";
            this.bestSolution_SSA_label.Size = new System.Drawing.Size(92, 17);
            this.bestSolution_SSA_label.TabIndex = 7;
            this.bestSolution_SSA_label.Text = "Best Solution: ";
            // 
            // bestObjValue_SSA_label
            // 
            this.bestObjValue_SSA_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestObjValue_SSA_label.AutoSize = true;
            this.bestObjValue_SSA_label.Location = new System.Drawing.Point(19, 353);
            this.bestObjValue_SSA_label.Name = "bestObjValue_SSA_label";
            this.bestObjValue_SSA_label.Size = new System.Drawing.Size(139, 17);
            this.bestObjValue_SSA_label.TabIndex = 6;
            this.bestObjValue_SSA_label.Text = "Best Objective Value: ";
            // 
            // run2EndSSA_btn
            // 
            this.run2EndSSA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.run2EndSSA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.run2EndSSA_btn.Location = new System.Drawing.Point(522, 10);
            this.run2EndSSA_btn.Name = "run2EndSSA_btn";
            this.run2EndSSA_btn.Size = new System.Drawing.Size(143, 35);
            this.run2EndSSA_btn.TabIndex = 5;
            this.run2EndSSA_btn.Text = "Run to End";
            this.run2EndSSA_btn.UseVisualStyleBackColor = false;
            this.run2EndSSA_btn.Click += new System.EventHandler(this.run2EndSSA_btn_Click);
            // 
            // runOneIterationSSA_btn
            // 
            this.runOneIterationSSA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.runOneIterationSSA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runOneIterationSSA_btn.Location = new System.Drawing.Point(352, 10);
            this.runOneIterationSSA_btn.Name = "runOneIterationSSA_btn";
            this.runOneIterationSSA_btn.Size = new System.Drawing.Size(143, 35);
            this.runOneIterationSSA_btn.TabIndex = 4;
            this.runOneIterationSSA_btn.Text = "Run One Iteration";
            this.runOneIterationSSA_btn.UseVisualStyleBackColor = false;
            this.runOneIterationSSA_btn.Click += new System.EventHandler(this.runOneIterationSSA_btn_Click);
            // 
            // resetSSA_btn
            // 
            this.resetSSA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.resetSSA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetSSA_btn.Location = new System.Drawing.Point(181, 10);
            this.resetSSA_btn.Name = "resetSSA_btn";
            this.resetSSA_btn.Size = new System.Drawing.Size(143, 35);
            this.resetSSA_btn.TabIndex = 3;
            this.resetSSA_btn.Text = "Reset";
            this.resetSSA_btn.UseVisualStyleBackColor = false;
            this.resetSSA_btn.Click += new System.EventHandler(this.resetSSA_btn_Click);
            // 
            // createSSA_btn
            // 
            this.createSSA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.createSSA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createSSA_btn.Location = new System.Drawing.Point(15, 10);
            this.createSSA_btn.Name = "createSSA_btn";
            this.createSSA_btn.Size = new System.Drawing.Size(143, 35);
            this.createSSA_btn.TabIndex = 2;
            this.createSSA_btn.Text = "Create SSA Solver";
            this.createSSA_btn.UseVisualStyleBackColor = false;
            this.createSSA_btn.Click += new System.EventHandler(this.createSSA_btn_Click);
            // 
            // SSApropertyGrid
            // 
            this.SSApropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSApropertyGrid.Location = new System.Drawing.Point(948, 6);
            this.SSApropertyGrid.Name = "SSApropertyGrid";
            this.SSApropertyGrid.Size = new System.Drawing.Size(210, 342);
            this.SSApropertyGrid.TabIndex = 1;
            // 
            // SSAchart
            // 
            this.SSAchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea14.Name = "ChartArea1";
            this.SSAchart.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend14.Name = "Legend1";
            this.SSAchart.Legends.Add(legend14);
            this.SSAchart.Location = new System.Drawing.Point(3, 53);
            this.SSAchart.Name = "SSAchart";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Legend = "Legend1";
            series40.Name = "AverageObj";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series41.Legend = "Legend1";
            series41.Name = "IterationBestObj";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series42.Legend = "Legend1";
            series42.Name = "SoFarBestObj";
            this.SSAchart.Series.Add(series40);
            this.SSAchart.Series.Add(series41);
            this.SSAchart.Series.Add(series42);
            this.SSAchart.Size = new System.Drawing.Size(929, 295);
            this.SSAchart.TabIndex = 0;
            this.SSAchart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.bestSolution_PSO_label);
            this.tabPage2.Controls.Add(this.bestObjValue_PSO_label);
            this.tabPage2.Controls.Add(this.run2EndPSO_btn);
            this.tabPage2.Controls.Add(this.runOneIterationPSO_btn);
            this.tabPage2.Controls.Add(this.resetPSO_btn);
            this.tabPage2.Controls.Add(this.createPSO_btn);
            this.tabPage2.Controls.Add(this.PSOpropertyGrid);
            this.tabPage2.Controls.Add(this.PSOchart);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PSO";
            // 
            // bestSolution_PSO_label
            // 
            this.bestSolution_PSO_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestSolution_PSO_label.AutoSize = true;
            this.bestSolution_PSO_label.Location = new System.Drawing.Point(270, 346);
            this.bestSolution_PSO_label.Name = "bestSolution_PSO_label";
            this.bestSolution_PSO_label.Size = new System.Drawing.Size(92, 17);
            this.bestSolution_PSO_label.TabIndex = 15;
            this.bestSolution_PSO_label.Text = "Best Solution: ";
            // 
            // bestObjValue_PSO_label
            // 
            this.bestObjValue_PSO_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestObjValue_PSO_label.AutoSize = true;
            this.bestObjValue_PSO_label.Location = new System.Drawing.Point(19, 346);
            this.bestObjValue_PSO_label.Name = "bestObjValue_PSO_label";
            this.bestObjValue_PSO_label.Size = new System.Drawing.Size(139, 17);
            this.bestObjValue_PSO_label.TabIndex = 14;
            this.bestObjValue_PSO_label.Text = "Best Objective Value: ";
            // 
            // run2EndPSO_btn
            // 
            this.run2EndPSO_btn.BackColor = System.Drawing.Color.SeaShell;
            this.run2EndPSO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.run2EndPSO_btn.Location = new System.Drawing.Point(522, 8);
            this.run2EndPSO_btn.Name = "run2EndPSO_btn";
            this.run2EndPSO_btn.Size = new System.Drawing.Size(143, 35);
            this.run2EndPSO_btn.TabIndex = 13;
            this.run2EndPSO_btn.Text = "Run to End";
            this.run2EndPSO_btn.UseVisualStyleBackColor = false;
            this.run2EndPSO_btn.Click += new System.EventHandler(this.run2EndPSO_btn_Click);
            // 
            // runOneIterationPSO_btn
            // 
            this.runOneIterationPSO_btn.BackColor = System.Drawing.Color.SeaShell;
            this.runOneIterationPSO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runOneIterationPSO_btn.Location = new System.Drawing.Point(352, 8);
            this.runOneIterationPSO_btn.Name = "runOneIterationPSO_btn";
            this.runOneIterationPSO_btn.Size = new System.Drawing.Size(143, 35);
            this.runOneIterationPSO_btn.TabIndex = 12;
            this.runOneIterationPSO_btn.Text = "Run One Iteration";
            this.runOneIterationPSO_btn.UseVisualStyleBackColor = false;
            this.runOneIterationPSO_btn.Click += new System.EventHandler(this.runOneIterationPSO_btn_Click);
            // 
            // resetPSO_btn
            // 
            this.resetPSO_btn.BackColor = System.Drawing.Color.SeaShell;
            this.resetPSO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetPSO_btn.Location = new System.Drawing.Point(181, 8);
            this.resetPSO_btn.Name = "resetPSO_btn";
            this.resetPSO_btn.Size = new System.Drawing.Size(143, 35);
            this.resetPSO_btn.TabIndex = 11;
            this.resetPSO_btn.Text = "Reset";
            this.resetPSO_btn.UseVisualStyleBackColor = false;
            this.resetPSO_btn.Click += new System.EventHandler(this.resetPSO_btn_Click);
            // 
            // createPSO_btn
            // 
            this.createPSO_btn.BackColor = System.Drawing.Color.SeaShell;
            this.createPSO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createPSO_btn.Location = new System.Drawing.Point(15, 8);
            this.createPSO_btn.Name = "createPSO_btn";
            this.createPSO_btn.Size = new System.Drawing.Size(143, 35);
            this.createPSO_btn.TabIndex = 10;
            this.createPSO_btn.Text = "Create PSO Solver";
            this.createPSO_btn.UseVisualStyleBackColor = false;
            this.createPSO_btn.Click += new System.EventHandler(this.createPSO_btn_Click);
            // 
            // PSOpropertyGrid
            // 
            this.PSOpropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSOpropertyGrid.Location = new System.Drawing.Point(948, 4);
            this.PSOpropertyGrid.Name = "PSOpropertyGrid";
            this.PSOpropertyGrid.Size = new System.Drawing.Size(210, 337);
            this.PSOpropertyGrid.TabIndex = 9;
            // 
            // PSOchart
            // 
            this.PSOchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.Name = "ChartArea1";
            this.PSOchart.ChartAreas.Add(chartArea15);
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend15.Name = "Legend1";
            this.PSOchart.Legends.Add(legend15);
            this.PSOchart.Location = new System.Drawing.Point(3, 51);
            this.PSOchart.Name = "PSOchart";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series43.Legend = "Legend1";
            series43.Name = "AverageObj";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series44.Legend = "Legend1";
            series44.Name = "IterationBestObj";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series45.Legend = "Legend1";
            series45.Name = "SoFarBestObj";
            this.PSOchart.Series.Add(series43);
            this.PSOchart.Series.Add(series44);
            this.PSOchart.Series.Add(series45);
            this.PSOchart.Size = new System.Drawing.Size(929, 290);
            this.PSOchart.TabIndex = 8;
            this.PSOchart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage3.Controls.Add(this.GApropertyGrid);
            this.tabPage3.Controls.Add(this.bestSolution_GA_label);
            this.tabPage3.Controls.Add(this.bestObjValue_GA_label);
            this.tabPage3.Controls.Add(this.GAchart);
            this.tabPage3.Controls.Add(this.run2EndGA_btn);
            this.tabPage3.Controls.Add(this.runOneIterationGA_btn);
            this.tabPage3.Controls.Add(this.resetGA_btn);
            this.tabPage3.Controls.Add(this.createGA_btn);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1161, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GA";
            // 
            // GApropertyGrid
            // 
            this.GApropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GApropertyGrid.Location = new System.Drawing.Point(948, 3);
            this.GApropertyGrid.Name = "GApropertyGrid";
            this.GApropertyGrid.Size = new System.Drawing.Size(210, 337);
            this.GApropertyGrid.TabIndex = 18;
            // 
            // bestSolution_GA_label
            // 
            this.bestSolution_GA_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestSolution_GA_label.AutoSize = true;
            this.bestSolution_GA_label.Location = new System.Drawing.Point(270, 346);
            this.bestSolution_GA_label.Name = "bestSolution_GA_label";
            this.bestSolution_GA_label.Size = new System.Drawing.Size(92, 17);
            this.bestSolution_GA_label.TabIndex = 17;
            this.bestSolution_GA_label.Text = "Best Solution: ";
            // 
            // bestObjValue_GA_label
            // 
            this.bestObjValue_GA_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestObjValue_GA_label.AutoSize = true;
            this.bestObjValue_GA_label.Location = new System.Drawing.Point(19, 346);
            this.bestObjValue_GA_label.Name = "bestObjValue_GA_label";
            this.bestObjValue_GA_label.Size = new System.Drawing.Size(139, 17);
            this.bestObjValue_GA_label.TabIndex = 16;
            this.bestObjValue_GA_label.Text = "Best Objective Value: ";
            // 
            // GAchart
            // 
            this.GAchart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.Name = "ChartArea1";
            this.GAchart.ChartAreas.Add(chartArea13);
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend13.Name = "Legend1";
            this.GAchart.Legends.Add(legend13);
            this.GAchart.Location = new System.Drawing.Point(3, 50);
            this.GAchart.Name = "GAchart";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Legend = "Legend1";
            series37.Name = "AverageObj";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Legend = "Legend1";
            series38.Name = "IterationBestObj";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Legend = "Legend1";
            series39.Name = "SoFarBestObj";
            this.GAchart.Series.Add(series37);
            this.GAchart.Series.Add(series38);
            this.GAchart.Series.Add(series39);
            this.GAchart.Size = new System.Drawing.Size(929, 290);
            this.GAchart.TabIndex = 10;
            this.GAchart.Text = "chart1";
            // 
            // run2EndGA_btn
            // 
            this.run2EndGA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.run2EndGA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.run2EndGA_btn.Location = new System.Drawing.Point(522, 9);
            this.run2EndGA_btn.Name = "run2EndGA_btn";
            this.run2EndGA_btn.Size = new System.Drawing.Size(143, 35);
            this.run2EndGA_btn.TabIndex = 9;
            this.run2EndGA_btn.Text = "Run to End";
            this.run2EndGA_btn.UseVisualStyleBackColor = false;
            this.run2EndGA_btn.Click += new System.EventHandler(this.run2EndGA_btn_Click);
            // 
            // runOneIterationGA_btn
            // 
            this.runOneIterationGA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.runOneIterationGA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runOneIterationGA_btn.Location = new System.Drawing.Point(352, 9);
            this.runOneIterationGA_btn.Name = "runOneIterationGA_btn";
            this.runOneIterationGA_btn.Size = new System.Drawing.Size(143, 35);
            this.runOneIterationGA_btn.TabIndex = 8;
            this.runOneIterationGA_btn.Text = "Run One Iteration";
            this.runOneIterationGA_btn.UseVisualStyleBackColor = false;
            this.runOneIterationGA_btn.Click += new System.EventHandler(this.runOneIterationGA_btn_Click);
            // 
            // resetGA_btn
            // 
            this.resetGA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.resetGA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetGA_btn.Location = new System.Drawing.Point(181, 9);
            this.resetGA_btn.Name = "resetGA_btn";
            this.resetGA_btn.Size = new System.Drawing.Size(143, 35);
            this.resetGA_btn.TabIndex = 7;
            this.resetGA_btn.Text = "Reset";
            this.resetGA_btn.UseVisualStyleBackColor = false;
            this.resetGA_btn.Click += new System.EventHandler(this.resetGA_btn_Click);
            // 
            // createGA_btn
            // 
            this.createGA_btn.BackColor = System.Drawing.Color.SeaShell;
            this.createGA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createGA_btn.Location = new System.Drawing.Point(15, 9);
            this.createGA_btn.Name = "createGA_btn";
            this.createGA_btn.Size = new System.Drawing.Size(143, 35);
            this.createGA_btn.TabIndex = 6;
            this.createGA_btn.Text = "Create GA Solver";
            this.createGA_btn.UseVisualStyleBackColor = false;
            this.createGA_btn.Click += new System.EventHandler(this.createGA_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 781);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Metaheuristic Algorithms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSAchart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSOchart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GAchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProblem_openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem open_openToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PropertyGrid SSApropertyGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart SSAchart;
        private System.Windows.Forms.Button run2EndSSA_btn;
        private System.Windows.Forms.Button runOneIterationSSA_btn;
        private System.Windows.Forms.Button resetSSA_btn;
        private System.Windows.Forms.Button createSSA_btn;
        private System.Windows.Forms.Label bestObjValue_SSA_label;
        private System.Windows.Forms.Label bestSolution_SSA_label;
        private System.Windows.Forms.Label bestSolution_PSO_label;
        private System.Windows.Forms.Label bestObjValue_PSO_label;
        private System.Windows.Forms.Button run2EndPSO_btn;
        private System.Windows.Forms.Button runOneIterationPSO_btn;
        private System.Windows.Forms.Button resetPSO_btn;
        private System.Windows.Forms.Button createPSO_btn;
        private System.Windows.Forms.PropertyGrid PSOpropertyGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart PSOchart;
        private System.Windows.Forms.Label bestSolution_GA_label;
        private System.Windows.Forms.Label bestObjValue_GA_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart GAchart;
        private System.Windows.Forms.Button run2EndGA_btn;
        private System.Windows.Forms.Button runOneIterationGA_btn;
        private System.Windows.Forms.Button resetGA_btn;
        private System.Windows.Forms.Button createGA_btn;
        private System.Windows.Forms.PropertyGrid GApropertyGrid;
    }
}

