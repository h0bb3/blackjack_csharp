using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Deck
    {
        List<Card> m_cards;

        public Deck()
        {
            m_cards = new List<Card>();

            for (int colorIx = 0; colorIx < (int)Card.Color.Count; colorIx++)
            {
                for (int valueIx = 0; valueIx < (int)Card.Value.Count; valueIx++)
                {
                    Card c = new Card((Card.Color)colorIx, (Card.Value)valueIx);
                    AddCard(c);
                }
            }

            Shuffle();
        }

        public Card GetCard()
        {
            Card c = m_cards.First();
            m_cards.RemoveAt(0);
            return c;
        }

        public void AddCard(Card a_c)
        {
            m_cards.Add(a_c);
        }

        public IEnumerable<Card> GetCards()
        {
            return m_cards.Cast<Card>();
        }

        private void Shuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < 1017; i++)
            {
                int index = rnd.Next() % m_cards.Count;
                Card c = m_cards.ElementAt(index);
                m_cards.RemoveAt(index);
                m_cards.Add(c);
            }
        }
    }
}
