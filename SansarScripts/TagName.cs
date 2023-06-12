//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//principal class 
public class TagName : SceneObjectScript
{   
    //public fields show in the object properties after being added to a script.
    #region Editor Properties 

        [DefaultValue("Name Object")]
        public Interaction MyInteraction;

    #endregion

    //Method called when the script is initialized
    public override void Init()
    {
        
    }
}