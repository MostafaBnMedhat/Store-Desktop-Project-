create table Customer
(
  	CustomerID int,
	Name varchar(50),
	password varchar(50),
	Email varchar(50), 
	Address varchar(50),
	Phone varchar(50),
    primary key (CustomerID)
);
insert into Customer values 
  (1, 'ammar ahmed','5050', 'ammar@email.com', 'cairo', '01111111111'),
 (2, 'Bob Johnson','5050', 'bob@email.com', '456 Oak Ave', '987-654-3210'),
 (3, 'Charlie Brown','5050', 'charlie@email.com', '789 Elm St', '111-222-3333'),
 (4, 'David Lee','5050', 'david@email.com', '321 Maple Dr', '444-555-6666'),
 (5, 'Eva Garcia','5050', 'eva@email.com', '555 Pine Ave', '777-888-9999'),
 (6, 'Frank White','5050', 'frank@email.com', '678 Walnut Ln', '333-222-1111'),
 (7, 'Grace Turner','5050', 'grace@email.com', '901 Cedar St', '555-444-3333'),
 (8, 'Hannah Baker', '5050','hannah@email.com', '234 Birch Ave', '999-888-7777'),
 (9, 'Ian Foster','5050', 'ian@email.com', '765 Spruce Dr', '222-333-4444'),
 (10, 'Jennifer Hall','5050', 'jennifer@email.com', '543 Cherry Rd', '888-999-0000'), 
 (11, 'Kevin Young','5050', 'kevin@email.com', '876 Oakwood Blvd', '777-666-5555'),
 (12, 'Lily Adams','5050', 'lily@email.com', '432 Elmwood Ave', '666-777-8888'),
 (13, 'Mike Clark','5050', 'mike@email.com', '789 Pinecone Ln', '444-333-2222'),
 (14, 'Nancy Green','5050', 'nancy@email.com', '210 Maplewood Dr', '333-444-5555'),
 (15, 'Olivia King', '5050','olivia@email.com', '987 Cedarwood Dr', '222-111-0000'),
 (16, 'Paul Miller','5050', 'paul@email.com', '654 Oakhurst Rd', '111-222-3333'),
 (17, 'Quinn Harris', '5050','quinn@email.com', '345 Pine Ridge', '999-888-7777'),
 (18, 'Rachel Scott','5050', 'rachel@email.com', '543 Birchwood Ave', '888-777-6666'),
 (19, 'Sam Taylor', '5050','sam@email.com', '876 Elmwood Blvd', '777-666-5555'),
(20, 'Tina Wright', '5050','tina@email.com', '234 Spruceland Dr', '666-555-4444');

create table Sellers(
	sellerID INT PRIMARY KEY,
	sellerName varchar(50),
	sellerPassword varchar(50)
)
insert into Sellers values
(1, 'reda', '5050');
