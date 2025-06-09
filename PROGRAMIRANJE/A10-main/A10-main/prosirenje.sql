CREATE TABLE [dbo].[Oprema] (
    [OpremaID] INT          NOT NULL,
    [Naziv]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([OpremaID] ASC)
);

CREATE TABLE [dbo].[UlovOprema]
(
    [PecarosId] INT NOT NULL , 
    [RbrUlova] INT NOT NULL, 
    [OpremaID] INT NOT NULL, 
    CONSTRAINT [FK_UlovOprema_ToUlov] FOREIGN KEY ([RbrUlova],[PecarosId]) REFERENCES [Ulov]([RbrUlova],[PecarosId]), 
    CONSTRAINT [FK_UlovOprema_ToOprema] FOREIGN KEY ([OpremaID]) REFERENCES [Oprema]([OpremaID]), 
    PRIMARY KEY ([PecarosId], [OpremaID], [RbrUlova])
);