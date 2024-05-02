using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class SalarySetEffect : IEffect
    {
        private readonly int salarySetAmount;

        public SalarySetEffect(int salarySetAmount)
        {
            this.salarySetAmount = salarySetAmount;
            this.additionalEffect = null;
        }

        public SalarySetEffect(int salarySetAmount, IEffect additionalEffect)
        {
            this.salarySetAmount = salarySetAmount;
            this.additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
