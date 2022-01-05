use library
create table issue_tbl
(
StudentId int identity(1,1) primary key not null,
StudentEnrollmentNo varchar(50) not null,
StudentName varchar(50) not null,
Department varchar(50) not null,
Semester nvarchar(50) not null,
StudentContact nvarchar(14) not null,
EmailAddress varchar(50) not null,
BookName varchar(50) not null,
BookIssueDate varchar(50) not null,
BookReturnDate varchar(50),
)

insert into issue_tbl values('1234','Samik Shakya','Bit','3rd','9801293764','samik@gmail.com','Math','Wednesday,June23,2021','Wednesday,June23,2021')

select * from issue_tbl

select * from issue_tbl where StudentEnrollmentNo ='1234' and BookReturnDate IS NUll

StudentEnrollmentNo,StudentName,Department,Semester,StudentContact,EmailAddress,BookName,BookIssueDate
drop table issue_tbl



