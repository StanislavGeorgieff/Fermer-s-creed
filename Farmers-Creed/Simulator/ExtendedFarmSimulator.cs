using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;
using FarmersCreed.Units;
using FarmersCreed.Units.Animals;
using FarmersCreed.Units.Plants;

namespace FarmersCreed.Simulator
{
    public class ExtendedFarmSimulator : FarmSimulator
    {
        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string type = inputCommands[1];
            string id = inputCommands[2];
            switch (type)
            {
                case "CherryTree":
                    {
                        CherryTree cheryTree = new CherryTree(id);
                        farm.Plants.Add(cheryTree);
                        break;
                    }

                case "Cow":
                    {
                        var cow = new Cow(id);
                        farm.Animals.Add(cow);
                        break;
                    }
                case "Swine":
                    {
                        var swine = new Swine(id);
                        farm.Animals.Add(swine);
                        break;
                    }
                case "TobaccoPlant":
                    {
                        var tobacco = new TobaccoPlant(id);
                        farm.Plants.Add(tobacco);
                        break;
                    }
                default:
                    base.AddObjectToFarm(inputCommands);   
                    break;

            }
        }

        protected override void ProcessInput(string input)
        {
            string[] inputCommands = input.Split(' ');

            string action = inputCommands[0];

            switch (action)
            {
                case "exploit":
                    {

                        if (inputCommands[1] == "animal")
                        {
                            var exploatedItem = GetAnimalById(inputCommands[2]);
                            farm.Exploit(exploatedItem);
                            break;
                        }
                        else
                        {
                            var exploatedItem = GetPlantById(inputCommands[2]);
                            farm.Exploit(exploatedItem);
                            break;
                        }

                    }

                case "feed":
                    {
                        this.farm.Feed(GetAnimalById(inputCommands[1]), (IEdible)GetProductById(inputCommands[2]), int.Parse(inputCommands[3]));
                        break;
                    }

                case "water":
                    {
                        this.farm.Water(GetPlantById(inputCommands[1]));
                        break;
                    }
                default:
                    base.ProcessInput(input);
                    break;
            }
        }
    }
}
