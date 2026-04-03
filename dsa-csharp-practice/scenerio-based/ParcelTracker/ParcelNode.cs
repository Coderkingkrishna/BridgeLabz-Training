class ParcelNode
{
    private string stageName;
    private ParcelNode next;

    public ParcelNode(string stageName)
    {
        this.stageName = stageName;
        this.next = null;
    }

    public string StageName
    {
        get { return stageName; }
        set { stageName = value; }
    }

    public ParcelNode Next
    {
        get { return next; }
        set { next = value; }
    }

    public override string ToString()
    {
        return "Stage: " + stageName;
    }
}
