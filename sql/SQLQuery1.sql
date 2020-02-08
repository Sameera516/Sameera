create procedure enterdata @id int,@name varchar(50),@des varchar(50),@sal money
As
insert into NewEmpTable(eid,ename,designation,basicsalary) values(@id,@name,@des,@sal)
exec enterdata @id=1,@name='sameera',@des='PAT',@sal=30000;
exec enterdata @id=2,@name='sravya',@des='PAT',@sal=40000;
exec enterdata @id=3,@name='keerthi',@des='PAT',@sal=40000;
exec enterdata @id=4,@name='suma',@des='software',@sal=15000;
exec enterdata @id=5,@name='sravani',@des='software',@sal=20000;
exec enterdata @id=6,@name='lasya',@des='PAT',@sal=30000;
exec enterdata @id=7,@name='teja',@des='pat',@sal=10000;
exec enterdata @id=8,@name='saisri',@des='PAT',@sal=10000;
exec enterdata @id=9,@name='vijaya',@des='software',@sal=15000;
exec enterdata @id=10,@name='gayatri',@des='PAT',@sal=8000;
go;
select * from NewEmpTable;