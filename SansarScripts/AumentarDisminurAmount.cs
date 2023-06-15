using Sansar;
using Sansar.Script;
using Sansar.Simulation;
using System;

public class NumberCounter : SceneObjectScript
{

    #region Editor Properties

        // Public properties

            [Tooltip("Size of the steps that the code will perform")] 
            [DisplayName("Steps")]
            [DefaultValue(1.0f)]
            public float StepSize;

            [Tooltip("Give a name for the Interaction")] 
            [DisplayName("Name Interaction")]
            [DefaultValue("Click on me")]
            public Interaction MyInteraction;

            [Tooltip("Write the max number or the top")] 
            [DisplayName("Number Max")]
            [DefaultValue(10f)]
            public float Max;

            [Tooltip("Write the min number or the down")] 
            [DisplayName("Number Min")]
            public float Min;

            [Tooltip("Write the number where starts")] 
            [DisplayName("StartNumber")]
            [DefaultValue(0f)]
            public float StartNumber;

        // Private variables

            private float CurrentNumber;

            private bool isIncreasing = true;



    #endregion


    public override void Init()
    {
        
        CurrentNumber = StartNumber;

        if((StartNumber >= Min)&&(StartNumber <= Max)){

            MyInteraction.Subscribe(OnClick);

        }

    }

    public void OnClick(InteractionData data)
    {
        

        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId);

        // Increase or decrease the angle
        if (isIncreasing)
        {
            CurrentNumber += StepSize;
            if (CurrentNumber >= Max)
            {
                isIncreasing = false;
            }
        }
        else
        {
            CurrentNumber -= StepSize;
            if (CurrentNumber <= Min)
            {
                isIncreasing = true;
            }
        }

        // Show the angle to the user
        string message = $"The current angle is {CurrentNumber} degrees.";
        ScenePrivate.Chat.MessageAllUsers(message);
    }
}