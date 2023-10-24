USE [master]
CREATE DATABASE FibonacciData
GO
USE FibonacciData
GO
CREATE SCHEMA sch_fib AUTHORIZATION [dbo];
GO
CREATE TABLE [sch_fib].[T_Fibonacci](
    [FIB_Id] uniqueidentifier NOT NULL DEFAULT newid(),
    [FIB_ Input] [int] NOT NULL,
    [FIB_ Output] [bigint] NOT NULL,
    CONSTRAINT [PK_Fibonacci] PRIMARY KEY CLUSTERED ([FIB_Id]))
