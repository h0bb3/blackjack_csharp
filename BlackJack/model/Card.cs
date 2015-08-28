using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Card
    {
        public enum Color
        {
            Hearts = 0,
            Spades,
            Diamonds,
            Clubs,
            Count,
            Hidden
        }

        public enum Value
        {
            Two = 0,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Knight,
            Queen,
            King,
            Ace,
            Count,
            Hidden
        }

        private Color m_color;
        private Value m_value;
        private bool m_isHidden;

        public Card(Color a_color, Value a_value)
        {
            m_value = a_value;
            m_color = a_color;
            m_isHidden = true;
        }

        public Color GetColor()
        {
            if (m_isHidden)
            {
                return Color.Hidden;
            }
            return m_color;
        }

        public Value GetValue()
        {
            if (m_isHidden)
            {
                return Value.Hidden;
            }
            return m_value;
        }

        public void Show(bool a_show)
        {
            m_isHidden = !a_show;
        }
    }
}
