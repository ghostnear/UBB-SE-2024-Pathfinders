using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGames.Model.GameOfLife.Cards.Effect
{
    public class HappinessEffect : IEffect
    {
        private readonly int happinessAmount;

        public HappinessEffect(int happinessAmount)
        {
            this.happinessAmount = happinessAmount;
            this.additionalEffect = null;
        }

        public HappinessEffect(int happinessAmount, IEffect additionalEffect)
        {
            this.happinessAmount = happinessAmount;
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
