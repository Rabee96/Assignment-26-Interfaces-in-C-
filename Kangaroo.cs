using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class Kangaroo : Creature , IJumpable ,IRunnable
    {
        override public void Speak(){
            Debug.Log("Kangaroo says: Hop!");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
    }

    public class Duck : Creature , ISwimmable ,IRunnable
    {
        override public void Speak(){
            Debug.Log("Duck says: Quack!");
        }
        public void Run()
        {
            Debug.Log("Duck swims.");
        }

        public void Swim()
        {
            Debug.Log("Duck runs.");
        }
    }
}

