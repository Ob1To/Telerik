namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int pushAwayPower) :
            base(position, speed)
        {
            this.Power = pushAwayPower;
        }

        public int Power { get; private set; }
    }
}
