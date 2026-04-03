interface IParcelTracker
{
    void AddStage(string stageName);
    void AddAfter(string existingStage, string newStage);
    void DisplayTracking();
}
