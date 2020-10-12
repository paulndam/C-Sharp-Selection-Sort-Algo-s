using System;
using System.Text;

namespace AlgoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Multiply();
            TestOne();

            // TerrainEnum[,] map = {
            //     { 
            //         TerrainEnum.Sand, TerrainEnum.Sand, TerrainEnum.Sand,
            //         TerrainEnum.Sand, TerrainEnum.Grass, TerrainEnum.Grass,
            //         TerrainEnum.Grass, TerrainEnum.Grass, TerrainEnum.Grass,
            //         TerrainEnum.Grass,
            //     }, 
            //     {
            //         TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            //         TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            //         TerrainEnum.Water, TerrainEnum.Wall, TerrainEnum.Water,
            //         TerrainEnum.Water

            //     }


            // };

            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            string[] stringValues = { "Peter", "Messi", "Ronaldo", "Ronaldinho", "Totti", "Iniesta", "Giggs" };
            SortNames(stringValues);
            Console.WriteLine(string.Join(" -|- ", stringValues));

        }



        public static void Multiply(){

            int[,] result = new int[10, 10];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0,5}", result[i, j]);

                }

                Console.WriteLine();
            }
        }


        public static void TestOne(){

            TerrainEnum[,] map = {
                { 
                    TerrainEnum.Sand, TerrainEnum.Sand, TerrainEnum.Sand,
                    TerrainEnum.Sand, TerrainEnum.Grass, TerrainEnum.Grass,
                    TerrainEnum.Grass, TerrainEnum.Grass, TerrainEnum.Grass,
                    TerrainEnum.Grass,
                }, 
                {
                    TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
                    TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
                    TerrainEnum.Water, TerrainEnum.Wall, TerrainEnum.Water,
                    TerrainEnum.Water

                }
                

            };

            Console.OutputEncoding = UTF8Encoding.UTF8;
            for (int row = 0; row < map.GetLength(0); row++){
                for (int column = 0; column < map.GetLength(1); column++){
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar() + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;





        }


        // Selection Sort Method

        public static void Sort<T>(T[] array) where T : IComparable{

            // the sort Method takes one params which is the array an that's what we want to sort through

            for (int i = 0; i < array.Length-1; i++){
                // here we are gonna store the index of the smallest value
                int minIndex = i;
                T minValue = array[i];

                // now lets use another for loop to find the smallest value in the unsorted array.

                for (int j = i + 1; j < array.Length; j++){
                    // we gonna compare both arrays to find out which one got the smallest value then we gonna swap them

                    if(array[j].CompareTo(minValue) < 0){
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);

            }
        }

        private static void Swap<T>(T[]array, int first, int second){
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;

        }


        public static void SortNames<T>(T[]array) where T : IComparable{

            for (int i = 0; i < array.Length - 1; i++){

                int minIndex = i;
                T minValue = array[i];

                for (int j = i + 1; j < array.Length; j++){
                    if(array[j].CompareTo(minValue)< 0){
                        minIndex = j;
                        minValue = array[j];
                    }
                }

                Swap(array, i, minIndex);
            }

        }
    } 
}
