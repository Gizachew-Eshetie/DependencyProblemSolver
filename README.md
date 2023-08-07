You can provide you solution however you see fit.
Some options that we have used in the past are BitBucket, GitHub, https://dotnetfiddle.net/, or a zip file
emailed.
 
Thank and good luck!
 
----------------------------------------------
 
Create a C# program that solves the following dependency problem:
 
A person needs to figure out which order his/her clothes need to be put on. 
The person creates a file that contains the dependencies.
 
This input is a declared array of dependencies with the [0] index being the dependency and the [1] index
being the item. 
 
A simple input would be:
 
                var input = new string[,]
                               {
                                                                //dependency    //item
                                               {&quot;t-shirt&quot;,             &quot;dress shirt&quot;},
                                                        {&quot;dress shirt&quot;, &quot;pants&quot;},
                                                        {&quot;dress shirt&quot;, &quot;suit jacket&quot;},
                                                        {&quot;tie&quot;,                           &quot;suit jacket&quot;},
                                                        {&quot;pants&quot;,     &quot;suit jacket&quot;},
                                                        {&quot;belt&quot;,         &quot;suit jacket&quot;},
                                                        {&quot;suit jacket&quot;, &quot;overcoat&quot;},
                                                        {&quot;dress shirt&quot;, &quot;tie&quot;},
                                                        {&quot;suit jacket&quot;, &quot;sun glasses&quot;},
                                                        {&quot;sun glasses&quot;, &quot;overcoat&quot;},
                                                        {&quot;left sock&quot;,                &quot;pants&quot;},
                                                        {&quot;pants&quot;,     &quot;belt&quot;},
                                                        {&quot;suit jacket&quot;, &quot;left shoe&quot;},
                                                        {&quot;suit jacket&quot;, &quot;right shoe&quot;},
                                                        {&quot;left shoe&quot;,               &quot;overcoat&quot;},
                                                        {&quot;right sock&quot;,             &quot;pants&quot;},
                                                        {&quot;right shoe&quot;,            &quot;overcoat&quot;},
                                                        {&quot;t-shirt&quot;,    &quot;suit jacket&quot;}
                                       };
 
In this example, it shows that they must put on their left sock before their pants. Also, 
they must put on their pants before their belt.
 
From this data, write a program that provides the order that each object needs to be put on.
 
The output should be a line-delimited list of objects. If there are multiple objects that
can be done at the same time, list each object on the same line, alphabetically 

sorted, comma separated.
 
Therefore, the output for this sample file would be:
 
left sock,right sock, t-shirt
dress shirt
pants, tie
belt
suit jacket
left shoe, right shoe, sun glasses
overcoat
 
Evaluation Criteria
 
You will be evaluated on the following criteria:
 
1.            Correctness of the solution
2.            Algorithmic, logic, and programming skills
3.            Performance considerations
4.            Design and code structure (modular, etc)
5.            Coding style
6.            Usability
7.            Testability
8.            Documentation
