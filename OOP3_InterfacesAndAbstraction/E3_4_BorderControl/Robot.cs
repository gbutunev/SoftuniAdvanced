using System;
using System.Collections.Generic;
using System.Text;

namespace E3_4_BorderControl
{
    public class Robot : IIdentifiable
    {
        private string id;
        public string Model { get; private set; }
        public string Id { get { return id; } private set { id = value; } }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
