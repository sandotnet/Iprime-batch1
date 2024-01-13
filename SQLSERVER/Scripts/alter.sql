select * from Participants
--add column
alter table Participants add mobile varchar(1)
--drop column
alter table Participants drop column mobile
insert into Participants values('James','Kanna','james@gmail.com','9090909090')
--change data type
alter table Participants alter column mobile varchar(10)
--add primary key
alter table Participants add constraint id_pk primary key(ParticipantID)

--drop constraint
alter table Participants drop constraint id_pk

sp_helpconstraint Participants