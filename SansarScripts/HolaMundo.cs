//Some parts of this code use content from the Sansar Knowledge Base. � 2022 Sansar, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode).

//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;


// A small starter script.
public class HelloWorld : SceneObjectScript
{
    #region EditorProperties
    // This interaction will have a default prompt of "Click Me!"
    // Public fields show in the object properties after being added to a script.
    // An Interaction public property makes the script clickable.
    [DefaultValue("Click Me!")]
    public Interaction MyInteraction;
    #endregion

    // Init() is where the script is setup and is run when the script starts.
    public override void Init()
    {
        // Subscribe to interaction events to do something when the object is clicked.
        MyInteraction.Subscribe(OnClick);
    }

    public void OnClick(InteractionData data)
    {
        // Find the agent that clicked.
        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId);

        // Send them a message.
        agent.SendChat("Hello! Thanks for clicking me.");
    }

}