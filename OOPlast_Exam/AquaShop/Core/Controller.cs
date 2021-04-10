using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private Dictionary<string, IAquarium> aquaria;

        public Controller()
        {
            decorationRepository = new DecorationRepository();
            aquaria = new Dictionary<string, IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium a = null;
            if (aquariumType == "FreshwaterAquarium")
            {
                a = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                a = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            aquaria.Add(aquariumName, a);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration d = null;
            if (decorationType == "Ornament")
            {
                d = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                d = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            decorationRepository.Add(d);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish f = null;
            if (fishType == "FreshwaterFish")
            {
                f = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                f = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            IAquarium a = aquaria[aquariumName];
            if (a.GetType().Name.Replace("Aquarium", "") != f.GetType().Name.Replace("Fish", ""))
            {
                return OutputMessages.UnsuitableWater;
            }
            else
            {
                a.AddFish(f);
                return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
            }
        }

        public string CalculateValue(string aquariumName)
        {
            decimal total = 0;
            IAquarium aq = aquaria[aquariumName];

            foreach (var f in aq.Fish)
            {
                total += f.Price;
            }
            foreach (var d in aq.Decorations)
            {
                total += d.Price;
            }

            return string.Format(OutputMessages.AquariumValue, aquariumName, total);
        }

        public string FeedFish(string aquariumName)
        {
            aquaria[aquariumName].Feed();
            return string.Format(OutputMessages.FishFed, aquaria[aquariumName].Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration d = decorationRepository.FindByType(decorationType);
            if (d == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            decorationRepository.Remove(d);
            aquaria[aquariumName].AddDecoration(d);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var a in aquaria.Values)
            {
                sb.AppendLine(a.GetInfo());
            }

            return sb.ToString().Trim();
        }
    }
}
