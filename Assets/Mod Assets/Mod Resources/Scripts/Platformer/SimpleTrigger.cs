using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{

    public Rigidbody2D triggerBody; 
    public UnityEvent onTriggerEnter;


    void OnTriggerEnter2D(Collider2D other){ // other est le parametre de la fonction
        //do not trigger if there's no trigger target object
        if (triggerBody == null) return;

        //only trigger if the triggerBody matches
        var hitRb = other.attachedRigidbody;
        if (hitRb == triggerBody){ //si le body qui rentre correspond a celui qui a été targeté, alors l'event s'enclenche.
            onTriggerEnter.Invoke();
        }
    }

}
