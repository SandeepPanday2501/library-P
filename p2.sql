create database library
use library
create table book_tbl
(
BookId int identity(1,1) primary key not null,
BookName varchar(50) not null,
AuthorName varchar(50) not null,
Publication varchar(50) not null,
Price int not null,
Quantity int not null,
PurchaseDate date not null,
)

insert into book_tbl values(3,'Little Women','Louisa May Alcott','RS',1500,'1','Wednesday,June23,2021')

select * from book_tbl
drop table book_tbl

