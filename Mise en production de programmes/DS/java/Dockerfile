FROM maven:3.8-openjdk-8 as builder

WORKDIR usr/src/app

COPY . .

RUN mvn clean package -DskipTests=true

FROM openjdk:8-jdk

EXPOSE 8448

LABEL maintainer="Juliette"

WORKDIR usr/src/app

COPY --from=builder usr/src/app/target/java-*.jar ds.jar

CMD ["java", "-jar", "ds.jar"]