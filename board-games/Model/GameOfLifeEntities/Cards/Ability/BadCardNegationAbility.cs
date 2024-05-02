using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGames.Model.GameOfLife.Cards.Ability;

namespace BoardGames.Model.GameOfLife.Cards
{
    public class BadCardNegationAbility
    {
        private CardType typeToNegate;
        public int TurnsLeft { get; set; }
        public readonly int Cooldown;

        public BadCardNegationAbility(CardType typeToNegate, int numberOfTurns, int cooldown)
        {
            this.typeToNegate = typeToNegate;
            this.TurnsLeft = numberOfTurns;
            this.Cooldown = cooldown;
        }

        public CardType GetTypeToNegate()
        {
            return typeToNegate;
        }

    }
}
