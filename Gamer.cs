using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperStoneScissors
{
    enum GamerType
    {
        Human,
        Computer
    }


    internal class Gamer
    {
        //Atributes 
        private string _name;
        private GamerType _type;
        private int _bestResult;


        //Methods
        public string getName() { return _name;}
        public int getBestResult() { return _bestResult;}
        public void setName(string newName) { _name = newName; }
        public GamerType getType() { return _type; }

        public Answer randomChoice() {
            Random random = new Random();
            return (Answer)random.Next(Enum.GetNames(typeof(Answer)).Length); }
        public Gamer(string name, GamerType type = GamerType.Computer)
        {
            _name = name;
            _type = type;

        }
    }
}
