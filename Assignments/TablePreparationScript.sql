CREATE TABLE salespeople
(
	snum  INT(4),
    sname VARCHAR(10),
	city  VARCHAR(10),
	comm  FLOAT(3,2)
);

CREATE TABLE customer
(
	cnum  INT(4),
	cname VARCHAR(10),
	city  VARCHAR(10),
	rating	INT(4),
	snum INT(4)
);

CREATE TABLE orders
(
	onum  INT(4),
	amt	  FLOAT(7,2),
	odate DATE,
	cnum  INT(4),
	snum  INT(4)	
);



INSERT INTO salespeople(snum,sname,city,comm)
VALUES (1001,'Peel',	'London',	.12);

INSERT INTO salespeople(snum,sname,city,comm)
VALUES (1002,'Serres',	'San Jose',	.13);

INSERT INTO salespeople(snum,sname,city,comm)
VALUES (1004,'Motika',	'London',	.11);

INSERT INTO salespeople(snum,sname,city,comm)
VALUES (1007,'Rifkin',	'Barcelona',	.15);

INSERT INTO salespeople(snum,sname,city,comm)
VALUES (1003,'Axelrod',	'New York',	.10);

COMMIT;

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2001,	'Hoffman',	'London',	100,	1001);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2002,	'Giovanni',	'Rome',	200,	1003);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2003,	'Liu',	'San Jose',	200,	1002);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2004,	'Grass', 	'Berlin',	300,	1002);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2006,	'Clemens', 	'London',	100,	1001);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2008,	'Cisneros',	'San Jose',	300,	1007);

INSERT INTO customer(cnum,cname,city,rating,snum)
VALUES (2007,	'Pereira',	'Rome',	100,	1004);

COMMIT;

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3001,	18.69,	'1990-10-03',	2008,	1007);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3003,	767.19,	'1990-10-03',	2001,	1001);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3002,	1900.10,	'1990-10-03',	2007,	1004);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3005,	5160.45,	'1990-10-03',	2003,	1002);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3006,	1098.16,	'1990-10-03',	2008,	1007);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3009,	1713.23,	'1990-10-04',	2002,	1003);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3007,	75.75,	'1990-10-04',	2004,	1002);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3008,	4723.00,	'1990-10-05',	2006,	1001);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3010,	1309.95,	'1990-10-06',	2004,	1002);

INSERT INTO orders(onum,	amt,	odate, 	cnum,	snum)
VALUES (3011,	9891.88,	'1990-10-06', 2006,	1001);

COMMIT;
