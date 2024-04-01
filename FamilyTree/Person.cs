using System;
using System.Collections.Generic;

namespace FamilyTree
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public string Name { get; }
        public Gender Gender { get; }
        public Dictionary<string, List<Person>> Relation { get; }

       
        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Relation = new Dictionary<string, List<Person>>();
        }

       
       
        public void AddRelation(string relation, string otherPersonName)
        {
            
           
            if (Relation.ContainsKey(relation))
            {
                
                Relation[relation].Add(new Person(otherPersonName, Gender));
                Console.WriteLine(Relation[relation].Count);
            }
            else
            {
               
               Relation[relation] = new List<Person> { new Person(otherPersonName, Gender) };
               
            }
        }


      
        public List<Person> GetRelations(string relation)
        {
            return Relation.ContainsKey(relation) ? Relation[relation] : new List<Person>();
        }
    }
}
