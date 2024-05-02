using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board_games.Model.GameOfLife.Cards.Effect;

namespace board_games.Model.GameOfLife.Cards
{
    public class Card
    {
        private CardType type;
        private Texture texture;
        private IEffect effect;
        private bool isConsideredBad;

        public Card(CardType type, Texture texture, IEffect effect, Boolean isConsideredBad)
        {
            this.type = type;
            this.texture = texture;
            this.effect = effect;
            this.isConsideredBad = isConsideredBad;
        }

        public CardType GetType()
        {
            return type;
        }

        public Texture GetTexture()
        {
            return texture;
        }

        public IEffect GetEffect()
        {
            return effect;
        }

        public bool IsConsideredBad()
        {
            return isConsideredBad;
        }

    }
}
