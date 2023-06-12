//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//principal class 
public class LogMessage : SceneObjectScript
{   
    //public fields show in the object properties after being added to a script.
    #region Editor Properties 


    #endregion

    //Method called when the script is initialized
    public override void Init()
    {   
        //the line will send a message to the script log that is open with Ctrl+D
        Log.Write("Hello World!");
    }
}