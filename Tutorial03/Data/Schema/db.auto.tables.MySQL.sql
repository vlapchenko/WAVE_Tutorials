delimiter ;.
-- Table TBL_PERSON
create table `TBL_PERSON`
(
 `ID`             VARCHAR(32)    not null comment 'Person\'s unique identifier',
 `FIRSTNAME`      VARCHAR(25)    not null comment 'Person\'s first name',
 `LASTNAME`       VARCHAR(25)    not null comment 'Person\'s last name',
 `AGE`            INT             comment 'Person\'s age',
 `ISCERTIFIED`    tinyint(1)      comment 'Certified C# developer',
  constraint `PK_TBL_PERSON_PRIMARY` primary key (`ID`)
)
    comment = 'Persons'
;.

