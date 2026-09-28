CREATE TABLE vehicle_types(
	vehicleId SERIAL PRIMARY KEY,
	typeName VARCHAR(50) NOT NULL UNIQUE,
	dailyRate NUMERIC(10,2) NOT NULL CHECK(dailyRate>0)
); 


CREATE TABLE customers(
	customerId SERIAL PRIMARY KEY,
	firstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	phone VARCHAR(15) UNIQUE,
	createdAt DATE DEFAULT CURRENT_DATE
); 

CREATE TABLE vehicles (
    vehicleId SERIAL PRIMARY KEY,
    vehicleType_id INT NOT NULL,
    registrationNo VARCHAR(20) NOT NULL UNIQUE,
    brand VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    vehicleYear INT CHECK (vehicleYear >= 2000),
    status VARCHAR(20) NOT NULL
        CHECK (status IN ('AVAILABLE', 'RENTED', 'MAINTENANCE')),

    FOREIGN KEY (vehicleType_id)
    REFERENCES vehicle_types(vehicleId)
);

CREATE TABLE rentals (
    rentalId SERIAL PRIMARY KEY,
    customerId INT NOT NULL,
    vehicleId INT NOT NULL,
    rentalDate DATE NOT NULL,
    returnDate DATE,
    totalAmount NUMERIC(10,2) CHECK (totalAmount >= 0),

    FOREIGN KEY (customerId)
        REFERENCES customers(customerId),

    FOREIGN KEY (vehicleId)
        REFERENCES vehicles(vehicleId),

    CHECK (returnDate IS NULL OR returnDate >= rentalDate)
);


CREATE TABLE payments (
    paymentId SERIAL PRIMARY KEY,
    rentalId INT NOT NULL,
    paymentDate DATE DEFAULT CURRENT_DATE,
    amount NUMERIC(10,2) NOT NULL CHECK (amount > 0),
    paymentMethod VARCHAR(20) NOT NULL
        CHECK (paymentMethod IN ('CASH', 'CARD', 'UPI')),

    FOREIGN KEY (rentalId)
        REFERENCES rentals(rentalId)
);

CREATE TABLE maintenance (
    maintenanceId SERIAL PRIMARY KEY,
    vehicleId INT NOT NULL,
    maintenanceDate DATE NOT NULL,
    description VARCHAR(255),
    cost NUMERIC(10,2) NOT NULL CHECK (cost >= 0),

    FOREIGN KEY (vehicleId)
        REFERENCES vehicles(vehicleId)
);

INSERT INTO vehicle_types (typeName, dailyRate)
VALUES
('Sedan', 1500),
('SUV', 2500),
('Hatchback', 1200),
('Bike', 700);
SELECT * FROM vehicle_types;

INSERT INTO customers (firstName, lastName, email, phone)
VALUES
('Laksha', 'Bansal', 'laksha@gmail.com', '9876543210'),
('Rahul', 'Sharma', 'rahul@gmail.com', '9876543211'),
('Simran', 'Kaur', 'simran@gmail.com', '9876543212'),
('Arjun', 'Verma', 'arjun@gmail.com', '9876543213'),
('Priya', 'Singh', 'priya@gmail.com', '9876543214');
SELECT * FROM customers;

INSERT INTO vehicles
(vehicleType_id, registrationNo, brand, model, vehicleYear, status)
VALUES
(1, 'PB10AB1001', 'Honda', 'City', 2022, 'AVAILABLE'),
(1, 'PB10AB1002', 'Hyundai', 'Verna', 2023, 'RENTED'),
(2, 'PB10AB2001', 'Toyota', 'Fortuner', 2021, 'AVAILABLE'),
(2, 'PB10AB2002', 'Mahindra', 'XUV700', 2023, 'RENTED'),
(3, 'PB10AB3001', 'Maruti', 'Swift', 2022, 'AVAILABLE'),
(3, 'PB10AB3002', 'Hyundai', 'i20', 2021, 'MAINTENANCE'),
(4, 'PB10AB4001', 'Royal Enfield', 'Classic 350', 2023, 'AVAILABLE'),
(4, 'PB10AB4002', 'Honda', 'Activa', 2022, 'RENTED');
SELECT * FROM vehicles;

