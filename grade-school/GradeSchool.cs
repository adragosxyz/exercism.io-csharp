using System;
using System.Collections.Generic;

public class Student {
    public string Name {get;set;}
    public int Grade {get;set;}
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}
public class GradeSchool
{
    private List<Student> _Students = new List<Student>();
    public void Add(string student, int grade)
    {
        _Students.Add(
            new Student(
                student,
                grade
        ));
    }

    private void sortStudents()
    {
        _Students.Sort(
            delegate(Student a, Student b)
            {
                if (a.Grade != b.Grade) return a.Grade - b.Grade;
                else {
                    return String.Compare(a.Name, b.Name);
                }
            }
        );
    }


    public IEnumerable<string> Roster()
    {
        sortStudents();
        List<string> roster = new List<string>();
        foreach (Student student in _Students)
        {
            roster.Add(student.Name);
        }
        return roster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        sortStudents();
        List<string> grade_list = new List<string>();
        foreach (Student student in _Students)
        {
            if (student.Grade == grade)
                grade_list.Add(student.Name);
        }
        return grade_list;
    }
}