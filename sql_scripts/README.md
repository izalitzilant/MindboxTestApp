## How to set up a database in docker

### Use next commands to:

* connect to containers terminal:
`docker exec -it container_name bash`

* copy script to container:
`docker cp ./script_name.sql postgres_container:/script_name.sql`

* execute copied script in container:
`docker exec -u postgres postgres_container psql MB_prods_cats postgres -f /script_name.sql`

## To perform the target_taks for question3
