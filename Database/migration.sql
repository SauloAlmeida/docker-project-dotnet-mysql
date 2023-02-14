CREATE DATABASE DOCKER;

USE DOCKER;

CREATE TABLE passwords ( id char(36) not null primary key, platform varchar(255) NOT NULL, password varchar(300) NOT NULL);