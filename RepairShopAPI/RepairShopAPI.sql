drop database if exists repairshop;
create database repairshop;

use repairshop;

create table repairorder (
    id int NOT NULL AUTO_INCREMENT,
    customer varchar(50),
    instrument_id int,
    status int,
    price decimal(5, 2),
    notes varchar(200),
    bookmark bool,
    primary key (id)
);

create table instrument (
	id int NOT NULL AUTO_INCREMENT,
    name varchar(30),
    description varchar(100),
    primary key (id)
);

create view shortrepairlist as
	select ro.id, ro.customer, ins.name as Instrument from repairorder ro join instrument ins on ro.instrument_id = ins.id;

insert into instrument (name, description) values ('Alto Saxophone', 'Woodwind made of brass for a unique sound');
insert into instrument (name, description) values ('Tenor Saxophone', 'Woodwind made of brass for a unique sound');
insert into instrument (name, description) values ('Clarinet', 'A squawky woodwind that sounds horrible');
insert into instrument (name, description) values ('Korg Kross II', 'Music workstation by Kork');
insert into instrument (name, description) values ('Flute', 'Woodwind instrument made of metal');
insert into instrument (name, description) values ('Violin', 'Small string instrument');

INSERT INTO `repairshop`.`repairorder` (customer, instrument_id, status, price, notes, bookmark) VALUES ('Sally Smith', 3, 1, 25.00, 'Broken key', false);
INSERT INTO `repairshop`.`repairorder` (customer, instrument_id, status, price, notes, bookmark) VALUES ('Fred Franklin', 6, 1, 25.00, 'Tuner key will not turn', false);
INSERT INTO `repairshop`.`repairorder` (customer, instrument_id, status, price, notes, bookmark) VALUES ('Jeremy Johnson', 1, 1, 25.00, 'Needs new bell', false);