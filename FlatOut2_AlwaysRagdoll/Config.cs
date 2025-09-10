using System.ComponentModel;
using FlatOut2_AlwaysRagdoll.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace FlatOut2_AlwaysRagdoll.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Ragdoll Threshold")]
        [Description("The amount of damage that will cause you to ragdoll. (The normal value is 20.0)")]
        [DefaultValue(0.5f)]
        public float RagdollThreshold { get; set; } = 0.5f;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
