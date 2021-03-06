namespace OP_LetterLabyrinth
{
    public class StrategyAddBadWord : IWordStrategy
    {
        public void DoOperation(ILetter[] word, Dictionary dictionary)
        {
            var stringWord = Dictionary.StringFromLetters(word);
            Logger.GetInstance().Log("INFO", $"Added bad word. {stringWord}");
            dictionary.AddBadWord(word);
            GameStatus.GetInstance().ConsumeCurrentWord(false);
        }
    }
}