CREATE TABLE [dbo].[student] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [jmeno]    NVARCHAR (50) NOT NULL,
    [prijmeni] NVARCHAR (50) NOT NULL,
    [dat_nar]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

