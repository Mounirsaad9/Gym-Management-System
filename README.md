# Gym Management System (Desktop Application) 🏋️‍♂️

A comprehensive portfolio-grade C# WinForms desktop application designed for gym management. Built using a clean **3-Tier Architecture** and robust SQL Server integration for scalable, maintainable operations.

---

## ✨ Key Features

- **Database Maintenance & Recovery:** Full manual `BACKUP` and `RESTORE` functionality with automated `SINGLE_USER` state handling and safe database switching.
- **Audit Logging & Activity Tracking:** Tracks sensitive user actions (Backups, Restores, Data modifications) in detailed audit logs for complete system traceability.
- **Data Management:** Complete management modules for members, subscriptions, and financial records.

---

## 🏗️ Architecture & Technical Stack

- **Architecture:** 3-Tier Architecture (Presentation Layer, Business Logic Layer, Data Access Layer) using decoupled DTOs.
- **Language & UI:** C# | .NET Framework (WinForms)
- **Database:** Microsoft SQL Server (T-SQL, Stored Procedures, Triggers, Views)
- **Data Access:** ADO.NET with parameterized queries to ensure security against SQL Injection.
