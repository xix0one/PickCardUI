namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        /// <summary>
        /// Выбирает несколько карт и возвращает их.
        /// </summary>
        /// <param name="numberOfCards">Кол-во выбираемых карт.</param>
        /// <returns>Массив строк с названиями карт.</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int v = random.Next(1, 5);

            switch (v)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Hearts";
                case 3:
                    return "Clubs";
            }
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int v = random.Next(1, 14);

            switch (v)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
            }
            return v.ToString();
        }
    }
}
