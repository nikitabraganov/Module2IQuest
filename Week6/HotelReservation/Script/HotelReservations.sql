DROP DATABASE HotelReservations
CREATE DATABASE HotelReservations
GO
DROP TABLE CustomerDB
CREATE TABLE CustomerDB (ID int IDENTITY(1,1) PRIMARY KEY, FirstName varchar(255), LastName varchar(255))
GO
DROP TABLE ReservationDB
CREATE TABLE ReservationDB(ID int IDENTITY(1,1) PRIMARY KEY, CustomerId int FOREIGN KEY REFERENCES CustomerDB(ID), CheckInDate datetime, CheckOutDate datetime)
GO
INSERT INTO CustomerDB VALUES('Ion', 'Pelivan')
INSERT INTO CustomerDB VALUES('Ion', 'Enache')
INSERT INTO CustomerDB VALUES('Petru', 'Zadnipru')
INSERT INTO CustomerDB VALUES('Stefan', 'Celmare')
INSERT INTO CustomerDB VALUES('Mircea', 'Celbatran')

INSERT INTO ReservationDB VALUES(1, '2018-4-20 13:00:00', '2018-4-25 13:00:00')
INSERT INTO ReservationDB VALUES(2, '2018-4-23 13:00:00', '2018-4-25 13:00:00')
INSERT INTO ReservationDB VALUES(3, '2018-4-25 13:00:00', '2018-4-27 13:00:00')
INSERT INTO ReservationDB VALUES(4, '2018-4-20 13:00:00', '2018-4-30 13:00:00')
INSERT INTO ReservationDB VALUES(5, '2018-4-20 13:00:00', '2018-4-22 13:00:00')
INSERT INTO ReservationDB VALUES(1, '2018-4-25 13:00:00', '2018-4-29 13:00:00')
INSERT INTO ReservationDB VALUES(2, '2018-4-20 13:00:00', '2018-4-21 13:00:00')
INSERT INTO ReservationDB VALUES(3, '2018-4-20 13:00:00', '2018-4-22 13:00:00')
INSERT INTO ReservationDB VALUES(4, '2018-4-20 13:00:00', '2018-4-23 13:00:00')
INSERT INTO ReservationDB VALUES(5, '2018-4-20 13:00:00', '2018-4-25 13:00:00')

SELECT ReservationDB.ID, CustomerDB.FirstName, CustomerDB.LastName, ReservationDB.CheckInDate, ReservationDB.CheckOutDate FROM ReservationDB INNER JOIN CustomerDB ON ReservationDB.CustomerId = CustomerDB.ID
SELECT * FROM ReservationDB
