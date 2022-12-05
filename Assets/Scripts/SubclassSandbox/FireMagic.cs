using UnityEngine;

namespace BehavioralPatterns.SubclassSandbox
{
    public class FireMagic : Magic
    {
        protected override int CoolDownInSeconds { get; set; } = 2;
        protected override string MagicName { get; set; } = "Fire";
        protected override KeyCode KeyCode { get; set; } = KeyCode.Alpha1;

        protected override void OnApply()
        {
            MagicLogger.Instance.AddNewLine("I'm on fire!", "red");
        }
    }
}