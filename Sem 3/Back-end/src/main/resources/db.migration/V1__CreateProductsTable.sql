CREATE TABLE `products` (
                            `id` int NOT NULL AUTO_INCREMENT,
                            `category` varchar(20) NOT NULL,
                            `name` varchar(20) NOT NULL,
                            `price` decimal(12,2) NOT NULL,
                            `image_url` varchar(255) NOT NULL,
                            PRIMARY KEY (`id`)
);