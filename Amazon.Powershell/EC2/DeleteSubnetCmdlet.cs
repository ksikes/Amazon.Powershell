namespace Amazon.Powershell.EC2
{
    using Amazon.EC2.Model;
    using Amazon.EC2;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, EC2Nouns.SUBNET)]
    public class DeleteSubnetCmdlet : EC2CmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
