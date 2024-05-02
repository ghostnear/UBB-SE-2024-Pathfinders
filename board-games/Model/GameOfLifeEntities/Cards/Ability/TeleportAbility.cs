using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGames.Model.GameOfLife.Cards.Ability
{
    class TeleportAbility : IAbility
    {
        public static readonly int Cooldown = 1;

        public TeleportAbility() { }
    }
}
