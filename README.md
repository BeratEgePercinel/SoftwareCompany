# SoftwareCompany

In the company table, there is the name of the company, tax number, address,. There is a company detail table, the zip code of the company as a detail. It has Employees. Everyone in the company, including the boss, is an employee. Employees have name tcsi salary date of birth There are projects. The software company can develop projects for other companies in my company table. The project has the name, code, contract and employees. The contract has the contract name. takes place between software company and x company. It has a specific project and employees. Total amount. It has deadline fields.

Draw.io drawing of the design of the software company database above:

![image](https://github.com/BeratEgePercinel/SoftwareCompany/assets/119699844/1530e0eb-7236-4a33-845e-81b5c2085ef8)

SQL Codes Of The Software Company Database

create table Company( Id int primary key GENERATED ALWAYS AS IDENTITY, CompanyName character varying(100), Address character varying(100) ); insert into Company(CompanyName,Address) values ('Amerco','Reno,Nevada') insert into Company(CompanyName,Address) values ('Amazon','Californa 5th Avenue') insert into Company(CompanyName,Address) values ('Verizon','Utah, Dungeon Street') insert into Company(CompanyName,Address) values ('AT&T','Texas City Centre') insert into Company(CompanyName,Address) values ('American Express','Miami Towers') select * from Company

create table CompanyDetail( Id int primary key GENERATED ALWAYS AS IDENTITY, CompanyId int, TaxNumber character varying(5) ); insert into CompanyDetail (CompanyId,TaxNumber) values (1,12345) insert into CompanyDetail (CompanyId,TaxNumber) values (2,56431) insert into CompanyDetail (CompanyId,TaxNumber) values (3,80541) insert into CompanyDetail (CompanyId,TaxNumber) values (4,12983) insert into CompanyDetail (CompanyId,TaxNumber) values (5,45312) select * from CompanyDetail

create table Employee( Id int primary key GENERATED ALWAYS AS IDENTITY, IdentityNumber character varying(11), Salary float, BirthOfDate date, CompanyId int, FOREIGN KEY(CompanyId) REFERENCES Company(Id) ); insert into Employee(IdentityNumber,Salary,BirthOfDate,CompanyId) values ('10610545518',15400,'1998-09-09',1) insert into Employee(IdentityNumber,Salary,BirthOfDate,CompanyId) values ('10325436149',10000,'1986-03-12',5) insert into Employee(IdentityNumber,Salary,BirthOfDate,CompanyId) values ('11928347193',20500,'1976-04-06',4) insert into Employee(IdentityNumber,Salary,BirthOfDate,CompanyId) values ('10457645508',22500,'1995-08-11',3) insert into Employee(IdentityNumber,Salary,BirthOfDate,CompanyId) values ('10610545518',12000,'1988-11-10',2) select * from Employee

create table Contract( Id int primary key GENERATED ALWAYS AS IDENTITY, TotalCost float, Deadline date, CompanyId int, FOREIGN KEY (CompanyId) REFERENCES Company(Id) ); insert into Contract(TotalCost,Deadline,CompanyId) values (10000,'2023-06-02',3) insert into Contract(TotalCost,Deadline,CompanyId) values (123090,'2023-04-01',1) insert into Contract(TotalCost,Deadline,CompanyId) values (30456,'2023-03-03',5) insert into Contract(TotalCost,Deadline,CompanyId) values (54000,'2023-03-08',2) insert into Contract(TotalCost,Deadline,CompanyId) values (45300,'2022-11-11',4) select * from Contract

create table EmployeeContract( Id int primary key GENERATED ALWAYS AS IDENTITY, EmployeeId int, ContractId int, FOREIGN KEY (EmployeeId) REFERENCES Employee(Id), FOREIGN KEY (ContractId) REFERENCES Contract(Id) ); insert into EmployeeContract(EmployeeId,ContractId) values (1,3) insert into EmployeeContract(WorkerId,ContractId) values (4,2) insert into EmployeeContract(EmployeeId,ContractId) values (2,5) insert into EmployeeContract(EmployeeId,ContractId) values (3,4) insert into EmployeeContract(WorkerId,ContractId) values (5,1) select * from EmployeeContract

create table Project( Id int primary key GENERATED ALWAYS AS IDENTITY, ProjectName character varying(100), Code character varying(4), ContractId int, FOREIGN KEY (ContractId) REFERENCES Contract(Id) ); insert into Project(ProjectName,Code,ContractId) values ('Abcde','3847',1) insert into Project(ProjectName,Code,ContractId) values ('Mertt','3847',5) insert into Project(ProjectName,Code,ContractId) values ('EfeMert','2039',4) insert into Project(ProjectName,Code,ContractId) values ('EgeEfe','8675',3) insert into Project(ProjectName,Code,ContractId) values ('MertKerem','1923',2) select * from Project

create table EmployeeProject( Id int primary key GENERATED ALWAYS AS IDENTITY, EmployeeId int, ProjectId int, FOREIGN KEY (EmployeeId) REFERENCES Employee(Id), FOREIGN KEY (ProjectId) REFERENCES Project(Id) );

insert into EmployeeProject (EmployeeId,ProjectId) values (2,3) insert into EmployeeProject (EmployeeId,ProjectId) values (1,4) insert into EmployeeProject (EmployeeId,ProjectId) values (3,5) insert into EmployeeProject (EmployeeId,ProjectId) values (5,1) insert into EmployeeProject (EmployeeId,ProjectId) values (4,2)

--Company names which are project name is A

SELECT Company.Id, Company.Name FROM Project, Contract, Company
WHERE Project.Id = Contract.ProjectId
AND   Company.Id = Contract.CompanyId
AND   Project.Name = 'A';

--ProjectEmployee's which are company postal code is 1

SELECT Employee.Name FROM CompanyDetail, Company, Contract, Project, ProjectEmployee, Employee
WHERE Company.Id = CompanyDetail.CompanyId
AND   Contract.CompanyId = Company.Id
AND   Project.Id = Contract.ProjectId
AND   ProjectEmployee.ProjectId = Project.Id
AND   Employee.Id = ProjectEmployee.EmployeeId
AND   CompanyDetail.PostCode = 1



