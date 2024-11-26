namespace RustHub.Components.Services.RaidCalc.Matrix
{
    public class BuildingResources
    {
        public class Wall
        {
            public int Health { get; set; }
            public Dictionary<string, int> DamageArray { get; set; }
        }

        public Wall GetWoodWall()
        {
            return new Wall
            {
                Health = 250,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", -1 },
                { "rocketDamage", 247 },
                { "satchelDamage", 91 },
                { "beancanDamage", 19 },
                { "exploAmmoDamage", 5 }
            }
            };
        }

        public Wall GetStoneWall()
        {
            return new Wall
            {
                Health = 500,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", 275 },
                { "rocketDamage", 137 },
                { "satchelDamage", 51 },
                { "beancanDamage", 11 },
                { "exploAmmoDamage", 2 }
            }
            };
        }

        public Wall GetMetalWall()
        {
            return new Wall
            {
                Health = 1000,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", 275 },
                { "rocketDamage", 137 },
                { "satchelDamage", 43 },
                { "beancanDamage", 9 },
                { "exploAmmoDamage", 2 }
            }
            };
        }

        public Wall GetHqmWall()
        {
            return new Wall
            {
                Health = 2000,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", 275 },
                { "rocketDamage", 137 },
                { "satchelDamage", 43 },
                { "beancanDamage", 9 },
                { "exploAmmoDamage", 2 }
            }
            };
        }

        public Wall GetWoodDoor()
        {
            return new Wall
            {
                Health = 200,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", -1 },
                { "rocketDamage", -1 },
                { "satchelDamage", 170 },
                { "beancanDamage", 35 },
                { "exploAmmoDamage", 11 }
            }
            };
        }

        public Wall GetMetalDoor()
        {
            return new Wall
            {
                Health = 250,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", -1 },
                { "rocketDamage", 220 },
                { "satchelDamage", 70 },
                { "beancanDamage", 14 },
                { "exploAmmoDamage", 4 }
            }
            };
        }

        public Wall GetGarageDoor()
        {
            return new Wall
            {
                Health = 600,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", 440 },
                { "rocketDamage", 220 },
                { "satchelDamage", 70 },
                { "beancanDamage", 14 },
                { "exploAmmoDamage", 4 }
            }
            };
        }

        public Wall GetHqmDoor()
        {
            return new Wall
            {
                Health = 800,
                DamageArray = new Dictionary<string, int>
            {
                { "c4Damage", 440 },
                { "rocketDamage", 220 },
                { "satchelDamage", 70 },
                { "beancanDamage", 14 },
                { "exploAmmoDamage", 4 }
            }
            };
        }


    }
}
