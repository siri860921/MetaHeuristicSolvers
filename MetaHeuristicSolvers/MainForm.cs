using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using COP;

namespace MetaHeuristicSolvers
{
    public partial class MainForm : Form
    {
        SingleSalpAlgorithm theSSASolver;
        ParticleSwamOptimizer thePSOSolver;
        RealNumberGASolver theGASolver;
        COPBenchmark theProblem;
        public MainForm()
        {
            InitializeComponent();
            theProblem = new COPBenchmark();

            createSSA_btn.Enabled = false;
            resetSSA_btn.Enabled = false;
            runOneIterationSSA_btn.Enabled = false;
            run2EndSSA_btn.Enabled = false;
            createPSO_btn.Enabled = false;
            resetPSO_btn.Enabled = false;
            runOneIterationPSO_btn.Enabled = false;
            run2EndPSO_btn.Enabled = false;
            createGA_btn.Enabled = false;
            resetGA_btn.Enabled = false;
            runOneIterationGA_btn.Enabled = false;
            run2EndGA_btn.Enabled = false;
        }

        private void createProblem_openToolStrip_Click(object sender, EventArgs e)
        {
            COPBenchmark newProblem = COPBenchmark.CreateANewProblemAndShowEditor();
        }

        private void open_openToolStrip_Click(object sender, EventArgs e)
        {
            theProblem = COPBenchmark.LoadAProblemFromAFile();
            if (theProblem == null) return;
            theProblem.DisplayOnPanel(splitContainer1.Panel1);
            theProblem.DisplayObjectiveGraphics(splitContainer2.Panel2);
            if (theSSASolver != null)
                theProblem.DisplaySolutionsOnGraphics(theSSASolver.SalpChain);
            else if (thePSOSolver != null)
                theProblem.DisplaySolutionsOnGraphics(thePSOSolver.Solutions);
            else if(theGASolver != null)
                theProblem.DisplaySolutionsOnGraphics(theGASolver.Selectedchromosomes);

            createSSA_btn.Enabled = true;
            createPSO_btn.Enabled = true;
            createGA_btn.Enabled = true;
            SSAchart.Series[0].Points.Clear();
            SSAchart.Series[1].Points.Clear();
            SSAchart.Series[2].Points.Clear();
            PSOchart.Series[0].Points.Clear();
            PSOchart.Series[1].Points.Clear();
            PSOchart.Series[2].Points.Clear();
            GAchart.Series[0].Points.Clear();
            GAchart.Series[1].Points.Clear();
            GAchart.Series[2].Points.Clear();
            bestObjValue_SSA_label.Text = "Best Objective Value: ";
            bestSolution_SSA_label.Text = "Best Solution: ";
            bestObjValue_PSO_label.Text = "Best Objective Value: ";
            bestSolution_PSO_label.Text = "Best Solution: ";
            bestObjValue_GA_label.Text = "Best Objective Value: ";
            bestSolution_GA_label.Text = "Best Solution: ";
        }

        private void createSSA_btn_Click(object sender, EventArgs e)
        {
            ProblemType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ? ProblemType.Minimization : ProblemType.Maximization;
            theSSASolver = new SingleSalpAlgorithm(type, theProblem.Dimension, theProblem.UpperBound, theProblem.LowerBound, theProblem.GetObjectiveValue);

            createSSA_btn.Enabled = false;
            resetSSA_btn.Enabled = true;
            SSApropertyGrid.SelectedObject = theSSASolver;
        }

        private void createPSO_btn_Click(object sender, EventArgs e)
        {
            OptimizationType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ? OptimizationType.Minimization : OptimizationType.Maximization;
            thePSOSolver = new ParticleSwamOptimizer(theProblem.Dimension, type,
                theProblem.LowerBound, theProblem.UpperBound, theProblem.GetObjectiveValue);

            resetPSO_btn.Enabled = true;
            createPSO_btn.Enabled = false;
            PSOpropertyGrid.SelectedObject = thePSOSolver;
        }

        private void createGA_btn_Click(object sender, EventArgs e)
        {
            OptType type = theProblem.OptimizationGoal == COP.OptimizationType.Minimization ? OptType.Minimization : OptType.Maximization;
            theGASolver = new RealNumberGASolver(type, theProblem.Dimension, theProblem.UpperBound,
                theProblem.LowerBound, theProblem.GetObjectiveValue);

            resetGA_btn.Enabled = true;
            createGA_btn.Enabled = false;
            GApropertyGrid.SelectedObject = theGASolver;
        }

        private void resetSSA_btn_Click(object sender, EventArgs e)
        {
            theSSASolver.Reset();

            resetSSA_btn.Enabled = true;
            runOneIterationSSA_btn.Enabled = true;
            run2EndSSA_btn.Enabled = true;
            SSAchart.Series[0].Points.Clear();
            SSAchart.Series[1].Points.Clear();
            SSAchart.Series[2].Points.Clear();
            bestObjValue_SSA_label.Text = "Best Objective Value: ";
            bestSolution_SSA_label.Text = "Best Solution: ";
        }

        private void resetPSO_btn_Click(object sender, EventArgs e)
        {
            thePSOSolver.Reset();

            resetPSO_btn.Enabled = false;
            runOneIterationPSO_btn.Enabled = true;
            run2EndPSO_btn.Enabled = true;
            PSOpropertyGrid.Enabled = false;

            PSOchart.Series[0].Points.Clear();
            PSOchart.Series[1].Points.Clear();
            PSOchart.Series[2].Points.Clear();

            bestObjValue_PSO_label.Text = "Best Objective Value: ";
            bestSolution_PSO_label.Text = "Best Solution: ";
        }