INSERT INTO rentals
(customerId, vehicleId, rentalDate, returnDate, totalAmount)
VALUES
(1, 2, '2026-09-01', '2026-09-04', 4500),
(2, 4, '2026-09-05', '2026-09-07', 5000),
(3, 2, '2026-09-10', '2026-09-12', 3000),
(1, 4, '2026-09-15', '2026-09-18', 7500),
(4, 8, '2026-09-20', NULL, 5600),
(5, 2, '2026-09-21', NULL, 3000),
(2, 4, '2026-09-22', NULL, 7500);
SELECT * FROM rentals; 

INSERT INTO payments
(rentalId, amount, paymentMethod)
VALUES
(1, 4500, 'UPI'),
(2, 5000, 'CARD'),
(3, 3000, 'CASH'),
(4, 7500, 'UPI'),
(5, 5600, 'CARD'),
(6, 3000, 'UPI'),
(7, 7500, 'CARD');

INSERT INTO maintenance
(vehicleId, maintenanceDate, description, cost)
VALUES
(6, '2026-09-05', 'Engine servicing', 3500),
(3, '2026-08-20', 'Oil change', 1500),
(2, '2026-08-25', 'Brake inspection', 2000);



SELECT  
    r.rentalId, 
    c.firstName || ' ' || c.lastName AS customerName, 
    v.brand, 
    v.model, 
    vt.typeName, 
    r.rentalDate, 
    r.totalAmount
FROM rentals r 
JOIN customers c 
    ON r.customerId = c.customerId 
JOIN vehicles v 
    ON r.vehicleId = v.vehicleId 
JOIN vehicle_types vt 
    ON v.vehicleType_id = vt.vehicleId;


WITH rentalCounts AS ( 
    SELECT  
        vt.typeName, 
        COUNT(r.rentalId) AS rentalCount 
    FROM vehicle_types vt 
    JOIN vehicles v 
        ON vt.vehicleId = v.vehicleType_id 
    JOIN rentals r 
        ON v.vehicleId = r.vehicleId 
    GROUP BY vt.typeName 
) 
SELECT * 
FROM rentalCounts 
ORDER BY rentalCount DESC;


SELECT
    c.customerId,
    c.firstName,
    SUM(r.totalAmount) AS totalSpending
FROM customers c
JOIN rentals r
    ON c.customerId = r.customerId
GROUP BY c.customerId, c.firstName;


SELECT
    c.customerId,
    c.firstName,
    SUM(r.totalAmount) AS totalSpending
FROM customers c
JOIN rentals r
    ON c.customerId = r.customerId
GROUP BY c.customerId, c.firstName
HAVING SUM(r.totalAmount) >
(
    SELECT AVG(customerTotal)
    FROM
    (
        SELECT
            customerId,
            SUM(totalAmount) AS customerTotal
        FROM rentals
        GROUP BY customerId
    ) AS spending
);

CREATE TEMP TABLE currentlyRentedVehicles AS
SELECT
    v.vehicleId,
    v.registrationNo,
    v.brand,
    v.model,
    c.firstName || ' ' || c.lastName AS customerName,
    r.rentalDate
FROM vehicles v
JOIN rentals r
    ON v.vehicleId = r.vehicleId
JOIN customers c
    ON r.customerId = c.customerId
WHERE r.returnDate IS NULL;
SELECT * FROM currentlyRentedVehicles;


CREATE VIEW available_vehicles AS
SELECT
    v.vehicleId,
    v.registrationNo,
    v.brand,
    v.model,
    vt.typeName,
    vt.dailyRate	
FROM vehicles v
JOIN vehicle_types vt
    ON v.vehicleType_id = vt.vehicleId
WHERE v.status = 'AVAILABLE';
SELECT * FROM available_vehicles;



