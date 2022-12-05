using System.IO;
using UnityEngine;

namespace BehavioralPatterns.TypeObject
{
    public static class MagicKernelFactory
    {
        public static MagicKernelBase CreateMagicKernel(string magicName)
        {
            switch (magicName)
            {
                case "fire":
                    return new FireMagicKernel();
                case "freeze":
                    return new FreezeMagicKernel();
                case "timeTravel":
                    return new TimeTravelMagicKernel();
            }

            return new MagicKernelNullObject();
        }

        public static MagicKernelBase CreateMagicKernelFromData(string magicName)
        {
            switch (magicName)
            {
                case "fire":
                    var fireData = File.ReadAllText("./Assets/Resources/fire.json");
                    var deserializedFireKernel = JsonUtility.FromJson<MagicKernelData>(fireData);
                    return new FireMagicKernel()
                        .Setup(deserializedFireKernel.coolDown, deserializedFireKernel.magicName,
                            deserializedFireKernel.keyCode);
                case "freeze":
                    var freezeData = File.ReadAllText("./Assets/Resources/freeze.json");
                    var deserializedFreezeDataKernel = JsonUtility.FromJson<MagicKernelData>(freezeData);
                    return new FreezeMagicKernel()
                        .Setup(deserializedFreezeDataKernel.coolDown, deserializedFreezeDataKernel.magicName,
                            deserializedFreezeDataKernel.keyCode);

                case "timeTravel":
                    var timeTravelData = File.ReadAllText("./Assets/Resources/timeTravel.json");
                    var deserializedTimeTravelDataKernel = JsonUtility.FromJson<MagicKernelData>(timeTravelData);
                    return new TimeTravelMagicKernel()
                        .Setup(deserializedTimeTravelDataKernel.coolDown, deserializedTimeTravelDataKernel.magicName,
                            deserializedTimeTravelDataKernel.keyCode);
            }

            return new MagicKernelNullObject();
        }

        public class MagicKernelData
        {
            public int coolDown;
            public string magicName;
            public KeyCode keyCode;
        }
    }
}