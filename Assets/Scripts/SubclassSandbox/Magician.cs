using UnityEngine;

namespace BehavioralPatterns.SubclassSandbox
{
    public class Magician : MonoBehaviour
    {
        private void Start()
        {
            MagicLogger.Instance.AddNewLine("SubclassSandbox Magician says hello!","green");

            gameObject.AddComponent<FreezeMagic>();
            gameObject.AddComponent<FireMagic>();
            gameObject.AddComponent<TimeTravelMagic>();
        }
    }
}