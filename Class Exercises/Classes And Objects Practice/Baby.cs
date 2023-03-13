using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Baby
    {
        private string Id; // תז של התינוק
        private string Gender; // מין התינוק // F - נקבה // M - זכר
        private int Height; // גובה התינוק
        private double Weight; // משקל התינוק

        public Baby(string id, string gender, int height, double weight)
        {
            this.Id = id;
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
        }

        public Baby(string id, int height, double weight) 
        {
            this.Id = id;
            this.Gender = "F";
            this.Height = height;
            this.Weight = weight;
        }

        public int GetHeight() { return this.Height; }
        public double GetWeight() { return this.Weight; }
        public void UpdateWeight(double w) { this.Weight += w; }
        public void AddHeight(int h) { this.Height += h; }
        public bool IsSame(Baby other) { return this.Height == other.Height && this.Weight == other.Weight; }

    }
}
