using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGames.Model.GameOfLife.Cards.Effect
{
    public class ConditionalEffect : IEffect
    {
        private readonly IEffect effectIfFirstPathChosen;
        private readonly IEffect effectIfSecondPathChosen;

        public ConditionalEffect(IEffect effectIfFirstPathChosen, IEffect effectIfSecondPathChosen)
        {
            this.effectIfFirstPathChosen = effectIfFirstPathChosen;
            this.effectIfSecondPathChosen = effectIfSecondPathChosen;
            this.additionalEffect = null;
        }

        public ConditionalEffect(IEffect effectIfFirstPathChosen, IEffect effectIfSecondPathChosen, IEffect additionalEffect)
        {
            this.effectIfFirstPathChosen = effectIfFirstPathChosen;
            this.effectIfSecondPathChosen = effectIfSecondPathChosen;
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
