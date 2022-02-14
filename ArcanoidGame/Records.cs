using System;

namespace ArcanoidGame
{
    [Serializable]
    class Records
    {
        private int score;
        private string day;
        private string time;

        public Records(int score, string day, string time)
        {
            this.score = score;
            this.day = day;
            this.time = time;
        }

        public int Get_Record_Score()
        {
            return score;
        }

        public string Get_Record_Date()
        {
            return day;
        }

        public string Get_Record_Time()
        {
            return time;
        }
    }
}
