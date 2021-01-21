CREATE TABLE currencyYM (
  [id] AUTOINCREMENT,
  [name] TEXT NOT NULL,  
  PRIMARY KEY (id)
);

CREATE TABLE typeOperationYM (
  [id] AUTOINCREMENT,
  [name] TEXT NOT NULL,  
  PRIMARY KEY (id)
);
CREATE TABLE CourseYM (
  [id] AUTOINCREMENT,
  [currency] INTEGER NOT NULL,
  [ratioToTheDollarUnit] FLOAT NOT NULL,  
  PRIMARY KEY (id),
  FOREIGN KEY([currency]) REFERENCES currencyYM(id)
);

CREATE TABLE AccountingForTransactionsYM (
  [id] AUTOINCREMENT,
  [dates] DATE NOT NULL,
  [currency] INTEGER NOT NULL,
  [count] INTEGER NOT NULL,
  [typeOperation] INTEGER NOT NULL,
  [summ] FLOAT,
  PRIMARY KEY (id),
  FOREIGN KEY([currency]) REFERENCES currencyYM(id),
  FOREIGN KEY([typeOperation]) REFERENCES typeOperationYM(id)
);



