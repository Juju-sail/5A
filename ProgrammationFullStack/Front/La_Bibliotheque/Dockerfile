FROM node:16 AS builder

WORKDIR /usr/src/app

COPY . .

RUN npm ci && npm build

FROM nginx

COPY nginx/ /etc/ngix/

COPY --from=builder dist/ /usr/share/nginx/html

EXPOSE 80
