using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class Lesson
    {
        public Weekday date;
        public Time time;
        public Teacher teacher;
        public Cabinet cabinet;
        public string GroupName;
        public string CourseName;
        public Type Type;


        public static Lesson GetLesson(int number, string date, string groupName)
        {
            ConnectionTo database = new ConnectionTo();

            var lesson = new Lesson()
            {
                cabinet = new Cabinet(),
                teacher = new Teacher(),
                date = new Weekday(),
                time = new Time(),
                GroupName = groupName
            };

            database.QueryExecuteReader("select course_name, type, teacher_fio, auditory_name from [Lesson] where (lesson_date = '" + date + "') AND (lesson_time = " + number + ") AND (group_name = '" + groupName + "')");

            if (!database.reader.Read())
            {
                return null;
            }
            lesson.CourseName = database.reader["course_name"].ToString();
            lesson.Type = database.reader["type"].ToString();
            lesson.Teacher.FIO = database.reader["teacher_fio"].ToString();
            lesson.Auditory.Name = database.reader["auditory_name"].ToString();

            database.CloseConnection();
            return lesson;
        }
    }

}