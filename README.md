# CusDataAPI
MFRP

To use the API:
- Create an sql db.

- Copy connection string of the db.

- Replace CusDataDB connection string with the recently copied connection string in appsettings.json

- Open Package Manager Console in Visual Studio, and run the below commands.
```
add-migration init
```
```
update-database -verbose
```
Now you can run the API.