        private void resetGA_btn_Click(object sender, EventArgs e)
        {
            theGASolver.Reset();

            resetGA_btn.Enabled = false;
            runOneIterationGA_btn.Enabled = true;
            run2EndGA_btn.Enabled = true;
            GApropertyGrid.Enabled = false;

            GAchart.Series[0].Points.Clear();
            GAchart.Series[1].Points.Clear();
            GAchart.Series[2].Points.Clear();

            bestObjValue_GA_label.Text = "Best Objective Value: ";
            bestSolution_GA_label.Text = "Best Solution: ";
        }

        private void runOneIterationSSA_btn_Click(object sender, EventArgs e)
        {
            theSSASolver.OneIteration();

            resetSSA_btn.Enabled = false;
            SSAchart.Series[0].Points.AddXY(theSSASolver.IterationCount, theSSASolver.IterationAverage);
            SSAchart.Series[1].Points.AddXY(theSSASolver.IterationCount, theSSASolver.IterationBest);
            SSAchart.Series[2].Points.AddXY(theSSASolver.IterationCount, theSSASolver.SoFarBestObjValue);
            SSAchart.Update();

            theProblem.DisplaySolutionsOnGraphics(theSSASolver.SalpChain);
            theProblem.GetGradientVector(theSSASolver.SoFarBestSalp);
            splitContainer2.Panel2.Refresh();
        }

        private void runOneIterationPSO_btn_Click(object sender, EventArgs e)
        {
            thePSOSolver.OneIteration();

            PSOchart.Series[0].Points.AddXY(thePSOSolver.IterationCount, thePSOSolver.IterationAverageObj);
            PSOchart.Series[1].Points.AddXY(thePSOSolver.IterationCount, thePSOSolver.IterationBestObj);
            PSOchart.Series[2].Points.AddXY(thePSOSolver.IterationCount, thePSOSolver.SoFarBestObj);
            PSOchart.Update();

            theProblem.DisplaySolutionsOnGraphics(thePSOSolver.Solutions);
            theProblem.GetGradientVector(thePSOSolver.SoFarBestSolution);
            splitContainer2.Panel2.Refresh();
        }

        private void runOneIterationGA_btn_Click(object sender, EventArgs e)
        {
            theGASolver.RunOneIteration();

            GAchart.Series[0].Points.AddXY(theGASolver.IterationCount, theGASolver.IterationAverageObj);
            GAchart.Series[1].Points.AddXY(theGASolver.IterationCount, theGASolver.IterationBestObj);
            GAchart.Series[2].Points.AddXY(theGASolver.IterationCount, theGASolver.SoFarBestObjValue);
            GAchart.Update();

            theProblem.DisplaySolutionsOnGraphics(theGASolver.Selectedchromosomes);
            splitContainer2.Panel2.Refresh();
        }

        private void run2EndSSA_btn_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            while(!theSSASolver.Run2End()) {
                runOneIterationSSA_btn_Click(null, null);
            }
            Cursor = Cursors.Default;
            MessageBox.Show("Calculation Complete!");

            resetSSA_btn.Enabled = true;
            runOneIterationSSA_btn.Enabled = false;
            run2EndSSA_btn.Enabled = false;
            bestObjValue_SSA_label.Text = $"Best Objective Value: {theSSASolver.SoFarBestObjValue.ToString("#0.000")}";
            for(int i = 0; i < theSSASolver.SoFarBestSalp.Length; i++)
                bestSolution_SSA_label.Text += $"{theSSASolver.SoFarBestSalp[i].ToString("#0.00")} ";
        }

        private void run2EndPSO_btn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            while (!thePSOSolver.Run2End())
            {
                runOneIterationPSO_btn_Click(null, null);
            }

            Cursor = Cursors.Default;

            PSOpropertyGrid.Enabled = true;
            resetPSO_btn.Enabled = true;
            runOneIterationPSO_btn.Enabled = false;
            run2EndPSO_btn.Enabled = false;
            MessageBox.Show("Calculation Complete!");

            bestObjValue_PSO_label.Text = $"Best Objective Value: {thePSOSolver.SoFarBestObj}";
            for (int i = 0; i < thePSOSolver.NumberOfVariables; i++)
            {
                bestSolution_PSO_label.Text += $"{thePSOSolver.SoFarBestSolution[i].ToString("#0.00")} ";
            }
        }

        private void run2EndGA_btn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            while(!theGASolver.run2End())
            {
                runOneIterationGA_btn_Click(null, null);
            }

            Cursor = Cursors.Default;

            GApropertyGrid.Enabled = true;
            resetGA_btn.Enabled = true;
            runOneIterationGA_btn.Enabled = false;
            run2EndGA_btn.Enabled = false;
            MessageBox.Show("Calculation Complete!");

            bestObjValue_GA_label.Text = $"Best Objective Value: {theGASolver.SoFarBestObjValue}";
            for(int i = 0; i < theGASolver.NumberOfGenes; i++)
            {
                bestSolution_GA_label.Text += $"{theGASolver.SoFarBestSolutoin[i].ToString("#0.00")}";
            }
        }
    }
}