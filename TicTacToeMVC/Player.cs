using System;

namespace PlayerManagerMVC
{
    public class Player : IComparable<Player>
    {
        public string Name { get; }

        public Player(string name){
            this.Name = name;
        }
    }
}