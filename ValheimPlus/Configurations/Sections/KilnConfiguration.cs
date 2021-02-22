﻿namespace ValheimPlus.Configurations.Sections
{
    public class KilnConfiguration : ServerSyncConfig<KilnConfiguration>
    {
        public float ProductionSpeed { get; set; } = 10;
        public int MaximumWood { get; internal set; } = 25;
        public bool AutoDeposit { get; set; } = false;
        public float AutoDepositRange { get; set; } = 10;
    }

}
