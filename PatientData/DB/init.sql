create table tbl_patient (pID integer primary key autoincrement);
create table tbl_healthProfessional (hpID integer primary key autoincrement);
create table tbl_rational (rID integer primary key, rational text);
create table tbl_visit (vID integer primary key autoincrement, vdate Date, pID integer, hpID integer, paID integer, ohpa integer, diagnosis integer);
insert into tbl_rational (rID, rational) values (1, 'new');
insert into tbl_rational (rID, rational) values (2, 'checkup');
insert into tbl_rational (rID, rational) values (3, 'followGup');
insert into tbl_rational (rID, rational) values (4, 'referral');
insert into tbl_rational (rID, rational) values (5, 'emergency');
