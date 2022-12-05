using System;
using UnityEngine;

namespace BehavioralPatterns.SubclassSandbox
{
    public abstract class Magic : MonoBehaviour
    {
        private DateTime _theMomentThatThisMagicIsApplied = DateTime.Now;
        protected abstract int CoolDownInSeconds { get; set; }
        protected abstract string MagicName { get; set; }
        protected abstract KeyCode KeyCode { get; set; }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode))
            {
                Apply();
            }
        }

        protected void Apply()
        {
            if (GetCoolDownInSeconds() > 0)
            {
                OnApply();
                _theMomentThatThisMagicIsApplied = DateTime.Now;
            }
            else
            {
                OnCoolDownTimeNotEnded();
            }
        }

        protected int GetCoolDownInSeconds()
        {
            return (int) DateTime.Now.Subtract(_theMomentThatThisMagicIsApplied).TotalSeconds - CoolDownInSeconds;
        }

        protected void OnCoolDownTimeNotEnded()
        {
            MagicLogger.Instance.AddNewLine($"Magic {MagicName} is on cooldown for {GetCoolDownInSeconds()} seconds",
                "white");
        }

        protected abstract void OnApply();
    }
}