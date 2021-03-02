using System;
using System.Collections.Generic;
using System.Text;

namespace E2_5_FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance
        {
            get { return endurance; }
            set
            {
                if (!IsValid(value))
                {
                    ThrowPlayerException("Endurance");
                }
                endurance = value;
            }
        }

        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (!IsValid(value))
                {
                    ThrowPlayerException("Sprint");
                }
                sprint = value;
            }
        }

        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (!IsValid(value))
                {
                    ThrowPlayerException("Dribble");
                }
                dribble = value;
            }
        }

        public int Passing
        {
            get { return passing; }
            set
            {
                if (!IsValid(value))
                {
                    ThrowPlayerException("Passing");
                }
                passing = value;
            }
        }

        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (!IsValid(value))
                {
                    ThrowPlayerException("Shooting");
                }
                shooting = value;
            }
        }

        public double Rating
        {
            get
            {
                return (endurance + sprint + dribble + passing + shooting) / 5.0;
            }
        }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        private void ThrowPlayerException(string v)
        {
            throw new ArgumentException($"{v} should be between 0 and 100.");
        }

        private bool IsValid(int value)
        {
            if (value < 0 || value > 100)
            {
                return false;
            }
            return true;
        }
    }
}
