namespace SingleResponsibilityPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Report report = new Report();
        report.GenerateReport("This is some content.");
        report.Content = ReportFormatter.FormatReport(report.Content);

        try
        {
            ReportLoader.SaveToFile("report.txt", report);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        try
        {
            report.Content = ReportLoader.LoadFromFile("report.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
}