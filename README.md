# Example to capture hooks

## Prerequisites

- .Net Core
- node.js

## Run

```
dotnet run
```

The swagger will be available [here](http://localhost:5000/swagger)

## Use ngrok as proxy

### Install ngrok globally

```
npm i ngrok -g
```

### Run ngrok

```
ngrok http 5000
```

Unfortunately swagger works, but REST API call got stuck.

## How to test

File [GithubWebhookCatcher.postman_collection.json] contains Postman collection.
In development mode you can also use swagger

## Deploy with Heroku/Docker

### Prerequisites

1. Create heroku account
2. Create application
3. Choose container registry as deployment method
4. Make sure application works locally


### Login to heroku
```
heroku login
heroku container:login
```

### Push container
```
heroku container:push -a github-capture web
```

### Release the container
```
heroku container:release -a github-capture web
```

test change

