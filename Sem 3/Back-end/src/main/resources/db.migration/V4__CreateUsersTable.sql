CREATE TABLE `users` (
                         `id` int NOT NULL AUTO_INCREMENT,
                         `username` varchar(20) NOT NULL,
                         `password` varchar(100) DEFAULT NULL,
                         `customer_id` int DEFAULT NULL,
                         PRIMARY KEY (`id`),
                         KEY `customer_id_idx` (`customer_id`),
                         CONSTRAINT `customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`)
);