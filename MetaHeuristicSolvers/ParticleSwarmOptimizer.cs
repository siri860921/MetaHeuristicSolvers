using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MetaHeuristicSolvers
{
    public enum OptimizationType { Minimization, Maximization }
    public delegate double ObjectiveFunction(double[] solution);
    class ParticleSwamOptimizer
    {
        #region DataFields
        Random randomizer = new Random();
        int numberOfParticles = 30;
        int numberOfVariables;
        double iterationAverageObj;
        double iterationBestObj;
        double soFarBestObj;
        int iterationLimit = 300;
        int iterationCount;
        int iterationBestID;

        double cognitionFactor = 2;
        double socialFactor = 2;

        double[][] solutions;
        double[][] individualBest;
        double[] soFarBestSolution;
        double[] lowerBounds;
        double[] upperBounds;
        double[] individualValue;
        double[] objectiveValue;

        OptimizationType problemType = OptimizationType.Minimization;
        ObjectiveFunction ObjFunction;
        #endregion

        public ParticleSwamOptimizer(int numberOfVariables, OptimizationType optType,
            double[] lowerBounds, double[] upperBounds, ObjectiveFunction objFunction)
        {
            this.numberOfVariables = numberOfVariables;
            problemType = optType;
            this.lowerBounds = new double[this.numberOfVariables];
            this.upperBounds = new double[this.numberOfVariables];
            this.lowerBounds = lowerBounds;
            this.upperBounds = upperBounds;
            ObjFunction = objFunction;
            soFarBestSolution = new double[this.numberOfVariables];
        }

        #region Properties
        [Browsable(false)]
        public double[][] Solutions { get => solutions; }
        [Browsable(false)]
        public double[] SoFarBestSolution { get => soFarBestSolution; }
        [Description("Determine how many particles to involve in."), Category("Problem Info")]
        public int NumberOfParticles
        {
            get => numberOfParticles;
            set
            {
                if (value >= 3) numberOfParticles = value;
            }
        }
        [Description("Number of variables."), Category("Problem Info")]
        public int NumberOfVariables { get => numberOfVariables; }
        [Description("Number of iterations to run the algorithm."), Category("Problem Info")]
        public int IterationLimit
        {
            get => iterationLimit;
            set => iterationLimit = value;
        }
        [Description("Whether particle movement follows its own search experience"), Category("Problem Info")]
        public double CognitionFactor
        {
            get => cognitionFactor;
            set
            {
                if (value > 0) cognitionFactor = value;
            }
        }
        [Description("Whether particle movement follows the swam search experience"), Category("Problem Info")]
        public double SocialFactor
        {
            get => socialFactor;
            set
            {
                if (value > 0) socialFactor = value;
            }
        }
        [Description("Problem Type"), Category("Problem Info")]
        public OptimizationType ProblemType { get => problemType; set => problemType = value; }
        [Browsable(false)]
        public int IterationCount { get => iterationCount; }
        [Browsable(false)]
        public double IterationAverageObj { get => iterationAverageObj; }
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double SoFarBestObj { get => soFarBestObj; }
        #endregion

        #region Function Field
        internal void Reset()
        {
            individualValue = new double[numberOfParticles];
            solutions = new double[numberOfParticles][];
            individualBest = new double[numberOfParticles][];
            objectiveValue = new double[numberOfParticles];
            for (int i = 0; i < numberOfParticles; i++)
            {
                solutions[i] = new double[this.numberOfVariables];
                individualBest[i] = new double[this.numberOfVariables];
            }

            iterationCount = 0;
            if (problemType == OptimizationType.Minimization)
            {
                iterationBestObj = double.MaxValue;
                soFarBestObj = double.MaxValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    individualValue[i] = double.MaxValue;
                }
            }
            else
            {
                iterationBestObj = double.MinValue;
                soFarBestObj = double.MinValue;
                for (int i = 0; i < numberOfParticles; i++)
                {
                    individualValue[i] = double.MinValue;
                }
            }

            //initialize particle variables and individual values
            for (int i = 0; i < numberOfParticles; i++)
            {
                for (int j = 0; j < numberOfVariables; j++)
                {
                    solutions[i][j] = lowerBounds[j] + (upperBounds[j] - lowerBounds[j]) * randomizer.NextDouble();
                    individualBest[i][j] = solutions[i][j];
                }
            }

            //initialize so far best solution
            for (int i = 0; i < numberOfVariables; i++)
            {
                soFarBestSolution[i] = lowerBounds[i] + (upperBounds[i] - lowerBounds[i]) * randomizer.NextDouble();
            }
        }

        internal void OneIteration()
        {
            CaculateObj();
            MoveParticle();

            iterationCount++;
        }

        void CaculateObj()
        {
            iterationAverageObj = 0;
            iterationBestID = 0;
            if (problemType == OptimizationType.Minimization) iterationBestObj = double.MaxValue;
            else iterationBestObj = double.MinValue;
            //caculate objective value of each particle
            for (int i = 0; i < numberOfParticles; i++)
            {
                objectiveValue[i] = ObjFunction(solutions[i]);
                iterationAverageObj += ObjFunction(solutions[i]) / numberOfParticles;

                //update indivdual best
                if (objectiveValue[i] < individualValue[i])
                {
                    individualValue[i] = objectiveValue[i];
                    for (int j = 0; j < numberOfVariables; j++)
                        individualBest[i][j] = solutions[i][j];
                }
                //find iteration best objective
                if (problemType == OptimizationType.Minimization)
                {
                    if (iterationBestObj > objectiveValue[i])
                    {
                        iterationBestObj = objectiveValue[i];
                        iterationBestID = i;
                    }
                }
                else
                {
                    if (iterationBestObj < objectiveValue[i])
                    {
                        iterationBestObj = objectiveValue[i];
                        iterationBestID = i;
                    }
                }
            }
            //update so far best solution if needed
            if (problemType == OptimizationType.Minimization)
            {
                if (soFarBestObj > iterationBestObj)
                {
                    soFarBestObj = iterationBestObj;
                    for (int k = 0; k < numberOfVariables; k++)
                        soFarBestSolution[k] = solutions[iterationBestID][k];
                }
            }
            else
            {
                if (soFarBestObj < iterationBestObj)
                {
                    soFarBestObj = iterationBestObj;
                    for (int k = 0; k < numberOfVariables; k++)
                        soFarBestSolution[k] = solutions[iterationBestID][k];
                }
            }
        }

        void MoveParticle()
        {
            for (int i = 0; i < numberOfParticles; i++)
            {
                double alpha = cognitionFactor * randomizer.NextDouble();
                double beta = socialFactor * randomizer.NextDouble();
                for (int j = 0; j < numberOfVariables; j++)
                {
                    solutions[i][j] += alpha * (individualBest[i][j] - solutions[i][j]) + beta * (soFarBestSolution[j] - solutions[i][j]);
                    if (solutions[i][j] > upperBounds[j]) solutions[i][j] = upperBounds[j];
                    else if (solutions[i][j] < lowerBounds[j]) solutions[i][j] = lowerBounds[j];
                }
            }
        }

        internal bool Run2End()
        {
            if (iterationCount == iterationLimit)
                return true;
            else
                return false;
        }
        #endregion

    }
}
