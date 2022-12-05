using UnityEngine;

namespace BehavioralPatterns.SubclassSandbox
{
    public class FreezeMagic : Magic
    {
        protected override int CoolDownInSeconds { get; set; } = 3;
        protected override string MagicName { get; set; } = "Freeze";
        protected override KeyCode KeyCode { get; set; } = KeyCode.Alpha3;

        protected override void OnApply()
        {
            MagicLogger.Instance.AddNewLine("Freezing the target!", "blue");
        }
    }
}