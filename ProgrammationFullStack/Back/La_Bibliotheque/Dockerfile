FROM maven:3.8-openjdk-18 as builder

WORKDIR usr/src/app

COPY . .

RUN mvn clean package -DskipTests=true


FROM openjdk:18-jdk

EXPOSE 8080

WORKDIR usr/src/app

COPY --from=builder usr/src/app/target/fs-back-*.jar project.jar

CMD ["java", "-jar", "project.jar"]
