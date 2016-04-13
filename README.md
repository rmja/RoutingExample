Code sample reproducing https://github.com/aspnet/Routing/issues/307

```
# dotnet --version
1.0.0-rc2-002372
# dotnet restore
# dotnet run
```

Go to `http://localhost:5000/Sales/Audi/Products`. There are three links on that page:

```
<a href="/Sales/Audi/Products/Details/1337">Go to product details (in same area) (Working link)</a>
<a href="/Tickets?area=Support">Go to support tickets (in different area) (Broken link)</a>
<a href="/Support/Audi/Tickets">Go to support tickets (in different area) (Working link)</a>
```

The middle link is not correctly generated, as the wrong (default) route is used for generating the link instead of the custom (defaultWithManufacturer) route.
