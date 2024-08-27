namespace ClassRoomNet60;

public class ClassRoom
{
    public string ClassName { get; private set; }
    public List<Student>StudentList { get; private set; }
    public DateTime Semesterstart { get; private set; }
    
    public ClassRoom ()
    {
        ClassName = "ClassRoomNet60";
        StudentList = new List<Student>();
        Semesterstart = new DateTime(2022, 9, 1); 
        
    }
}