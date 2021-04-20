

create database MYGRAM;

use MYGRAM;

Drop table Image;

Create Table Image(
     ImageId          int          NOT NULL,
     ImageName        varchar(500) NOT NULL,
     ImagePath        varchar(500) NOT NULL,
     ImageDescription varchar(500) NOT NULL default "Description Test",
     ImageAltText     varchar(500) NOT NULL,
     CreatedById      int          NOT NULL default 10,
     CreatedOn        datetime     NOT NULL,
     UNIQUE (ImageName),
     PRIMARY KEY (ImageId)
);

CREATE TABLE USER(
      UserName  varchar(500),
      password   varchar(500)
);

ALTER TABLE User
ALTER UserName SET DEFAULT "UserName Test";

insert into User
(UserName, password)
values
("louis","name");

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(1,"Image1","ImagePath1","ImageAltText1",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(2,"Image2","ImagePath2","ImageAltText2",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(3,"Image3","ImagePath3","ImageDescription3","ImageAltText3",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(4,"Image4","ImagePath4",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(5,"Image5","ImagePath5",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(6,"Image6","ImagePath6","ImageAltText6",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(7,"Image7","ImagePath7","ImageAltText7",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(8,"Image8","ImagePath8","ImageAltText8",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(9,"Image9","ImagePath9","ImageAltText9",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(10,"Image10","ImagePath10","ImageAltText10",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(11,"Image11","ImagePath11","ImageAltText11",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(12,"Image12","ImagePath12","ImageAltText12",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(13,"Image13","ImagePath13","ImageAltText13",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(14,"Image14","ImagePath14","ImageAltText14",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(15,"Image15","ImagePath15","ImageAltText15",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(16,"Image16","ImagePath16","ImageAltText16",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(17,"Image17","ImagePath17","ImageAltText17",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(18,"Image18","ImagePath18","ImageAltText18",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(19,"Image19","ImagePath19","ImageAltText19",curdate());

insert into Image
(ImageId,ImageName,ImagePath,ImageAltText,
CreatedOn )
Values
(20,"Image20","ImagePath20","ImageAltText20",curdate());

Select * From
Image;

select * from
User;
