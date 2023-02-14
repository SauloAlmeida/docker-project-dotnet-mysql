FROM mysql
COPY migration.sql /docker-entrypoint-initdb.d/
ENV MYSQL_ALLOW_EMPTY_PASSWORD=yes