CREATE TABLE [dbo].[Patient] (
    [PatientID]  INT           IDENTITY (1, 1) NOT NULL,
    [PatName]    VARCHAR (40)  NULL,
    [PatAddress] NVARCHAR (30) NULL,
    [AdmitDept]  INT           NULL,
    [RefDoc]     INT           NULL,
    [CreatedBy]  INT           NULL,
    [PatImage] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([PatientID] ASC),
    FOREIGN KEY ([AdmitDept]) REFERENCES [dbo].[Department] ([DepartmentID]),
    FOREIGN KEY ([RefDoc]) REFERENCES [dbo].[Doctor] ([DoctorID]),
    FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[UserInfo] ([UserInfoID])
);

