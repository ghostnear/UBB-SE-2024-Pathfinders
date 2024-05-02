using BoardGames.Model.CommonEntities;

namespace BoardGames.Model.SkillIssueBroEntities
{
    public class GameTile : Tile
    {
        private int id;
        private int gridRowIndex;
        private int gridColumnIndex;

        // someone find a solution
        public GameTile(int tileId, int gridRowIndex, int gridColumnIndex) : base(tileId, gridColumnIndex, gridRowIndex)
        {
            id = tileId;
            this.gridRowIndex = gridRowIndex;
            this.gridColumnIndex = gridColumnIndex;
        }

        public int GetTileId()
        {
            return id;
        }

        public int GetGridRowIndex()
        {
            return gridRowIndex;
        }

        public int GetGridColumnInded()
        {
            return gridColumnIndex;
        }
    }
}
