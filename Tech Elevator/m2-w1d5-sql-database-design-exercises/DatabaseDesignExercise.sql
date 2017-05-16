begin transaction

create table employee
(
employeeId int identity not null,
departmentId int identity not null,
hireDate datetime not null,
jobTitle varchar(50) not null,

constraint pk_employeeId primary key (employeeId),

);

create table employeePersonal
(
employeeId int identity not null,
lastName varchar(50) not null,
firstName varchar(50) not null,
gender varchar(50) null,
birthday date not null,

constraint pk_employeeId primary key (employeeId),

);

create table department
(
departmentId int identity not null,
departmentName varchar(50) not null,
deptEmployeeCount int not null

constraint pk_departmentId primary key (departmentId)
);

create table project
(
projectId int identity not null,
projectName varchar(50) not null,
startDate date not null, (FK)
projEmployeeCount int not null

constraint pk_projectId primary key (projectId)
);

alter table employeePersonal
add constraint fk_employeeId foreign key (employeeId) references employee(employeeId);

alter table 
add constraint fk_departmentId foreign key (departmentId) references department(departmentId);
end

alter table department