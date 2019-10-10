CREATE proc contacts1
    @addressid   INT  ,          
    @firstname   NCHAR (10),     
    @lastname    NCHAR (10),     
    @email       NVARCHAR (MAX) ,
    @phonenumber INT
as
insert into contacts(firstname,lastname,email,phonenumber)
values (@firstname,@lastname,@email,@phonenumber)