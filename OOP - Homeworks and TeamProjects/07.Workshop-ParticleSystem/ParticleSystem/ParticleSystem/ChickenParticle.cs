namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChickenParticle : ChaoticParticle
    {
        private const int DefaultDelay = 3;

        private int updateCounter;
        private int delayCounter;
        private bool layEgg;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed, randomGenerator)
        {
        }

        public override IEnumerable<Particle> Update()
        {
            if (this.layEgg)
            {
                this.delayCounter++;
                if (this.delayCounter == DefaultDelay)
                {
                    this.delayCounter = 0;
                    this.layEgg = false;
                    return this.LayEgg();
                }

                return new List<Particle>();
            }

            if (this.updateCounter == this.randomGenerator.Next(7))
            {
                this.layEgg = true;
            }

            return base.Update();
        }

        public IEnumerable<Particle> LayEgg()
        {
            return new List<Particle>() { new ChickenParticle(this.Position, this.Speed, this.randomGenerator) };
        }
    }
}
