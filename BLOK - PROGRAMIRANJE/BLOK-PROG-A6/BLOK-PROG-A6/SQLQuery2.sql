﻿ALTER TABLE Vozilo
ADD VlasinkID INT NOT NULL,
FOREIGN KEY (VlasinkID) REFERENCES Vlasnici(VlasinkID);
