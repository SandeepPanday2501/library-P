use library
create table std_tbl
(
StudentId int identity(1,1) primary key not null,
EnrollmentNo varchar(50) not null,
StudentName varchar(50) not null,
Department varchar(50) not null,
Semester nvarchar(50) not null,
StudentContact nvarchar(14) not null,
EmailAddress varchar(50) not null,

)

drop table std_tbl
insert into std_tbl values('1234','Samik Shakya','Bit','3rd','9801293764','samik@gmail.com')

select * from std_tbl