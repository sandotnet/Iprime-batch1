-- create db
CREATE DATABASE TrainingDB
--select database
use TrainingDB
-- Creating a new table
CREATE TABLE ParticipantList
(
	ParticipantID BIGINT IDENTITY(1,1) NOT NULL,
	FirstName VARCHAR(30),
	LastName VARCHAR(30),
	OfficialEmail VARCHAR(100)
)
insert into ParticipantList values('Chandra','Sagar','chandra@gmail.com')
select * from ParticipantList
-- Deleting all rows from the ParticipantList table
TRUNCATE TABLE ParticipantList
-- Deleting table from the database
DROP TABLE ParticipantList
-- Deleting the database
DROP DATABASE TrainingDB

--change table name
sp_rename 'ParticipantList', 'Participants'
--change table column
sp_rename 'Participants.OfficialEmail','Email'
select * from Participants
