namespace SingleResponsibilityPrinciple;
public class Report
{
    public string Content { get; set; } = string.Empty;

    public Report()
    {
    }

    public void GenerateReport(string content)
    {
        Content = content;
    }

}

public class ReportLoader
{
    public static void SaveToFile(string filename, Report report)
    {
        File.WriteAllText(filename, report.Content);
    }

    public static string LoadFromFile(string filename)
    {
        return File.ReadAllText(filename);
    }
}

public class ReportFormatter
{
    public static string FormatReport(string content)
    {
        return content.ToLower();
    }
}
