create database school
use school
create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))
create table class(class_roomno int primary key,class_strength int)
create index student_index on student(student_id,student_name,student_class)
create index subjects_index on subjects(subjects_id,subjects_name)
create index class_index on class(class_roomno,class_strength)
insert into student values(01,'Raj',8)
insert into student values(02,'Jaya',9)
insert into student values(03,'Saswath',10)
insert into student values(04,'Rakshan',11)
insert into student values(05,'Aarish',12)
select * from student
insert into subjects values(101,'Tamil')
insert into subjects values(102,'English')
insert into subjects values(103,'Maths')
insert into subjects values(104,'Science')
insert into subjects values(105,'Social Science')
select * from subjects
insert into class values(01,10)
insert into class values(02,20)
insert into class values(03,30)
insert into class values(04,40)
insert into class values(05,50)
select*from student
select*from subjects
select*from class