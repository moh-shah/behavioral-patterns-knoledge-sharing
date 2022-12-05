using System;
using System.Collections.Generic;
using UnityEngine;

namespace BehavioralPatterns.Bytecode
{
    public class VirtualMachine : MonoBehaviour
    {
        private Stack<int>  _valueStack = new Stack<int>();

        [SerializeField] private int[] _bytecode;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Interpret(_bytecode);
            }
        }

        private void Interpret(int[] bytecode)
        {
            for (var index = 0; index < bytecode.Length; index++)
            {
                var instruction = bytecode[index];
                switch (instruction)
                {
                    case (int) InstructionSet.DoFireMagic:
                        MagicLogger.Instance.AddNewLine("doing fire magic", "red");
                        break;
                    
                    case (int) InstructionSet.DoFreezeMagic:
                        MagicLogger.Instance.AddNewLine("doing fire magic", "blue");
                        break;
                    
                    case (int) InstructionSet.DealDamage:
                        var damageAmount = _valueStack.Pop();
                        MagicLogger.Instance.AddNewLine($"dealing {damageAmount} damage", "orange");
                        break;
                    
                    case (int) InstructionSet.AddValue:
                        _valueStack.Push(bytecode[index+1]);
                        break;
                    
                    case (int) InstructionSet.SelectMagician:
                        var magicianIndex = _valueStack.Pop();
                        MagicLogger.Instance.AddNewLine($"magician {magicianIndex} is selected", "yellow");
                        break;
                }
            }
        }
    }
    
    public enum InstructionSet
    {
        DoFireMagic = 1,
        DoFreezeMagic = 2,
        DealDamage = 3,
        AddValue = 4,
        SelectMagician = 5
    }
}