namespace Reseloggen;

class Destination
{
    public string name;
    public string description;
    public int grade;
    public int year;

    public Destination(string aName, string aDescritption, int aGrade, int aYear)
    {
        name = aName;
        description = aDescritption;
        grade = aGrade;
        year = aYear;
    }
}
