using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MetaHeuristicSolvers
{
    public enum ProblemType { Maximization, Minimization };
    public delegate double GetFunctionValue(double[] solution);
    class SingleSalpAlgorithm
    {
        #region Data Fields
        Random randomizer = new Random();
        ProblemType theType = ProblemType.Minimization;
        double[][] salpChain; //salp table
        double[] parameterUpperBounds;
        double[] parameterLowerBounds;
        double[] salpObjectiveValues; // objective values for each salp
        double[] salpFitnessValues; //fitness values of each salpea
        double[] foodSource; //the food source in current iteration
        double[] soFarBestSolution; //so far the best solution
        double iterationAverageObjValue;
        double iterationBestObjValue;
        double soFarBestObjValue;
        //double rangingFactor = 0.3; // the influence factor of the parameter valid domain

        int numberOfSalps = 30;
        int numberOfParameters;
        int iterationCount;
        int iterationLimit = 300;

        GetFunctionValue theObjFunction;
        #endregion

        #region Contructor
        public SingleSalpAlgorithm(ProblemType opType, int numberOfParameters, double[] upperBound, double[] lowerBound, GetFunctionValue ObjFunction)
        {
            theType = opType;
            this.numberOfParameters = numberOfParameters;
            parameterUpperBounds = new double[this.numberOfParameters];
            parameterLowerBounds = new double[this.numberOfParameters];
            theObjFunction = ObjFunction;
            for(int i = 0; i <numberOfParameters; i++)
            {
                parameterUpperBounds[i] = upperBound[i];
                parameterLowerBounds[i] = lowerBound[i];
            }
        }
        #endregion

        #region Properties
        [Description("The main goal of the problem. Maximization for maximization porblem, and Minimization for minimization problem."), Category("Problem Info")]
        public ProblemType TheType { get => theType; }
        [Description("Number of solution agents to join the optimization process."), Category("Problem Info")]
        public int NumberOfSalps 
        {
            get => numberOfSalps; 
            set
            {
                if (value >= 3) numberOfSalps = value;
            } 
        }
        [Description("Number of  parameters in a solution agent"), Category("Problem Info")]
        public int NumberOfParameters { get => numberOfParameters; }
        [Browsable(false)]
        public double IterationAverage { get => iterationAverageObjValue; }
        [Browsable(false)]
        public double IterationBest { get => iterationBestObjValue; }
        [Browsable(false)]
        public double SoFarBestObjValue { get => soFarBestObjValue; }
        [Browsable(false)]
        public double[] SoFarBestSalp { get => soFarBestSolution; }
        //public double RangingFactor 
        //{ 
        //    get => rangingFactor; 
        //    set
        //    {
        //        if (value > 0 && value <= 1) rangingFactor = value;
        //    }
        //}
        [Browsable(false)]
        public double[][] SalpChain { get => salpChain; }
        [Browsable(false)]
        public int IterationCount { get => iterationCount; }
        [Description("Number of  parameters in a solution agent"), Category("Problem Info")]
        public int IterationLimit 
        { 
            get => iterationLimit; 
            set
            {
                if (value > 0) iterationLimit = value; 
            }
        }
        #endregion

        #region Function Fields
        internal void Reset()
        {
            salpChain = new double[numberOfSalps][];
            for (int i = 0; i < numberOfSalps; i++)
                salpChain[i] = new double[numberOfParameters];
            //initialize salp chain
            for(int i = 0; i < numberOfSalps; i++)
            {
                for (int j = 0; j < numberOfParameters; j++)
                    salpChain[i][j] = parameterLowerBounds[j] + (parameterUpperBounds[j] - parameterLowerBounds[j]) * randomizer.NextDouble();
            }
            foodSource = new double[numberOfParameters];
            salpObjectiveValues = new double[numberOfSalps];
            salpFitnessValues = new double[numberOfSalps];
            soFarBestSolution = new double[numberOfParameters];
            iterationCount = 0;
            if (theType == ProblemType.Maximization) soFarBestObjValue = double.MinValue;
            else soFarBestObjValue = double.MaxValue;
        }

        internal void OneIteration()
        {
            AssignFoodSourcePositionAndComputeObjValue();
            //UpdateSoFarBestSalp();
            MoveSalpToNewPosition();
            iterationCount++;
        }

        void AssignFoodSourcePositionAndComputeObjValue()
        {
            //initialize iteration average and iteration best
            iterationAverageObjValue = 0;
            if (theType == ProblemType.Maximization) iterationBestObjValue = double.MinValue;
            else iterationBestObjValue = double.MaxValue;
            //compute the objective value of each salp
            for (int i = 0; i < numberOfSalps; i++)
            {
                salpObjectiveValues[i] = theObjFunction(salpChain[i]);
                iterationAverageObjValue += salpObjectiveValues[i] / numberOfSalps;
            }
            //find the highest fitness agent, assign it and its value to food source and iteration best objective value. Update so far best objective value if needed
            int selectedIdx = 0;
            for (int i = 0; i < numberOfSalps; i++)
            {
                if(theType == ProblemType.Minimization)
                {
                    if(salpObjectiveValues[i] < iterationBestObjValue)
                    {
                        selectedIdx = i;
                        iterationBestObjValue = salpObjectiveValues[i];
                    }
                }
                else
                {
                    if(salpObjectiveValues[i] > iterationBestObjValue)
                    {
                        selectedIdx = i;
                        iterationBestObjValue = salpObjectiveValues[i];
                    }
                }
            }
            //update so far best solution and so far best objective value
            if (theType == ProblemType.Minimization)
            {
                if (iterationBestObjValue < soFarBestObjValue)
                {
                    soFarBestObjValue = iterationBestObjValue;
                    for(int i = 0; i < numberOfParameters; i++)
                    {
                        soFarBestSolution[i] = salpChain[selectedIdx][i];
                        //assign food source
                        foodSource[i] = salpChain[selectedIdx][i];
                    }
                }
            }
            else
            {
                if(iterationBestObjValue > soFarBestObjValue)
                {
                    soFarBestObjValue = iterationBestObjValue;
                    for (int i = 0; i < numberOfParameters; i++)
                    {
                        soFarBestSolution[i] = salpChain[selectedIdx][i];
                        //assign food source
                        foodSource[i] = salpChain[selectedIdx][i];
                    }
                }
            }
        }

        void MoveSalpToNewPosition()
        {
            double seachingFactor = 2 * Math.Exp(-(4 * IterationCount / iterationLimit) * (4 * IterationCount / iterationLimit));
            for(int i = 0; i < numberOfSalps; i++)
            {
                if(i == 0)
                {

                    //double rangingFactor = randomizer.NextDouble();
                    for (int j = 0; j < numberOfParameters; j++)
                    {
                        double wayOfMoveMent = randomizer.NextDouble();
                        //compute movement
                        double movement = 0;
                        if (wayOfMoveMent >= 0.5) movement = seachingFactor * ((parameterUpperBounds[j] - parameterLowerBounds[j])+ parameterLowerBounds[j]);
                        else movement = -seachingFactor * ((parameterUpperBounds[j] - parameterLowerBounds[j])  + parameterLowerBounds[j]);
                        salpChain[i][j] = foodSource[j] + movement;
                        if (salpChain[i][j] > parameterUpperBounds[j]) salpChain[i][j] = parameterUpperBounds[j];
                        else if (salpChain[i][j] < parameterLowerBounds[j]) salpChain[i][j] = parameterLowerBounds[j];
                    }
                }
                else
                {
                    for(int j = 0; j < numberOfParameters; j++)
                    {
                        salpChain[i][j] = 0.5 * (salpChain[i - 1][j] + salpChain[i][j]);
                        if (salpChain[i][j] > parameterUpperBounds[j]) salpChain[i][j] = parameterUpperBounds[j];
                        else if (salpChain[i][j] < parameterLowerBounds[j]) salpChain[i][j] = parameterLowerBounds[j];
                    }
                }
            }
        }

        internal bool Run2End()
        {
            if (iterationCount == iterationLimit) return true;
            else return false;
        }
        #endregion
    }
}
