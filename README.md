<img align="left" width="100" height="100" src="icon.png" />

# Cities Brazil API [![Build status](https://dev.azure.com/igor-couto/cities-br/_apis/build/status/cities-br-api%20-%20CI)](https://dev.azure.com/igor-couto/cities-br/_build/latest?definitionId=1) [![GitHub license](https://img.shields.io/github/license/igor-couto/cities-br-api.svg)](https://github.com/igor-couto/cities-br-api/blob/master/LICENSE)

Public API that provides information about cities in Brazil. Work in Progress.

## About

.NET Core Rest API. The data is stored in a mongodb database.

## Usage

You can use the cities/ endpoint to make GET requests with search string parameters.

## Endpoints
Currently, only two endpoints are available:

### Cities
**GET** `https://URL/cities/`

**GET** `https://URL/cities/`**[id]**

**GET** `https://URL/cities?`**q=[QUERY STRING]&sort=[PARAMETER]&order=[ASC|DESC]**

### States
**GET** `https://URL/states/`

**GET** `https://URL/states/`**[id]**

**GET** `https://URL/states?`**q=[QUERY STRING]&sort=[PARAMETER]&order=[ASC|DESC]**


## Author

* **Igor Couto** - [igor.fcouto@gmail.com](mailto:igor.fcouto@gmail.com)

**Enjoy!**
