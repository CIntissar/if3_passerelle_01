using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public enum MovementType{
        Rotation,
        Translation           
    }

    public enum Pivot{
        Global,
        Local
    }

    [System.Serializable]
    public struct Movement{

        public MovementType type;
        public Space space;
        public float speed;
        public Vector3 direction;

    }
   
    public List<Movement> movements;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
                
        foreach(Movement mov in movements){

            
            if (mov.type == MovementType.Rotation)   
            {
                transform.Rotate(mov.direction.normalized * mov.speed* Time.deltaTime,mov.space);
            }
            else if (mov.type == MovementType.Translation)
            {
                transform.Translate(mov.direction.normalized * mov.speed * Time.deltaTime,mov.space);
            }
            
        }
        
        
        // switch(mov.type){
        //     case MovementType.Rotation:     
        //         transform.Rotate(mov.direction * mov.speed* Time.deltaTime,Space.World);
        //         break;
        //     case MovementType.Translation:
        //         transform.Translate(mov.direction * mov.speed * Time.deltaTime,Space.World);
        //         break;
        // }       
    }
    
    
}
