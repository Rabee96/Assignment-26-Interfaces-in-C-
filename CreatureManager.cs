using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        List<Creature> creatures;
        List<IRunnable> iRunnable;
        List<IJumpable> iJumpable;
        List<ISwimmable> iSwimmable;

        // Start is called before the first frame update
        void Start()
        {
            iRunnable = new();
            iJumpable = new();
            iSwimmable = new();
            creatures = new();

            Kangaroo kangaroo = new();
            Duck duck = new();
            

            creatures.Add(kangaroo);
            creatures.Add(duck);

            iJumpable.Add(kangaroo);
            iRunnable.Add(kangaroo);

            iSwimmable.Add(duck);
            iRunnable.Add(duck);


            Debug.Log("***************START*********************");

            creatures[0].Speak();
            creatures[1].Speak();

            Debug.Log("*****************************************");

            iRunnable[0].Run();
            iRunnable[1].Run();

            Debug.Log("*****************************************");

            iJumpable[0].Jump();
            
            Debug.Log("*****************************************");

            iSwimmable[0].Swim();
        
            Debug.Log("******************END********************");

        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

