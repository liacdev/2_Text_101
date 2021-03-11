using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextState();

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }

        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }
     
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextState[2];
        }

        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            state = nextState[3];
        }

        textComponent.text = state.GetStateStory();

    }
 
}
