using System;
namespace JokeWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string Punchline { get; set; }

        public Joke()
        {

        }
    }
}
