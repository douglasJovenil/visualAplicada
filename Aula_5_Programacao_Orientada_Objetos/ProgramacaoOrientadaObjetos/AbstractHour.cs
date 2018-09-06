namespace ProgramacaoOrientadaObjetos
{
    abstract class AbstractHour
    {
        public abstract void NextSecond();
        public abstract void PreviousSecond();
        public abstract void AddSecond(byte Seconds);
        public abstract string ElapsedTime();
        public abstract int ElapsedTimeSeconds();
        public abstract string CurrentHour();
    }
}
