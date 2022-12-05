using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public class FreezeMagicKernel :  MagicKernelBase
    {
        public override int CoolDownInSeconds { get; set; }
        public override string MagicName { get; set; }
        public override KeyCode KeyCode { get; set; }
        public override void OnApply()
        {
            MagicLogger.Instance.AddNewLine("Freezing the target!", "blue");
        }
    }
}