using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR.Tamagotchi.Model
{
    public class Dragon
    {
        public  string Name { get; set; }
        public  int Age { get; set; }
        public int  Weight { get; set; }
        public int Happiness { get; set; }
        public int HungerLevel { get; set; }
        public Life Life { get; set; }
        

        public Dragon(string name)
        {
            Name = name;
            Age = 1;
            Weight = 1;
            Happiness = 5;
            HungerLevel = 5;
            Life = Life.Baby;
            

            

        }
        public void Pet()
        {
            Happiness += 3;
        }
        public void Feed()
        {
            HungerLevel = HungerLevel <=1 ? 1: HungerLevel-=3;
            Weight+=1;


        }

        public void Play()
        {
            this.Happiness += 5;
            this.HungerLevel += 1;
            this.Weight = this.Weight<=1 ? 1: Weight-=1;
        }


       
        
    }

    public enum Life { Baby, Child, Teen, Adult}

   


}
