### To perform the task from question 3:

* Start up the database in docker using attached docker compose:

    `docker compose up`

* Copy and execute required scripts with database initialization

    `docker cp ./sql_scripts/init_db.sql postgres_container:/init_db.sql`
  
    `docker cp ./sql_scripts/prodname_catname.sql postgres_container:/prodname_catname.sql`

    `docker exec -u postgres postgres_container psql MB_prods_cats postgres -f /init_db.sql`

    `docker exec -u postgres postgres_container psql MB_prods_cats postgres -f /prodname_catname.sql`

    
