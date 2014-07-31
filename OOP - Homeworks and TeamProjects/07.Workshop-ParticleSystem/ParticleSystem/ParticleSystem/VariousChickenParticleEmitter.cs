namespace ParticleSystem
{
    using System;

    public class VariousChickenParticleEmitter : ParticleEmitter
    {
        public VariousChickenParticleEmitter(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed, randomGenerator)
        {
        }

        protected override Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
        {
            return new ChickenParticle(position, speed, this.randomGenerator);
        }
    }
}
