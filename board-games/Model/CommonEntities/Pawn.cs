namespace board_games.Model.CommonEntities
{
    internal class Pawn
    {
        private int pawnId;
        private Tile occupiedTile;
        private Player associatedPlayer;

        public Pawn(int pawnId, Tile occupiedTile)
        {
            this.pawnId = pawnId;
            this.occupiedTile = occupiedTile;
        }

        public Pawn(int pawnId, Tile occupiedTile, Player associatedPlayer)
        {
            this.pawnId = pawnId;
            this.occupiedTile = occupiedTile;
            this.associatedPlayer = associatedPlayer;
        }

        public void ChangeTile(Tile tileToChangeTo)
        {
            occupiedTile = tileToChangeTo;
        }
        public Tile GetOccupiedTile() {
            return occupiedTile;
        }
        public int GetPawnId() { return pawnId; }
        public Player GetPlayer() {
            return associatedPlayer;
        }

        public void SetAssociatedPlayer(Player associatedPlayer)
        {
            this.associatedPlayer = associatedPlayer;
        }

    }
}
