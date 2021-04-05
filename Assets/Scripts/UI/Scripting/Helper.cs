using System.Collections.Generic;
using UnityEngine;

namespace FD.Scripting
{
    public class Helper
    {
        public static List<int> GenerateIndexList(int lenght)
        {
            var indexList = new List<int>();

            int i = 0;
            while (i < lenght)
            {
                indexList.Add(i);
                i++;
            }

            return indexList;
        }

        public static void ShuffleList<T>(List<T> inputList)
        {
            if (inputList.Count > 0)
            {
                for (var i = 0; i < inputList.Count; i++)
                {
                    var swapID = Random.Range(0, inputList.Count);

                    if (swapID != i)
                    {
                        T tempElement = inputList[swapID];
                        inputList[swapID] = inputList[i];
                        inputList[i] = tempElement;
                    }
                }
            }
        }
    }
}
