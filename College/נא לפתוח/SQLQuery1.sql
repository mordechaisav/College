create table Course(
ID int primary key identity,
CourseName varchar(20),
StartDate datetime,
DaysOfWeek varchar(20),
BeginTime time,
EndTime time,
price int
)

create table Lecturers(
ID int primary key identity,
LecturerName varchar(20),
hourlyRate int
)

create table Subjects(
ID int primary key identity,
SubjectName varchar(20),
CourseID int,
LecturerID int,
hours int
foreign key (CourseID) references Course(ID),
foreign key (LecturerID) references Lecturers(ID)
)

create table Students(
ID int primary key identity,
StudentName varchar(20),
OutstandingBalance int
)

create table Students_in_course(
ID int primary key identity,
StudentID int,
SubjectID int,
foreign key (StudentID) references Students(ID),
foreign key (SubjectID) references Subjects(ID)
)

create table Payment(
ID int primary key identity,
price int, 
StudentID int,
CourseID int
foreign key (StudentID) references Students(ID),
foreign key (CourseID) references Course(ID)
)
create table Waiting(
ID int primary key identity,
CourseID int,
StudentName varchar(20)
foreign key (CourseID) references Course(ID)
)



