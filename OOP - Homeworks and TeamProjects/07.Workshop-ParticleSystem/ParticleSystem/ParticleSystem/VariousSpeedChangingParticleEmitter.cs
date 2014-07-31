namespace ParticleSystem
{
    using System;

    public class VariousSpeedChangingParticleEmitter : ParticleEmitter
    {
        public VariousSpeedChangingParticleEmitter(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed, randomGenerator)
        {
        }

        protected override Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
        {
            return new ChaoticParticle(position, speed, this.randomGenerator);
        }
    }
}
