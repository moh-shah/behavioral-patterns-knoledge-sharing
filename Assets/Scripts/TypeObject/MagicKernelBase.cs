using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public abstract class MagicKernelBase
    {
        public abstract int CoolDownInSeconds { get; set; }
        public abstract string MagicName { get; set; }
        public abstract KeyCode KeyCode { get; set; }
        public abstract void OnApply();

        public MagicKernelBase Setup(int cooldown, string magicName, KeyCode keyCode)
        {
            CoolDownInSeconds = cooldown;
            MagicName = magicName;
            KeyCode = keyCode;
            return this;
        }
    }

    public class MagicKernelNullObject : MagicKernelBase
    {
        public override int CoolDownInSeconds { get; set; }
        public override string MagicName { get; set; }
        public override KeyCode KeyCode { get; set; }
        public override void OnApply()
        {
            
        }
    }
}