namespace practice.Implementions;

public class GroupManagerEntity
{
    // Метод для створення нової групи
    public GroupEntity CreateGroup(string groupName)
    {
        return new GroupEntity { GroupName = groupName };
    }
}