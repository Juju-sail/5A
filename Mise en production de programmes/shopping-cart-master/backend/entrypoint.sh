#!/bin/sh

python /usr/src/app/manage.py migrate

exec "$@"