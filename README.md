```mermaid
graph TD
    A[Features] --> B(Students)
    A --> C(Departments)
    A --> D(Courses)

    B --> B1[Commands]
    B1 --> B1a(CreateStudent)
    B1a --> B1a_Cmd(CreateStudentCommand.cs)
    B1a --> B1a_Hnd(CreateStudentCommandHandler.cs)
    B1a --> B1a_Val(CreateStudentValidator.cs)
    B1 --> B1b(RemoveStudent)
    B1b --> B1b_Cmd(RemoveStudentCommand.cs)
    B1b --> B1b_Hnd(RemoveStudentCommandHandler.cs)

    B --> B2[Queries]
    B2 --> B2a(FilterStudents)
    B2a --> B2a_Qry(FilterStudentsQuery.cs)
    B2a --> B2a_Hnd(FilterStudentsQueryHandler.cs)
    B2 --> B2b(GetAllStudents)
    B2b --> B2b_Qry(GetAllStudentsQuery.cs)
    B2b --> B2b_Hnd(GetAllStudentsQueryHandler.cs)
    B2 --> B2c(GetStudentById)
    B2c --> B2c_Qry(GetStudentByIdQuery.cs)
    B2c --> B2c_Hnd(GetStudentByIdQueryHandler.cs)
    B2c --> B2c_Val(GetStudentByIdValidator.cs)
    B2 --> B2d(GetStudentCourses)
    B2d --> B2d_Qry(GetStudentCoursesQuery.cs)
    B2d --> B2d_Hnd(GetStudentCoursesQueryHandler.cs)
    B2d --> B2d_Val(GetStudentCoursesValidator.cs)

    C --> C1[Commands]
    C1 --> C1a(CreateDepartment)
    C1a --> C1a_Cmd(CreateDepartmentCommand.cs)
    C1a --> C1a_Hnd(CreateDepartmentCommandHandler.cs)
    C1a --> C1a_Val(CreateDepartmentValidator.cs)
    C1 --> C1b(RemoveDepartment)
    C1b --> C1b_Cmd(RemoveDepartmentCommand.cs)
    C1b --> C1b_Hnd(RemoveDepartmentCommandHandler.cs)

    C --> C2[Queries]
    C2 --> C2a(GetAllDepartments)
    C2a --> C2a_Qry(GetAllDepartmentsQuery.cs)
    C2a --> C2a_Hnd(GetAllDepartmentsQueryHandler.cs)
    C2 --> C2b(GetDepartmentCourses)
    C2b --> C2b_Qry(GetDepartmentCoursesQuery.cs)
    C2b --> C2b_Hnd(GetDepartmentCoursesQueryHandler.cs)
    C2 --> C2c(GetDepartmentStudents)
    C2c --> C2c_Qry(GetDepartmentStudentsQuery.cs)
    C2c --> C2c_Hnd(GetDepartmentStudentsQueryHandler.cs)

    D --> D1[Commands]
    D1 --> D1a(CreateCourse)
    D1a --> D1a_Cmd(CreateCourseCommand.cs)
    D1a --> D1a_Hnd(CreateCourseCommandHandler.cs)
    D1a --> D1a_Val(CreateCourseValidator.cs)
    D1 --> D1b(RemoveCourse)
    D1b --> D1b_Cmd(RemoveCourseCommand.cs)
    D1b --> D1b_Hnd(RemoveCourseCommandHandler.cs)

    D --> D2[Queries]
    D2 --> D2a(GetCourseById)
    D2a --> D2a_Qry(GetCourseByIdQuery.cs)
    D2a --> D2a_Hnd(GetCourseByIdQueryHandler.cs)
    D2a --> D2a_Val(GetCourseByIdValidator.cs)
    D2 --> D2b(GetCourseStudents)
    D2b --> D2b_Qry(GetCourseStudentsQuery.cs)
    D2b --> D2b_Hnd(GetCourseStudentsQueryHandler.cs)
    D2b --> D2b_Val(GetCourseStudentsValidator.cs)
