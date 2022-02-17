using UnityEngine;
namespace Paku.Data
{

    public static class DataControllerLite
    {
        /* Simple Data Controller using the PlayerPref System.
            * Manages [ Score, Highscore, SFX Volume, Sound Track Volume]
            * By @PAKUBK
            * Thank you @Renaissance Coders
        */

        private static readonly string DataScore = "score";
        private static readonly string DataHighscore = "highscore";
        private static readonly string DataSFXVolume = "sfx_volume";
        private static readonly string DataSTVolume = "st_volume";
        private static readonly float DefaultFloat = 0f;

        #region Static Properties
        public static float Score
        {
            get { return GetFloat(DataScore); }

            set
            {
                SaveFloat(DataScore, value);
                float _score = Score;
                if (_score > Highscore)
                {
                    Highscore = _score;
                }
            }
        }

        public static float Highscore
        {
            get { return GetFloat(DataHighscore); }

            private set
            {
                SaveFloat(DataHighscore, value);
            }
        }
        public static float SFXVolume
        {
            get { return GetFloat(DataSFXVolume); }

            set
            {
                SaveFloat(DataSFXVolume, value);
            }
        }
        public static float STVolume
        {
            get { return GetFloat(DataSTVolume); }

            set
            {
                SaveFloat(DataSTVolume, value);
            }
        }
        #endregion

        #region Private Functions
        private static void SaveFloat(string _data, float _value)
        {
            PlayerPrefs.SetFloat(_data, _value);
        }

        private static float GetFloat(string _data)
        {
            return PlayerPrefs.GetFloat(_data, DefaultFloat);
        }
        #endregion
    }
}