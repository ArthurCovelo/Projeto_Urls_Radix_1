CREATE TABLE public.urls (
	id serial4 NOT NULL,
	link text NOT NULL,
	CONSTRAINT urls_pkey PRIMARY KEY (id)
);

CREATE TABLE public."__EFMigrationsHistory" (
	"MigrationId" varchar(150) NOT NULL,
	"ProductVersion" varchar(32) NOT NULL,
	CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);