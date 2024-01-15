FROM gradle:7.5.0-jdk17
WORKDIR /opt/app
COPY ./build/libs/WebShop-1.0-SNAPSHOT.jar ./

ENTRYPOINT ["sh", "-c", "java ${JAVA_OPTS} -jar WebShop-1.0-SNAPSHOT.jar"]