namespace ExCesarRev
{
    class Cesar
    {
        private int _clef;

        public Cesar(int clef)
        {
            _clef = clef;
        }

        public string Chiffrer(string phrase)
        {
            char[] array = phrase.ToCharArray();

            for (int i = 0; i < phrase.Length; i++)
            {
                int code = phrase[i] + _clef;
                if (code > 'z')
                    code -= (26 - _clef);
                array[i] = (char)(code);
            }
            return new string(array);
        }

        public string Dechiffrer(string phraseADechiffrer)
        {
            char[] array = phraseADechiffrer.ToCharArray();

            for (int i = 0; i < phraseADechiffrer.Length; i++)
            {
                int code = phraseADechiffrer[i] - _clef;
                if (code < 'a')
                    code += (26 - _clef);
                array[i] = (char)(code);
            }
            return new string(array);
        }


    }
}
