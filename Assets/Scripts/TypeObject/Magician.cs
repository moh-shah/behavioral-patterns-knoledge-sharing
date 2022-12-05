using System;
using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public class Magician : MonoBehaviour
    {
 
        private void Start()
        {
            MagicLogger.Instance.AddNewLine("TypeObject Magician says hello!","green");

            //AddMagics1();
            AddMagics2();
        }

        void AddMagics1()
        {
            var fireMagicKernel = MagicKernelFactory.CreateMagicKernel("fire")
                .Setup(2, "Fire", KeyCode.Alpha1);
            gameObject.AddComponent<Magic>().SetKernel(fireMagicKernel);


            var freezeMagicKernel = MagicKernelFactory.CreateMagicKernel("freeze")
                .Setup(3, "freeze", KeyCode.Alpha2);
            gameObject.AddComponent<Magic>().SetKernel(freezeMagicKernel);

            var timeTravelMagicKernel = MagicKernelFactory.CreateMagicKernel("timeTravel")
                .Setup(4, "timeTravel", KeyCode.Alpha3);
            gameObject.AddComponent<Magic>().SetKernel(timeTravelMagicKernel);
        }
        
        void AddMagics2()
        {
            var fireMagicKernel = MagicKernelFactory.CreateMagicKernelFromData("fire");
            gameObject.AddComponent<Magic>().SetKernel(fireMagicKernel);
 
            
            var freezeMagicKernel = MagicKernelFactory.CreateMagicKernelFromData("freeze");
            gameObject.AddComponent<Magic>().SetKernel(freezeMagicKernel);

            var timeTravelMagicKernel = MagicKernelFactory.CreateMagicKernelFromData("timeTravel");
            gameObject.AddComponent<Magic>().SetKernel(timeTravelMagicKernel);
        }
    }
}