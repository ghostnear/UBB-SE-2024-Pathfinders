using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGames.Model.GameOfLife.Cards.Effect
{
    public class MoneyEffect : IEffect
    {
        private readonly int moneyAmount;

        public MoneyEffect(int moneyAmount)
        {
            this.moneyAmount = moneyAmount;
            this.additionalEffect = null;
        }

        public MoneyEffect(int moneyAmount, IEffect additionalEffect)
        {
            this.moneyAmount = moneyAmount;
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
