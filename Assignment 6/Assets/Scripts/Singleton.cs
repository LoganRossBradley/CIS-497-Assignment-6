using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}