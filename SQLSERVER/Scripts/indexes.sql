--create index
create clustered index pid_cluster on person(pid)
create nonclustered index name_non_cluster on person(name)
sp_helpindex person
create nonclustered index email_non_cluster on Participants(Email)
sp_helpindex Participants