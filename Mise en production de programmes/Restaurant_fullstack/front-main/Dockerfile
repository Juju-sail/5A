FROM node:16 AS builder

WORKDIR /usr/src/app

COPY . .

RUN npm install && npm run build

FROM nginx

COPY nginx/ /etc/ngix/

COPY --from=builder /usr/src/app/dist /usr/share/nginx/html

COPY entrypoint.sh /bin/entrypoint.sh
RUN chmod +x /bin/entrypoint.sh

EXPOSE 80

ENV BACKEND_URL_ENV_VAR=localhost

ENTRYPOINT ["entrypoint.sh"]
