-- migrate:up
CREATE TABLE CreativeDbContext(
	Id				int,
	Title			varchar(255),
	ReleaseDate		Date,
	Genre			varchar(255),
	Price 			decimal
);

-- migrate:down

