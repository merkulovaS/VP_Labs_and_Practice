using UniversityApp;

namespace StringInfoLibrary;

public static class GroupExtensions
{
    
    public static string GetStudentsStatistics(this Group group)
    {
        if (group == null)
        {
            return "Группа не задана (null).";
        }

        
        try
        {
            var studentsField = typeof(Group).GetField("_students", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var students = studentsField?.GetValue(group) as Student[];

            if (students == null || students.Length == 0)
            {
                return $"Группа {GetGroupNumber(group)}: нет студентов.";
            }

            int totalStudents = students.Length;
            int budgetCount = students.Count(s => s.Form == StudyForm.Budget);
            int commercialCount = students.Count(s => s.Form == StudyForm.Commercial);
            int targetCount = students.Count(s => s.Form == StudyForm.Target);

            return $"Группа {GetGroupNumber(group)}:\n" +
                   $"  Всего студентов: {totalStudents}\n" +
                   $"  Бюджет: {budgetCount}\n" +
                   $"  Коммерция: {commercialCount}\n" +
                   $"  Целевое: {targetCount}";
        }
        catch (Exception ex)
        {
            return $"Ошибка получения статистики: {ex.Message}";
        }
    }

    // Вспомогательный метод для получения номера группы через рефлексию (для демонстрации)
    private static string GetGroupNumber(Group group)
    {
        var numberField = typeof(Group).GetField("_groupNumber", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        return numberField?.GetValue(group) as string ?? "Неизвестно";
    }
}