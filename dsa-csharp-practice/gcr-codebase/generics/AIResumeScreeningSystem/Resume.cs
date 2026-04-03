using System.Collections.Generic;

// Generic Resume processor with constraint
class Resume<T>
    where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T role)
    {
        resumes.Add(role);
    }

    public List<T> GetResumes()
    {
        return resumes;
    }
}
