using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaHeuristicSolvers
{
    public enum OptType { Maximization, Minimization };
    public delegate double GetObjFunctionValue(double[] solution);
    class RealNumberGASolver
    {
        #region DataFields
        Random randomizer = new Random();
        double[][] chromosomes;
        double[][] selectedchromosomes;

        double[] objectiveValues;
        //double[] fitnessValues;
        double[] parameterUpperBounds;
        double[] parameterLowerBounds;
        int[] indices;

        double[] soFarBestSolutoin;
        double iterationAverageObj;
        double iterationBestObj;
        double soFarBestObjValue;
        double crossoverRate = 0.8;
        double mutationRate = 0.05;
        //double totalFitness;

        int numberOfGenes;
        int populationSize = 30;
        int numberOfCrossOverChildren;
        int numberOfMutatedChildren;
        int iterationCount;
        int iterationLimit = 300;

        OptType problemType = OptType.Minimization;
        GetObjFunctionValue ObjCalculateMethod;
        #endregion

        #region Properties
        [Browsable(false)]
        public double[] SoFarBestSolutoin { get => soFarBestSolutoin; }
        [Browsable(false)]
        public double IterationAverageObj { get => iterationAverageObj; }
        [Browsable(false)]
        public double IterationBestObj { get => iterationBestObj; }
        [Browsable(false)]
        public double SoFarBestObjValue { get => soFarBestObjValue; set => soFarBestObjValue = value; }
        [Description("Determine how much portion of chromosomes are engaged in the crossover process."), Category("Problem Info")]
        public double CrossoverRate 
        { 
            get => crossoverRate;
            set
            {
                if (value > 0 && value <= 1) crossoverRate = value;
            }
        }
        [Description("Determine the degree of nonuniformity."), Category("Problem Info")]
        public double MutationRate 
        { 
            get => mutationRate; 
            set
            {
                if (value > 0 && value <= 3) mutationRate = value;
            }
        }
        [Description("The population engage in the algorithm."), Category("Problem Info")]
        public int PopulationSize
        { 
            get => populationSize; 
            set
            {
                if (value >= 3) populationSize = value;
            }
        }
        [Description("Number of parameters to optimize."), Category("Problem Info")]
        public int NumberOfGenes { get => numberOfGenes; }
        [Browsable(false)]
        public int IterationCount { get => iterationCount; }
        [Description("Number of iterations to run the algorithm."), Category("Problem Info")]
        public int IterationLimit 
        { 
            get => iterationLimit; 
            set
            {
                if (value > 10) iterationLimit = value;
            }
        }
        [Browsable(false)]
        public double[][] Selectedchromosomes { get => selectedchromosomes;}
        #endregion

        #region Constructor
        public RealNumberGASolver(OptType theType, int numberOfParameters, double[] upperBounds, double[] lowerBounds, GetObjFunctionValue theMethod)
        {
            problemType = theType;
            numberOfGenes = numberOfParameters;
            //allocate parameter bound spaces
            parameterUpperBounds = new double[numberOfGenes];
            parameterLowerBounds = new double[numberOfGenes];
            for(int i = 0; i < numberOfGenes; i++)
            {
                parameterUpperBounds[i] = upperBounds[i];
                parameterLowerBounds[i] = lowerBounds[i];
            }
            ObjCalculateMethod = theMethod;
        }
        #endregion

        #region Function Fields
        public void Reset()
        {
            //allocate chromosome space
            chromosomes = new double[populationSize * 3][];
            selectedchromosomes = new double[populationSize][];
            for (int i = 0; i < populationSize; i++)
                selectedchromosomes[i] = new double[numberOfGenes];
            for (int i = 0; i < populationSize * 3; i++)
            {
                chromosomes[i] = new double[numberOfGenes];
                //reset initial population
                if(i < populationSize)
                {
                    for (int j = 0; j < numberOfGenes; j++)
                    {
                        chromosomes[i][j] = parameterLowerBounds[j] + (parameterUpperBounds[j] - parameterLowerBounds[j]) * randomizer.NextDouble();
                        selectedchromosomes[i][j] = chromosomes[i][j];
                    }
                }
            }
            objectiveValues = new double[populationSize * 3];
            //fitnessValues = new double[populationSize * 3];
            soFarBestSolutoin = new double[numberOfGenes];
            indices = new int[populationSize];
            iterationAverageObj = 0;
            if(problemType == OptType.Minimization)
            {
                iterationBestObj = double.MaxValue;
                soFarBestObjValue = double.MaxValue;
            }
            else
            {
                iterationBestObj = double.MinValue;
                soFarBestObjValue = double.MinValue;
            }
            iterationCount = 0;       
        }
        
        public void RunOneIteration()
        {
            performCrossOverOperation();
            performMutationOperation();
            ComputeObjValuesAndUpdateSoFarBest();
            performSelectionOperation();

            iterationCount++;
        }

        void performCrossOverOperation()
        {
            shuffleAnIntergerArray(indices);
            numberOfCrossOverChildren = Convert.ToInt32(crossoverRate * populationSize);
            if (numberOfCrossOverChildren % 2 == 1) numberOfCrossOverChildren--;
            //large value divided method crossover
            for(int i = populationSize; i < populationSize + numberOfCrossOverChildren;  i += 2)
            {
                for(int j = 0; j < numberOfGenes; j++)
                {
                    chromosomes[i][j] = 0.3 * parameterLowerBounds[j] + (1 - 0.3) * chromosomes[indices[i - populationSize]][j];
                    chromosomes[i + 1][j] = 0.3 * chromosomes[indices[i - populationSize]][j] + (1 - 0.3) * parameterUpperBounds[j];
                    if (chromosomes[i][j] > parameterUpperBounds[j])
                        chromosomes[i][j] = parameterUpperBounds[j];
                    else if (chromosomes[i][j] < parameterLowerBounds[j])
                        chromosomes[i][j] = parameterLowerBounds[j];
                    if (chromosomes[i+1][j] > parameterUpperBounds[j])
                        chromosomes[i+1][j] = parameterUpperBounds[j];
                    else if (chromosomes[i+1][j] < parameterLowerBounds[j])
                        chromosomes[i+1][j] = parameterLowerBounds[j];
                }
            }
        }

        void performMutationOperation()
        {
            shuffleAnIntergerArray(indices);
            numberOfMutatedChildren = populationSize;
            //dynamic mutation
            double mutateOrientation;
            for(int i = populationSize + numberOfCrossOverChildren; i < populationSize + numberOfCrossOverChildren + numberOfMutatedChildren; i++)
            {
                for(int j = 0; j < numberOfGenes; j++)
                {
                    mutateOrientation = randomizer.NextDouble();
                    if (mutateOrientation > 0.5)
                        chromosomes[i][j] = chromosomes[indices[i - populationSize - numberOfCrossOverChildren]][j] + randomizer.NextDouble()
                            * (parameterUpperBounds[j] - chromosomes[indices[i - populationSize - numberOfCrossOverChildren]][j]) * Math.Pow((1 - iterationCount / iterationLimit), mutationRate);
                    else
                        chromosomes[i][j] = chromosomes[indices[i - populationSize - numberOfCrossOverChildren]][j] - randomizer.NextDouble()
                                * (chromosomes[indices[i - populationSize - numberOfCrossOverChildren]][j] - parameterLowerBounds[j]) * Math.Pow((1 - iterationCount / iterationLimit), mutationRate);
                    if (chromosomes[i][j] > parameterUpperBounds[j])
                        chromosomes[i][j] = parameterUpperBounds[j];
                    else if (chromosomes[i][j] < parameterLowerBounds[j])
                        chromosomes[i][j] = parameterLowerBounds[j];
                }
            }
        }

        void ComputeObjValuesAndUpdateSoFarBest()
        {
            iterationAverageObj = 0;
            if (problemType == OptType.Minimization)
                iterationBestObj = double.MaxValue;
            else
                iterationBestObj = double.MinValue;
            //compute objective value and find iteration best ID
            int selectedID = 0;
            for(int i = 0; i < populationSize + numberOfCrossOverChildren + numberOfMutatedChildren; i++)
            {
                objectiveValues[i] = ObjCalculateMethod(chromosomes[i]);
                iterationAverageObj += objectiveValues[i] / (populationSize + numberOfCrossOverChildren + numberOfMutatedChildren);
                if(problemType == OptType.Minimization)
                {
                    if (objectiveValues[i] < iterationBestObj)
                    {
                        selectedID = i;
                        iterationBestObj = objectiveValues[i];
                    }
                }
                else
                {
                    if(objectiveValues[i] > iterationBestObj)
                    {
                        selectedID = i;
                        iterationBestObj = objectiveValues[i];
                    }
                }
            }
            //update so far best obkective value and solution
            if(problemType == OptType.Minimization)
            {
                if(iterationBestObj < soFarBestObjValue)
                {
                    soFarBestObjValue = iterationBestObj;
                    for (int j = 0; j < numberOfGenes; j++)
                        soFarBestSolutoin[j] = chromosomes[selectedID][j];
                }
            }
            else
            {
                if(iterationBestObj > soFarBestObjValue)
                {
                    soFarBestObjValue = iterationBestObj;
                    for (int j = 0; j < numberOfGenes; j++)
                        soFarBestSolutoin[j] = chromosomes[selectedID][j];
                }
            }
        }

        void performSelectionOperation()
        {
            int[] theIndice = new int[populationSize * 3];
            for (int i = 0; i < theIndice.Length; i++)
                theIndice[i] = i;
            Array.Sort(objectiveValues, theIndice, 0, theIndice.Length);
            if (problemType == OptType.Maximization)
                Array.Reverse(theIndice, 0, theIndice.Length);
            for (int i = 0; i < selectedchromosomes.Length; i++)
            {
                for (int j = 0; j < numberOfGenes; j++)
                    selectedchromosomes[i][j] = chromosomes[theIndice[i]][j];
            }
            //update population for the next iteration
            for(int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < numberOfGenes; j++)
                    chromosomes[i][j] = selectedchromosomes[i][j];
            }
        }

        //bool compareValue(double becompared, double compared)
        //{
        //    switch(problemType)
        //    {
        //        case OptType.Maximization:
        //            return (becompared > compared) ? true : false;
        //        case OptType.Minimization:
        //            return (becompared < compared) ? true : false;
        //        default:
        //            return true;
        //    }
        //}

        void shuffleAnIntergerArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = i;

            for (int i = array.Length - 1; i > 0; i--)
            {
                int pos = randomizer.Next(i + 1);
                int temp = array[i];
                array[i] = array[pos];
                array[pos] = temp;
            }
        }

        public bool run2End()
        {
            if (iterationCount == iterationLimit) return true;
            else return false;
        }
        #endregion
    }
}
