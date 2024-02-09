# Dockerfile

FROM mariadb:10.4.26

ENV MYSQL_ROOT_PASSWORD mysql
COPY initDatabase.sql ./docker-entrypoint-initdb.d/
