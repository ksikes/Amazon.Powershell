namespace Amazon.Powershell.SimpleDB
{
    using Amazon.SimpleDB.Model;
    using Amazon.SimpleDB;
    using Amazon.Powershell.Model;
    using System.Management.Automation;
    
    [Cmdlet(Verbs.DELETE, SimpleDBNouns.DOMAIN)]
    public class DeleteDomainCmdlet : SimpleDBCmdLet
    {
        protected override void EndProcessing()
        {
            throw new System.NotImplementedException();
        }
    }
}
