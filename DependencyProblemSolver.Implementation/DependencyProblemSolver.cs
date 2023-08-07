
using System.Text;

namespace DependencyProblemSolver
{
    public static class DependencyProblemSolver
    {
        public static List<List<string>> SolveDependecy(string[,] input)
        {
            //Get all items for each dependency
            Dictionary<string, HashSet<string>> dependencyList = GetDependencyList(input);

            var itemsWithNoDependency = new Queue<(string key, int level)>();

            foreach (var key in dependencyList.Keys)
            {
                var level = 0;
                //Add dependencies with no other dependency to the queue
                if (dependencyList[key].Count == 0)
                    itemsWithNoDependency.Enqueue((key, level));
            }

            var output = new List<List<string>>();
            var visitedItems = 0;
            var currentLevelItems = new List<string>();
            var previousLevel = 0;

            while (itemsWithNoDependency.Count > 0)
            {
                var (currentItem, currentLevel) = itemsWithNoDependency.Dequeue();
                visitedItems++;

                if (currentLevel > previousLevel)
                {
                    if (currentLevelItems.Count > 0)
                    {
                        var orderedNodes = currentLevelItems.OrderBy(x => x).ToList();
                        output.Add(orderedNodes);
                    }
                    currentLevelItems = new List<string>();
                    previousLevel = currentLevel;
                }
                currentLevelItems.Add(currentItem);

                var itemsDependingOnCurrentItem = dependencyList.Where(i => i.Value.Contains(currentItem)).Select(i => i.Key).ToList();
                foreach (var node in itemsDependingOnCurrentItem)
                {
                    dependencyList[node].Remove(currentItem);
                    if (dependencyList[node].Count == 0)
                    {
                        itemsWithNoDependency.Enqueue((node, currentLevel + 1));
                    }
                }
            }

            if (currentLevelItems.Count > 0)
            {
                var orderedNodes = currentLevelItems.OrderBy(x => x).ToList();
                output.Add(orderedNodes);
            }

            if (visitedItems != dependencyList.Keys.Count)
            {
                throw new Exception("The input is not valid, please check your input");
            }

            return output;
        }

        //Convert input array into string
        public static string ChangeInputToString(string[,] input)
        {
            StringBuilder sb = new StringBuilder();

            int index = 0;

            while (index < (input.Length / 2))
            {
                sb.AppendLine($"{input[index, 0]}, {input[index, 1]}");
                index++;
            }

            return sb.ToString();
        }

        //Convert output list into string
        public static string ChangeOutputToString(List<List<string>> output)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in output)
                sb.AppendLine(string.Join(',', line));

            return sb.ToString();
        }

        private static Dictionary<string, HashSet<string>> GetDependencyList(string[,] input)
        {
            var dependencyList = new Dictionary<string, HashSet<string>>();
            for (var row = 0; row < input.GetLength(0); row++)
            {
                var dependencyValue = input[row, 0];
                var itemValue = input[row, 1];

                if (!dependencyList.ContainsKey(dependencyValue))
                {
                    dependencyList[dependencyValue] = new HashSet<string>();
                }

                if (dependencyList.ContainsKey(itemValue))
                {
                    dependencyList[itemValue].Add(dependencyValue);
                }
                else
                {
                    dependencyList[itemValue] = new HashSet<string>() { dependencyValue };
                }
            }

            return dependencyList;
        }

    }
}
