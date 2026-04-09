using UnityEngine;

public class StudentsMoveManager : MonoBehaviour
{
    public MoveToTarget[] students;

    public void MoveStudents()
    {
        foreach (MoveToTarget student in students)
        {
            if (student != null)
            {
                student.MoveNow();
            }
        }
    }
}