namespace ParticleSystem
{
    using System;

    public class ChaoticParticle : Particle
    {
        private const int MIN_SPEED = -2;
        private const int MAX_SPEED = 3;

        protected readonly Random randomGenerator;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed)
        {
            this.randomGenerator = randomGenerator;
        }

        protected override void Move()
        {
            this.Speed = new MatrixCoords(this.randomGenerator.Next(MIN_SPEED, MAX_SPEED), this.randomGenerator.Next(MIN_SPEED, MAX_SPEED));
            base.Move();
        }
    }
}
