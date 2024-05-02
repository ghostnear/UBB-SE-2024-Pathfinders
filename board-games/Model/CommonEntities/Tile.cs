namespace BoardGames.Model.CommonEntities
{
    internal class Tile
    {
        private int id;
        private float centerPositionX;
        private float centerPositionY;

        public Tile(int tileId, float centerXPosition, float centerYPosition)
        {
            id = tileId;
            centerPositionX = centerXPosition;
            centerPositionY = centerYPosition;
        }

        public float GetCenterXPosition()
        {
            return centerPositionX;
        }
        public float GetCenterYPosition()
        {
            return centerPositionY;
        }
        public int GetTileId()
        {
            return id;
        }
    }
}
