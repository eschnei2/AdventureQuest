using System;
using System.Collections.Generic;


namespace Quest 
{
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adv)
        {
            if (adv.Awesomeness > 0)
            {
                for(int i = 0; i < adv.Awesomeness; i++)
                {
                    Console.WriteLine($"Congrats, your prize is: {_text}, ya dummy.");
                }
            }
            else{
                Console.WriteLine($"YOU WIN NOTHING, YOU SO STUPID.");
            }
        }


    }
}