using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards
{
    public class CustomizableTexture
    {
        private readonly CustomizableType type;
        private readonly Texture texture;

        public CustomizableTexture(CustomizableType type, Texture texture)
        {
            this.type = type;
            this.texture = texture;
        }

        public CustomizableType GetCustomizableType()
        {
            return type;
        }

        public Texture GetTexture()
        {
            return texture;
        }
    }
}
