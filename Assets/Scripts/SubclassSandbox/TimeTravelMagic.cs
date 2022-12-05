using UnityEngine;

namespace BehavioralPatterns.SubclassSandbox
{
    public class TimeTravelMagic : Magic
    {
        protected override int CoolDownInSeconds { get; set; } = 5;
        protected override string MagicName { get; set; } = "TimeTravel";
        protected override KeyCode KeyCode { get; set; } = KeyCode.Alpha2;

        protected override void OnApply()
        {
            MagicLogger.Instance.AddNewLine("Time traveling!", "yellow");
        }
    }
}