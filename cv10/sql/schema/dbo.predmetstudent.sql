CREATE TABLE [dbo].[predmetstudent] (
    [id_student] INT          NOT NULL,
    [id_predmet] NVARCHAR (4) NOT NULL,
    CONSTRAINT [FK_PREDMETSTUDENT_ID_PREDMET] FOREIGN KEY ([id_predmet]) REFERENCES [dbo].[predmet] ([zkratka]),
    CONSTRAINT [FK_PREDMETSTUDENT_ID_STUDENT] FOREIGN KEY ([id_student]) REFERENCES [dbo].[student] ([id])
);

