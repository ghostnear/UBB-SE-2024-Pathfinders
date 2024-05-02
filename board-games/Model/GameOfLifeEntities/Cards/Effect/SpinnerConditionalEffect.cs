using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class SpinnerConditionalEffect : IEffect
    {
        public SpinnerConditionalEffect()
        {
            this.additionalEffect = null;
        }

        public SpinnerConditionalEffect(IEffect additionalEffect)
        {
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
