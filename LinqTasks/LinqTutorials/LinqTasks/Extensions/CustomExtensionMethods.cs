using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        // var listOfEmployers = emps.Select(emp => emp.Mgr).Where(emp=>emp != null)
        //     .Distinct().OrderBy(emp=>emp.Ename).OrderByDescending(emp=>emp.Salary);
        return emps.Select(emp => emp.Mgr).Where(emp=>emp != null)
            .Distinct().OrderBy(emp=>emp.Ename).ThenByDescending(emp=>emp.Salary);
    }
}