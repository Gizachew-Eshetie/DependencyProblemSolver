
var input = GetGivenDependecyInput();

Console.WriteLine("Given Input");
Console.WriteLine("=====================================================================");
Console.WriteLine(DependencyProblemSolver.DependencyProblemSolver.ChangeInputToString(input));
Console.WriteLine();
Console.WriteLine("Desired Output");
Console.WriteLine("=====================================================================");
Console.WriteLine(DependencyProblemSolver.DependencyProblemSolver.ChangeOutputToString(DependencyProblemSolver.DependencyProblemSolver.SolveDependecy(input)));


static string[,] GetGivenDependecyInput()
{
    return new string[,]
    {
           //dependency    //item
           {"t-shirt",     "dress shirt"},
           {"dress shirt", "pants"},
           {"dress shirt", "suit jacket"},
           {"tie",         "suit jacket"},
           {"pants",       "suit jacket"},
           {"belt",        "suit jacket"},
           {"suit jacket", "overcoat"},
           {"dress shirt", "tie"},
           {"suit jacket", "sun glasses"},
           {"sun glasses", "overcoat"},
           {"left sock",   "pants"},
           {"pants",       "belt"},
           {"suit jacket", "left shoe"},
           {"suit jacket", "right shoe"},
           {"left shoe",   "overcoat"},
           {"right sock",  "pants"},
           {"right shoe",  "overcoat"},
           {"t-shirt",     "suit jacket"}
    };

}
