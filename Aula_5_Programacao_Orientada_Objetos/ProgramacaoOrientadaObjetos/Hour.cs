using System;

namespace ProgramacaoOrientadaObjetos
{
    class Hour : AbstractHour
    {
        public byte Hours { get; set; }
        public byte Minutes { get; set; }
        public byte Seconds { get; set; }
        private readonly byte InitialHours;
        private readonly byte InitialMinutes;
        private readonly byte InitialSeconds;

        public Hour() { }
        
        public Hour(byte Hours, byte Minutes, byte Seconds)
        {
            this.Hours = InitialHours = Hours;
            this.Minutes = InitialMinutes = Minutes;
            this.Seconds = InitialSeconds = Seconds;
        }

        public override void NextSecond()
        {
            Seconds++;
        }

        public override void PreviousSecond()
        {
            Seconds--;
        }

        public override void AddSecond(byte Seconds)
        {
            for (int i = 1; i <= Seconds; i++)
            {
                Seconds++;
                if (Seconds > 60)
                {
                    Seconds = 0;
                    Minutes++;
                    if (Minutes > 60)
                    {
                        Minutes = 0;
                        Hours++;
                        if (Hours > 24)
                        {
                            Hours = 0;
                            Minutes = 0;
                            Seconds = 0;
                        }
                    }
                }
            }
        }

        public override string ElapsedTime()
        {
            return $"{Hours - InitialHours}:{Minutes - InitialMinutes}:{Minutes - InitialMinutes}";
        }

        public override int ElapsedTimeSeconds()
        {
            return 3600 * (Hours - InitialHours) + 60 * (Minutes - InitialMinutes) + (Seconds - InitialSeconds);
        }

        public override string CurrentHour()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

    }
}
