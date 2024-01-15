CREATE TABLE `user_role` (
                             `id` int NOT NULL AUTO_INCREMENT,
                             `role_name` varchar(255) NOT NULL,
                             `user_id` int NOT NULL,
                             PRIMARY KEY (`id`),
                             KEY `user_id_idx` (`user_id`),
                             CONSTRAINT `user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
);