//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//principal class 
public class SendMessageToChatStart : SceneObjectScript
{
    //public fields show in the object properties after being added to a script.
    #region EditorProperties

        [DefaultValue("Hello, sansariano :D!")]
        public string message;
    
    #endregion

    //Method called when the script is initialized
    public override void Init()
    {   
        //the event is triggered when a user enter the scene, this call the method OnUserEnter
        ScenePrivate.User.Subscribe(User.AddUser, OnUserEnter);
    }

    //this method use the user data, which contain information about the user that enter the scene
    private void OnUserEnter(UserData userData)
    {
        //this method sent a message to all users in the scene
        ScenePrivate.Chat.MessageAllUsers(message);
    }
    
}