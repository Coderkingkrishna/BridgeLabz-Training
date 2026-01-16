class Program
{
    static void Main()
    {
        BrowserBuddy browser = new BrowserBuddy();

        browser.VisitPage("google");
        browser.VisitPage("github");
        browser.VisitPage("leetcode");

        browser.Back();
        browser.Back();
        browser.Forward();

        browser.ShowCurrent();

        browser.CloseTab();
        browser.RestoreTab();

        browser.ShowCurrent();
    }
}
