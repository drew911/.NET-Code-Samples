using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WorkingWithFiles.Models;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = File.ReadAllText("WrittenFile2.txt");
            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();

            //Console.WriteLine("Enter some number");
            //string text2 = Console.ReadLine();

            //File.AppendAllText("Names.txt", text + " " + text2 +"\n");


            List<PersonModel> models = new();

            string[] textLines = File.ReadAllLines("Names.txt");

            foreach (string textLine in textLines)
            {
                string[] parameters = textLine.Split(" ");
                PersonModel model = new()
                {
                    Name = parameters[0],
                    City = parameters[1],
                    Grade = Int32.Parse(parameters[2])
                };

                models.Add(model);

                
            }

            models = models.Where(m => m.Name != "Jaunius").ToList();

            File.WriteAllText("Names.txt","");

            foreach (var model in models)
            {
                File.AppendAllText("Names.txt", model.Name + " " + model.City + " " + model.Grade + "\n");
            }

            //---------------------------------------------------

            string jsonModels = JsonConvert.SerializeObject(models);

            File.WriteAllText("NamesJson", jsonModels);

            string readModels = File.ReadAllText("NamesJson");

            List<PersonModel> receivedModels = JsonConvert.DeserializeObject<List<PersonModel>>(readModels);

            // manipulate the list
            models = models.Where(m => m.Name != "Marija").ToList();

            jsonModels = JsonConvert.SerializeObject(models);

            File.WriteAllText("NamesJson", jsonModels);
        }
    }
}
