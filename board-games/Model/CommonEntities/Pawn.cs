namespace BoardGames.Model.CommonEntities
{
    public class Pawn
    {
        private int id;
        private Tile occupiedTile;
        private Player associatedPlayer;

        public Pawn(int pawnId, Tile occupiedTile)
        {
            id = pawnId;
            this.occupiedTile = occupiedTile;
        }

        public Pawn(int pawnId, Tile occupiedTile, Player associatedPlayer)
        {
            id = pawnId;
            this.occupiedTile = occupiedTile;
            this.associatedPlayer = associatedPlayer;
        }

        public void ChangeTile(Tile tileToChangeTo)
        {
            occupiedTile = tileToChangeTo;
        }
        public Tile GetOccupiedTile()
        {
            return occupiedTile;
        }
        public int GetPawnId()
        {
            return id;
        }
        public Player GetPlayer()
        {
            return associatedPlayer;
        }

        public void SetAssociatedPlayer(Player associatedPlayer)
        {
            this.associatedPlayer = associatedPlayer;
        }

        public Player GetAssociatedPlayer()
        {
            return associatedPlayer;
        }
    }
}
