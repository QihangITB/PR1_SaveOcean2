CREATE TABLE IF NOT EXISTS animal (
    id SERIAL PRIMARY KEY,
    name VARCHAR NOT NULL,
    super_family VARCHAR NOT NULL,
    species VARCHAR NOT NULL,
    weight DECIMAL(10,2) NOT NULL
);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Dall', 'Cetacean', 'Dolphin', 190.00);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Woby', 'Cetacean', 'Whale', 40000.00);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Samy', 'Cetacean', 'Killer Whale', 3500.00);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Tim', 'Sea Bird', 'Seagull', 24.23);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Dally', 'Sea Bird', 'Penguin', 15.70);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Poppy', 'Sea Bird', 'Albatross', 8.00);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Turt', 'Sea Turtle', 'Cheloniidae', 45.00);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Cary', 'Sea Snake', 'Caretta Turtle', 12.00);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Tito', 'Sea Turtle', 'Loggerhead Turtle', 32.00);