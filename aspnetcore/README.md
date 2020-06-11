# IO.Swagger - ASP.NET Core 2.0 Server

Health-check API  See: [https://tools.ietf.org/html/draft-inadarei-api-health-check-04#section-3.8]() 

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
