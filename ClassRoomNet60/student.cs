namespace ClassRoomNet60;

public class student
{
    public string Name { get; private set; }
    public int BirthMonth { get; private set; }
    public int BirthDay { get; private set; }

    public student(string name, int birthMonth, int birthDay)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }
}