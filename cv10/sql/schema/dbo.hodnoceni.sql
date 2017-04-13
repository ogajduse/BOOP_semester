CREATE TABLE [dbo].[hodnoceni] (
    [id_student] INT          NOT NULL,
    [id_predmet] NVARCHAR (4) NOT NULL,
    [datum]      DATE         NOT NULL,
    [znamka]     FLOAT (53)   NOT NULL,
    CONSTRAINT [FK_HODNOCENI_ID_STUDENT] FOREIGN KEY ([id_student]) REFERENCES [dbo].[student] ([id]),
    CONSTRAINT [FK_HODNOCENI_ID_PREDMET] FOREIGN KEY ([id_predmet]) REFERENCES [dbo].[predmet] ([zkratka])
);

