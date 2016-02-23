create database if not exists `tutorial_db`;

grant all on `tutorial_db`.* to `tutorial_user`@`localhost` identified by 'password';
flush privileges;

use `tutorial_db`;

drop table if exists `tbl_person`;
create table `TBL_PERSON`
(
 `ID`             VARCHAR(32)    not null comment 'Person\'s unique identifier',
 `FIRSTNAME`      VARCHAR(25)    not null comment 'Person\'s first name',
 `LASTNAME`       VARCHAR(25)    not null comment 'Person\'s last name',
 `AGE`            INT             comment 'Person\'s age',
 `ISCERTIFIED`    tinyint(1)      comment 'Certified C# developer',
  constraint `PK_TBL_PERSON_PRIMARY` primary key (`ID`)
)
comment = 'Persons';


truncate table `tbl_person`;
insert into `tbl_person`
(`ID`,
`FIRSTNAME`,
`LASTNAME`,
`AGE`,
`ISCERTIFIED`)
values
('12D4BC3F8AE8485CA66B8FB80DC6EA3A',
'John',
'Smith',
20,
1);

insert into `tbl_person`
(`ID`,
`FIRSTNAME`,
`LASTNAME`,
`AGE`,
`ISCERTIFIED`)
values
('650643AE9384495C8F4326C66713F103',
'James',
'Brown',
31,
null);

commit;