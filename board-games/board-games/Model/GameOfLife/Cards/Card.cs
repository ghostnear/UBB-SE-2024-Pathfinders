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
        private CardType _type { get; }
        private Texture _texture { get; }
        private IEffect _effect { get; }
        private Boolean _isConsideredBad { get; }

        public Card(CardType type, Texture texture, IEffect effect, Boolean isConsideredBad)
        {
            this._type = type;
            this._texture = texture;
            this._effect = effect;
            this._isConsideredBad = isConsideredBad;
        }
    }
}
