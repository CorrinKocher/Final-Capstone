namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
               
        }
        public string TypeOfFruit { get; }

        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if(PiecesOfFruitLeft - numberOfPiecesToRemove >= 0)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

