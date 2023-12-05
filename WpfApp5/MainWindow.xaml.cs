using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Student selectedStudent = null;

        List<Course> courses = new List<Course>();
        List<Teacher> teachers = new List<Teacher>(); 
        public MainWindow()
        {
            InitializeComponent();
            InitailizeStudent();
            InitializeCourse();
        }

        private void InitializeCourse()
        {
            Teacher teacher1 = new Teacher { TeacherName = "陳定宏" };
            teacher1.TeachingCourses.Add(new Course(teacher1) // pin一個老師進來，老師的名字，老師所授的課程加一筆紀錄進來Add，add紀錄產生新的課程，新的課程又必須知道他的老師是
            { CourseName="視窗程式設計", OpeningClass="四技二甲", Point=3, Type="選修"});
            teacher1.TeachingCourses.Add(new Course(teacher1) 
            { CourseName = "視窗程式設計", OpeningClass = "四技二乙", Point = 3, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course(teacher1)
            { CourseName = "視窗程式設計", OpeningClass = "四技二丙", Point = 3, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course(teacher1)
            { CourseName = "視窗程式設計", OpeningClass = "五專三甲", Point = 3, Type = "必選" });

            Teacher teacher2 = new Teacher { TeacherName = "李宗儒" };
            teacher2.TeachingCourses.Add(new Course(teacher2)
            { CourseName = "Android程式", OpeningClass = "五專四甲", Point = 3, Type = "選修" });
            teacher2.TeachingCourses.Add(new Course(teacher2)
            { CourseName = "人工智慧與應用", OpeningClass = "博研電子一甲合開", Point = 3, Type = "選修" });
            teacher2.TeachingCourses.Add(new Course(teacher2)
            { CourseName = "動態程式語言", OpeningClass = "四技資工三甲等合開", Point = 3, Type = "選修" });

            Teacher teacher3 = new Teacher { TeacherName = "鄧瑞哲" };
            teacher3.TeachingCourses.Add(new Course(teacher3)
            { CourseName = "微積分(一)", OpeningClass = "四技資工一丙", Point = 3, Type = "必修" });
            teacher3.TeachingCourses.Add(new Course(teacher3)
            { CourseName = "圖像化程式設計", OpeningClass = "五專資工一丙", Point = 3, Type = "系定選修" });
            teacher3.TeachingCourses.Add(new Course(teacher3)
            { CourseName = "圖像化程式設計實習", OpeningClass = "五專資工一丙", Point = 3, Type = "系定選修" });

            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);

            tvTeacher.ItemsSource = teachers;

        }

        private void InitailizeStudent()
        {
            students.Add(new Student {StudentId  = "A1234567", StudentName = "陳大明" });
            students.Add(new Student { StudentId = "A1234789", StudentName = "王大美" });
            students.Add(new Student { StudentId = "A1234669", StudentName = "張大胖" });
            students.Add(new Student { StudentId = "A1234567", StudentName = "黃小龍" });

            cmbStudent. ItemsSource = students;
            cmbStudent.SelectedIndex = 0;
            //selectedStudent = (Student)cmbStudent.SelectedItem;

        }
        private void cmbStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStudent = (Student)cmbStudent.SelectedItem;
            labelStudent.Content = $"選取學生:{selectedStudent.ToString()}";
        }
        

        
    }
}
