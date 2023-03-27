-- ***** ARKany Fryzjerstwa initial db *****

-- Salons
CREATE TABLE [dbo].[Salons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	CONSTRAINT [PK_Salons] PRIMARY KEY ([Id])
);
GO

-- Resources
CREATE TABLE [dbo].[Resources](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalonId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Quantity] [real] NOT NULL,
	[Unit] [int] NOT NULL,
	[Usage] [real] NOT NULL,
	CONSTRAINT [PK_Resources] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Resources_Salons_SalonId] FOREIGN KEY([SalonId]) REFERENCES [dbo].[Salons] ([Id]) ON DELETE CASCADE
);
GO

-- Services
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalonId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Duration] [int] NOT NULL,
	[Price] [decimal](8, 4) NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT (CONVERT([bit],(0),0)),
	CONSTRAINT [PK_Services] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Services_Salons_SalonId] FOREIGN KEY([SalonId]) REFERENCES [dbo].[Salons] ([Id]) ON DELETE CASCADE
);
GO

-- ServiceResource
CREATE TABLE [dbo].[ServiceResource](
	[ServiceId] [int] NOT NULL,
	[ResourceId] [int] NOT NULL,
	[Usage] [real] NOT NULL,
	CONSTRAINT [PK_ServiceResource] PRIMARY KEY ([ServiceId], [ResourceId]),
	CONSTRAINT [FK_ServiceResource_Resources_ResourceId] FOREIGN KEY([ResourceId]) REFERENCES [dbo].[Resources] ([Id]),
	CONSTRAINT [FK_ServiceResource_Services_ServiceId] FOREIGN KEY([ServiceId]) REFERENCES [dbo].[Services] ([Id]) ON DELETE CASCADE
);
GO

-- Users
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[SalonId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Color] [nvarchar](7) NOT NULL DEFAULT (N'#72bfb1'),
	CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Users_Salons_SalonId] FOREIGN KEY([SalonId]) REFERENCES [dbo].[Salons] ([Id])
);
GO

-- UserLogins
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
	CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
	CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);
GO

-- Roles 
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

-- RoleClaims
CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE
);
GO

-- UserRoles
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserId], [RoleId]),
	CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);
GO

-- UserTokens
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
	CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
	CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);

-- UserClaims
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);
GO

-- VerificationCodes
CREATE TABLE [dbo].[VerificationCodes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](8) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[InsertDateTime] [datetime2](7) NOT NULL,
	[IsUsed] [bit] NOT NULL  DEFAULT (CONVERT([bit],(0),0)),
	CONSTRAINT [Pk_VerificationCodes] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_VerificationCodes_Users_UserId] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);
GO

-- Notes
CREATE TABLE [dbo].[Notes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [nvarchar](450) NOT NULL UNIQUE,
	[Text] [nvarchar](max) NOT NULL,
	CONSTRAINT [Pk_Notes] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Notes_Salons_SalonId] FOREIGN KEY([EmployeeId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);
GO

-- Clients
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](200) NULL,
	CONSTRAINT [PK_Clients] PRIMARY KEY ([Id])
);
GO

-- ClientSalon
CREATE TABLE [dbo].[ClientSalon](
	[ClientId] [int] NOT NULL,
	[SalonId] [int] NOT NULL,
	CONSTRAINT [PK_ClientSalon] PRIMARY KEY ([ClientId], [SalonId]),
	CONSTRAINT [FK_ClientSalon_Clients_ClientId] FOREIGN KEY([ClientId]) REFERENCES [dbo].[Clients] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ClientSalon_Salons_SalonId] FOREIGN KEY([SalonId]) REFERENCES [dbo].[Salons] ([Id]) ON DELETE CASCADE
);
GO

