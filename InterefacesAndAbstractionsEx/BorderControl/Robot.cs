using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IID
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.ID = id;

        }

        public string ID
        {
            get => this.id;
            private set => this.id = value;
        }

        public bool findLastDigits(string fakeId)
        {
            return this.ID.EndsWith(fakeId);
        }
    }
}
