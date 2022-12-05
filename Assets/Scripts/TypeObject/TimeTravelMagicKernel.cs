using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public class TimeTravelMagicKernel :  MagicKernelBase
    {
        public override int CoolDownInSeconds { get; set; }
        public override string MagicName { get; set; }
        public override KeyCode KeyCode { get; set; }
        public override void OnApply()
        {
            MagicLogger.Instance.AddNewLine("Time traveling!", "yellow");
        }
    }
}