-- Appointments
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Start] [datetime2](7) NOT NULL,
	[End] [datetime2](7) NOT NULL,
	[EmployeeId] [nvarchar](450) NOT NULL,
	[AuthorId] [nvarchar](450) NULL,
	[ServiceId] [int] NOT NULL,
	[ClientId] [int] NULL,
	[Status] [int] NOT NULL,
	[StandardPrice] [decimal](8, 4) NULL,
	[FinalPrice] [decimal](8, 4) NULL,
	CONSTRAINT [PK_Appointments] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Appointments_Clients_ClientId] FOREIGN KEY([ClientId]) REFERENCES [dbo].[Clients] ([Id]) ON DELETE SET NULL,
	CONSTRAINT [FK_Appointments_Services_ServiceId] FOREIGN KEY([ServiceId]) REFERENCES [dbo].[Services] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_Appointments_Users_AuthorId] FOREIGN KEY([AuthorId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE SET NULL,
	CONSTRAINT [FK_Appointments_Users_EmployeeId] FOREIGN KEY([EmployeeId]) REFERENCES [dbo].[Users] ([Id])
);
GO

-- Tables
CREATE TABLE [dbo].[Tables](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL UNIQUE,
	CONSTRAINT [PK_Tables] PRIMARY KEY ([Id])
);
GO

-- TablesModificationDateTimes
CREATE TABLE [dbo].[TablesModificationDateTimes](
	[SalonId] [int] NOT NULL,
	[Table] [int] NOT NULL,
	[ModificationDateTime] [datetime2](7) NOT NULL,
	CONSTRAINT [PK_SalonIdTable] PRIMARY KEY ([SalonId], [Table]),
	CONSTRAINT [FK_SalonIdTable_Tables_Table] FOREIGN KEY([Table]) REFERENCES [dbo].[Tables] ([Id]) ON DELETE CASCADE,
);
GO

-- Indexes
CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [RoleClaims] ([RoleId]);
CREATE UNIQUE INDEX [RoleNameIndex] ON [Roles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
CREATE INDEX [IX_AspNetUserClaims_UserId] ON [UserClaims] ([UserId]);
CREATE INDEX [IX_AspNetUserLogins_UserId] ON [UserLogins] ([UserId]);
CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [UserRoles] ([RoleId]);
CREATE INDEX [EmailIndex] ON [Users] ([NormalizedEmail]);
CREATE UNIQUE INDEX [UserNameIndex] ON [Users] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

--------------------------------
-- *****initial data*****

-- Roles
INSERT INTO [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
VALUES ('7cbac17a-2189-4994-b5db-41adc56fb17c', 'SalonOwnerRole', 'SALONOWNERROLE', '2ac9c133-6a57-416e-a653-3786b5b7e131');

-- Tables (Must match the ARKanyFryzjerstwa.Data.DatabaseTable enum)
INSERT INTO [dbo].[Tables] ([Id], [Name])
VALUES 
(0, 'Appointments'),
(1, 'Clients'),
(2, 'ClientSalon'),
(3, 'Resources'),
(4, 'RoleClaims'),
(5, 'Roles'),
(6, 'Salons'),
(7, 'ServiceResource'),
(8, 'Services'),
(9, 'TablesModificationDateTimes'),
(10, 'UserClaims'),
(11, 'UserLogins'),
(12, 'UserRoles'),
(13, 'Users'),
(14, 'UserTokens'),
(15, 'VerificationCodes');

-- *****drop tables*****

--DROP TABLE IF EXISTS [dbo].[TablesModificationDateTimes];
--DROP TABLE IF EXISTS [dbo].[Tables];
--DROP TABLE IF EXISTS [dbo].[Appointments];
--DROP TABLE IF EXISTS [dbo].[ClientSalon];
--DROP TABLE IF EXISTS [dbo].[Clients];
--DROP TABLE IF EXISTS [dbo].[Notes];
--DROP TABLE IF EXISTS [dbo].[VerificationCodes];
--DROP TABLE IF EXISTS [dbo].[UserClaims];
--DROP TABLE IF EXISTS [dbo].[UserTokens];
--DROP TABLE IF EXISTS [dbo].[UserRoles];
--DROP TABLE IF EXISTS [dbo].[RoleClaims];
--DROP TABLE IF EXISTS [dbo].[Roles];
--DROP TABLE IF EXISTS [dbo].[UserLogins];
--DROP TABLE IF EXISTS [dbo].[Users];
--DROP TABLE IF EXISTS [dbo].[ServiceResource];
--DROP TABLE IF EXISTS [dbo].[Services];
--DROP TABLE IF EXISTS [dbo].[Resources];
--DROP TABLE IF EXISTS [dbo].[Salons];
