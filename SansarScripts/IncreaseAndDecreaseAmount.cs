using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class AngleCounter : SceneObjectScript
{
    // Public properties
        //Steps in which the code is moved
        [DefaultValue(15)]
        public readonly int StepSize =15;

        [DefaultValue("Press Me")]
        public Interaction MyInteraction;
    
    // Private variables
        [DefaultValue(0)]
        private int currentAngle = 0;

        [DefaultValue("true")]
        private bool isIncreasing = true;

    // Script Start
    public override void Init()
    {
        MyInteraction.Subscribe(OnClick);
    }

    //This void the thing that do is the addition and substraction of the degrees 
    public void OnClick(InteractionData data)
    {
        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId);
        
        // Increase or decrease the angle
        if (isIncreasing)
        {
            currentAngle += StepSize;  
            //the max number/degree/etc..
            if (currentAngle >= 360)
            {
                isIncreasing = false;
            }
        }
        else
        {
            currentAngle -= StepSize;
            //the min number/degree/etc..
            if (currentAngle <= 0)
            {
                isIncreasing = true;
            }
        }
        // Show the angle to the user
        string message = $"The current angle is {currentAngle} degrees.";
        ScenePrivate.Chat.MessageAllUsers(message);
    }
}