using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BehavioralPatterns
{
    public class MagicLogger : MonoBehaviour
    {
        private Queue<IEnumerator> _coroutines = new Queue<IEnumerator>();
        private bool _writingLine;
        
        private TextMeshProUGUI _logText;

        public static MagicLogger Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            _logText = GetComponent<TextMeshProUGUI>();
            _logText.text = "";
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                _logText.text = "";
            }

            if (!_writingLine)
            {
                if (_coroutines.Count > 0)
                    StartCoroutine(_coroutines.Dequeue());
            }
        }

        public void AddNewLine(string newLine, string color)
        {
            _coroutines.Enqueue(TextLineAdder(newLine, color));
        }

        IEnumerator TextLineAdder(string text, string color)
        {
            _writingLine = true;
            var waitTime = new WaitForSeconds(.01f);
            _logText.text += "\n";
            for (var i = 0; i < text.Length; i++)
            {
                _logText.text += $"<color={color}>{text[i]}</color>";
                yield return waitTime;
            }
            _writingLine = false;

        }
    }
}