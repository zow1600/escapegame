using System;
using System.Collections.Generic;
using System.Text;

namespace NewEscapeGame
{
    class Puzzles
    {
      
        public 
        public void Chain()
        {
            Console.WriteLine( @$"
You’re rummaging around the bedroom when you find 5 short chains each made of four gold links. 
It occurs to you that if you combined them all into one big loop of 20 links, it will fit in the slate that has odd shape.
But in making the necklace, it will cost 10 ml of the candle to be used for each gold link that you have to break and then reseal.
If you can get the exact number, you can brun the candle most efficienty.If you cannot get it excat time, you will need to light up more.
If you made the necklace in least amount of time possible, how much candle ml does it take you to make the nacklace?");
        }

        public void ChainAnswer()
        {
            Console.WriteLine("40");
        }

        public void Light()
        {
            Console.WriteLine( $@"You discover there is a light circuit and it works! 
But none of the 100 circuit breakers are labeled, and you face the daunting prospect of matching each circuit breaker to its respective light. 
Each circuit breaker maps to only one light.
To start with, you switch all 100 lights in the house to “on,” and then you head down to your basement to begin the onerous mapping process. 
On every trip to your basement, you can switch any number of circuit breakers on or off. 
You can then roam the hallways of your mansion to discover which lights are on and which are off.
If each trip takes 10 ml, how much ml of candle would you need? ");
        }

        public void LightAsnwer()
        {
            Console.WriteLine ("70");

        }

        public int ChainAnswers = Convert.ToInt32(40);
        public int LightAnswers = Convert.ToInt32(70);
    }
}
