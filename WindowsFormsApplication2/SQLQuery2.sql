alter proc userlogin
@username NCHAR (10),
@password NCHAR (10),
@image image
as
insert into login(username,password,image)
values (@username,@password,@image)