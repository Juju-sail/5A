FROM node:10  AS builder

WORKDIR /usr/src/app

COPY . .

RUN npm install && npm run build

FROM nginx

EXPOSE 80

LABEL maintainer="Juliette"

ENV BACKEND_URL_ENV_VAR=localhost

COPY nginx/ /etc/nginx/
COPY entrypoint.sh /docker-entrypoint.d/sed.sh
COPY --from=builder /usr/src/app/dist /usr/share/nginx/html

RUN chmod +x /docker-entrypoint.d/sed.sh

