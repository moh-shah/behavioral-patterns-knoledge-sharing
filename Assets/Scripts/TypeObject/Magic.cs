using System;
using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public class Magic : MonoBehaviour
    {
        public int CoolDownInSeconds
        {
            get => _magicKernel.CoolDownInSeconds;
            set => _magicKernel.CoolDownInSeconds = value;
        }

        public string MagicName
        {
            get => _magicKernel.MagicName;
            set => _magicKernel.MagicName = value;
        }

        public KeyCode KeyCode
        {
            get => _magicKernel.KeyCode;
            set => _magicKernel.KeyCode = value;
        }

        private DateTime _theMomentThatThisMagicIsApplied = DateTime.Now;
        private MagicKernelBase _magicKernel;


        public void SetKernel(MagicKernelBase magicKernel)
        {
            _magicKernel = magicKernel;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode))
            {
                Apply();
            }
        }

        private void Apply()
        {
            if (GetCoolDownInSeconds() > 0)
            {
                _magicKernel.OnApply();
                _theMomentThatThisMagicIsApplied = DateTime.Now;
            }
            else
            {
                OnCoolDownTimeNotEnded();
            }
        }

        private int GetCoolDownInSeconds()
        {
            return (int) DateTime.Now.Subtract(_theMomentThatThisMagicIsApplied).TotalSeconds - CoolDownInSeconds;
        }

        private void OnCoolDownTimeNotEnded()
        {
            MagicLogger.Instance.AddNewLine($"Magic {MagicName} is on cooldown for {GetCoolDownInSeconds()} seconds",
                "white");
        }
    }
}