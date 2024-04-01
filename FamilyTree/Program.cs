// See https://aka.ms/new-console-template for more information


using FamilyTree;

FamilyTrees familyTree = new FamilyTrees();
while (true)
{
    
    Console.WriteLine("Enter Command: ");
    string[] command = Console.ReadLine().Split();

   
    if (command.Length > 0 && command[0] == "family-tree")
    {
       
        if (command.Length >= 3)
        {
            if (command[1] == "add" && command[2] == "person")
            {
              
                if (command.Length >= 5)
                {
                    string name = command[3];
                    Gender gender;
                   
                    if (Enum.TryParse(command[4], true, out gender))
                    {
                        familyTree.AddPeople(name, gender);
                    }
                    else
                    {
                        Console.WriteLine("Invalid gender provided.");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient parameters for adding a person.");
                }
            }
            else if (command[1] == "add" && command[2] == "relations")
            {
               
                if (command.Length >= 5)
                {
                    string name = command[3];
                    familyTree.DefineRelation(command[4], name);
                }
                else
                {
                    Console.WriteLine("Insufficient parameters for defining relations.");
                }
            }
            else if (command[1] == "establishRelation")
            {
               
                if (command.Length >= 7)
                {
                    familyTree.EstablishRelation(command[2], command[4], command[6]);
                }
                else
                {
                    Console.WriteLine("Insufficient parameters for establishing relations.");
                }
            }
            else if (command[1] == "count")
            {
             
                if (command.Length >= 5)
                {
                    familyTree.CountRelation(command[4], command[2]);
                }
                else
                {
                    Console.WriteLine("Insufficient parameters for counting relations.");
                }
            }
            else if (command[1] == "father" && command[2] == "of")
            {
               
                if (command.Length >= 4)
                {
                    familyTree.FatherRelation(command[3]);
                }
                else
                {
                    Console.WriteLine("Insufficient parameters for getting father.");
                }
            }
            else if (command[1] == "exit") 
            {
                Environment.Exit(0); 
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
        else
        {
            Console.WriteLine("Invalid command.");
        }
    }
    else
    {
        Console.WriteLine("Invalid command.");
    }

}

