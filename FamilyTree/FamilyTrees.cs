using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class FamilyTrees
    {
        private Dictionary<string, Person> people;

        public FamilyTrees()
        {
            people = new Dictionary<string, Person>();
        }

        public void AddPeople(string name, Gender gender)
        {
            if (!people.ContainsKey(name))
            {
                people[name] = new Person(name, gender);
                Person person= people[name];
                4/5
              
                Console.WriteLine($"{name} added to the family tree as {gender}");
            }
            else
            {
                Console.WriteLine("Name already taken. Please choose another name.");
            }
        }

        public void DefineRelation(string relation, string name)
        {
           if (people.ContainsKey(name))
            {
               Person person = people[name];
                person.AddRelation(relation, name);
               Console.WriteLine($"Defined {relation} with {name}");
          }
           else
           {
               Console.WriteLine("Person not found");
           }
        }

        public void EstablishRelation(string personName, string relation, string otherPersonName)
        {
            if (people.ContainsKey(personName) && people.ContainsKey(otherPersonName))
            {
              people[otherPersonName].AddRelation(relation, personName);
                Console.WriteLine($"Established {relation} between {personName} and {otherPersonName}");
            }
          else
            {
                Console.WriteLine("Person not found");
            }
        }

        public void CountRelation(string name, string relation)
        {
            if (people.ContainsKey(name))
            {
                var person = people[name];
              var relatedPeople = person.GetRelations(relation);
                
               var count = relatedPeople.Count;
                Console.WriteLine($"Number of {relation}: {count}");
            }
           else
           {
                Console.WriteLine("Person not found");
            }
        }

        public void FatherRelation(string name)
        {
            if (people.ContainsKey(name))
            {
                var person = people[name];
                var fathers = person.GetRelations("father");
                var father = fathers.Count > 0 ? fathers[0] : null;
                if (father != null)
                {
                   Console.WriteLine($"Father of {name}: {father.Name}");
               }
               else
                {
                    Console.WriteLine($"No father found for {name}");
               }
            }
            else
           {
                Console.WriteLine("Person not found");
            }
        }

    }
}
