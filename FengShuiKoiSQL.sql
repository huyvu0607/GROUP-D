USE master
GO

CREATE DATABASE FengShuiKoi
GO

USE FengShuiKoi
GO

CREATE TABLE KoiAccount (
  AccID int primary key,
  Password nvarchar(90) not null,
  EmailAddress nvarchar(90) unique, 
  Description nvarchar(140) not null,
  Role int
)
GO

INSERT INTO KoiAccount VALUES(551 ,N'donghuyvu@1','vudh1092@ut.edu.vn', N'System Admin', 1);
INSERT INTO KoiAccount VALUES(552 ,N'authehuy@1','huyat7383@ut.edu.vn', N'Manager', 2);
INSERT INTO KoiAccount VALUES(553 ,N'nguyenminhkhoi@1','khoinm5789@ut.edu.vn', N'Manager', 2);
INSERT INTO KoiAccount VALUES(554 ,N'tohoangvu@1','vuth9808@ut.edu.vn', N'Manager', 2);
INSERT INTO KoiAccount VALUES(124 ,N'@1','member@gmail.com', N'member', 4);
INSERT INTO KoiAccount VALUES(123 ,N'@1','member1@gmail.com', N'member', 4);
GO

CREATE TABLE UserMember (
  ACCID int FOREIGN KEY references KoiAccount(AccID) on delete cascade on update cascade,
  FullName nvarchar(100) not null primary key, 
  Birthday Datetime, 
  destiny nvarchar(30)
)
GO
INSERT INTO UserMember VALUES(551,N'DONG HUY VU','2005-07-06','Water');
INSERT INTO UserMember VALUES(552,N'AU THE HUY','2005-02-05','Water');
INSERT INTO UserMember VALUES(553,N'NGUYTEN MINH KHOI 98','2005-12-25','Water');
INSERT INTO UserMember VALUES(554,N'TO HOANG VU','2005-07-16','Water');
INSERT INTO UserMember VALUES(124,N'JUSTIN BIBER','1994-03-01','Fire');
INSERT INTO UserMember VALUES(123,N'DONALD TRUM','1946-06-14','Fire');
GO