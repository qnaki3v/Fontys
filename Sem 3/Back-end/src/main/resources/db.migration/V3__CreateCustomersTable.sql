CREATE TABLE `customers` (
                             `id` int NOT NULL AUTO_INCREMENT,
                             `bsn` varchar(9) NOT NULL,
                             `first_name` varchar(20) DEFAULT NULL,
                             `last_name` varchar(20) DEFAULT NULL,
                             `age` int DEFAULT NULL,
                             `postcode_id` int DEFAULT NULL,
                             PRIMARY KEY (`id`),
                             KEY `user_postcodeFK_idx` (`postcode_id`),
                             CONSTRAINT `user_postcodeFK` FOREIGN KEY (`postcode_id`) REFERENCES `postcodes` (`id`)
);