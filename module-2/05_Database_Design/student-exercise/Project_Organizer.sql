CREATE DATABASE Project_Organizer

USE Project_Organizer

BEGIN TRANSACTION

CREATE TABLE Department(
department_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
department_name varchar(50) NOT NULL);

CREATE TABLE Project(
project_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
project_name varchar(50) NOT NULL,
project_start_date date);

CREATE TABLE Employee(
employee_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
job_title varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
first_name varchar(50) NOT NULL,
gender varchar(50),
date_of_birth date NOT NULL,
date_of_hire date NOT NULL,
department_id int NOT NULL FOREIGN KEY REFERENCES Department(department_id));

CREATE TABLE Project_participant (
participant_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
employee_id int NOT NULL FOREIGN KEY REFERENCES Employee(employee_id),
project_id int NOT NULL FOREIGN KEY REFERENCES Project(project_id));

INSERT INTO Department
( department_name)
VALUES 
('Call Center');
INSERT INTO Department
( department_name)
VALUES 
('Sales');
INSERT INTO Department
( department_name)
VALUES 
('Operations');
INSERT INTO Project
( project_name, project_start_date)
VALUES 
('A', '2020-01-01');
INSERT INTO Project
( project_name, project_start_date)
VALUES 
('B', '2020-01-01');
INSERT INTO Project
( project_name, project_start_date)
VALUES 
('C', '2020-01-01');
INSERT INTO Project
( project_name, project_start_date)
VALUES 
('D', '2020-01-01');
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Smithers', 'Smith', 'male', '1980-01-01', '2020-01-01', 1);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Mithers', 'Mith', 'female', '1980-01-01', '2020-01-01', 2);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Ithers', 'Ith', 'female', '1980-01-01', '2020-01-01', 3);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Thithers', 'Thith', 'male', '1980-01-01', '2020-01-01', 2);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Hithers', 'Hith', 'female', '1980-01-01', '2020-01-01', 1);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Simon', 'Paul', 'male', '1980-01-01', '2020-01-01', 3);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'Tee', 'Mr', 'female', '1980-01-01', '2020-01-01', 1);
INSERT INTO Employee
(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES
('Director', 'BHammock', 'PrincessConsuela', 'male', '1980-01-01', '2020-01-01', 2);
INSERT INTO Project_participant
(employee_id, project_id)
VALUES
(1, 1);
INSERT INTO Project_participant
(employee_id, project_id)
VALUES
(2, 2);
INSERT INTO Project_participant
(employee_id, project_id)
VALUES
(3, 3);
INSERT INTO Project_participant
(employee_id, project_id)
VALUES
(4, 4);
INSERT INTO Project_participant
(employee_id, project_id)
VALUES
(3, 4);

COMMIT;