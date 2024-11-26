namespace RustHub.Components.Services.RaidCalc.Matrix
{
    public class RaidingResource
    {
        public class ResourceCost
        {
            public int Sulfur { get; set; }
            public int Charcoal { get; set; }
            public int MetalFragments { get; set; }
            public int LowGradeFuel { get; set; }
            public int MetalPipes { get; set; }
            public int Cloth { get; set; }
            public int Rope { get; set; }
            public int TechTrash { get; set; }
        }

        public ResourceCost GetRocketCost(int amount)
        {
            return new ResourceCost
            {
                Sulfur = 1400 * amount,
                Charcoal = 1950 * amount,
                MetalFragments = 100 * amount,
                LowGradeFuel = 30 * amount,
                MetalPipes = 2 * amount
            };
        }

        public ResourceCost GetSatchelCost(int amount)
        {
            return new ResourceCost
            {
                Sulfur = 420 * amount,
                Charcoal = 720 * amount,
                MetalFragments = 80 * amount,
                Cloth = 10 * amount,
                Rope = 1 * amount
            };
        }

        public ResourceCost GetC4Cost(int amount)
        {
            return new ResourceCost
            {
                Sulfur = 2200 * amount,
                Charcoal = 3000 * amount,
                MetalFragments = 200 * amount,
                LowGradeFuel = 60 * amount,
                Cloth = 5 * amount,
                TechTrash = 2 * amount
            };
        }

        public ResourceCost GetExploAmmoCost(int amount)
        {
            return new ResourceCost
            {
                Sulfur = 50 * amount,
                Charcoal = 60 * amount,
                MetalFragments = 10 * amount
            };
        }

        public ResourceCost GetBeancanCost(int amount)
        {
            return new ResourceCost
            {
                Sulfur = 120 * amount,
                Charcoal = 180 * amount,
                MetalFragments = 20 * amount
            };
        }
    }
}
