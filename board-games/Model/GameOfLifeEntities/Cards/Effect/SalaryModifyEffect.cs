using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class SalaryModifyEffect : IEffect
    {
        private readonly int salaryModifyAmount;

        public SalaryModifyEffect(int salaryModifyAmount)
        {
            this.salaryModifyAmount = salaryModifyAmount;
            this.additionalEffect = null;
        }

        public SalaryModifyEffect(int salaryModifyAmount, IEffect additionalEffect)
        {
            this.salaryModifyAmount = salaryModifyAmount;
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
