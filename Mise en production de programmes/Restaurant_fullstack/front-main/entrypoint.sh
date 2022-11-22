#!/bin/sh

sed -i 's/{{ BACKEND_URL }}/$BACKEND_URL_ENV_VAR/g' /usr/share/nginx/html/*

exec "$@"
