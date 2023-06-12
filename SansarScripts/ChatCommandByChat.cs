//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//principal class 
public class ChatCommandScript : SceneObjectScript
{   
    //public fields show in the object properties after being added to a script.
    #region Editor Properties 

        [DefaultValue("Hola mundo para chatear con el chat box")]
        public readonly string Message;

    #endregion

    //Method called when the script is initialized
    public override void Init()
    {
        // Subscribe to the chat command event
        ScenePrivate.Chat.Subscribe(Chat.DefaultChannel, OnChatCommand);
    }

    private void OnChatCommand(ChatData data)
    {
        // Check if the chat message matches the command
        if (data.Message.ToLower() == "/say")
        {
            // Send the message to the player's chat
            ScenePrivate.Chat.MessageAllUsers(Message);
        }
    }
}