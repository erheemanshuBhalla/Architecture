An Architecture Project with Dapper Framework, SQL Connection, .net Core, Repository Pattern, Unit of work, Visual Studio

```
Architecture V4
├─ App.API
│  ├─ App.API.csproj
│  ├─ App.API.csproj.user
│  ├─ App.API.http
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
│  ├─ Controllers
│  │  ├─ ProductController.cs
│  │  ├─ UserController.cs
│  │  └─ WeatherForecastController.cs
│  ├─ obj
│  │  ├─ App.API.csproj.nuget.g.props
│  │  ├─ App.API.csproj.nuget.g.targets
│  │  └─ Debug
│  │     └─ net8.0
│  │        ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │        ├─ App.API.csproj.Up2Date
│  │        ├─ App.API.GeneratedMSBuildEditorConfig.editorconfig
│  │        ├─ App.API.GlobalUsings.g.cs
│  │        ├─ App.API.MvcApplicationPartsAssemblyInfo.cache
│  │        ├─ App.API.MvcApplicationPartsAssemblyInfo.cs
│  │        ├─ rbcswa.dswa.cache.json
│  │        ├─ ref
│  │        ├─ refint
│  │        ├─ rpswa.dswa.cache.json
│  │        ├─ staticwebassets
│  │        ├─ staticwebassets.build.endpoints.json
│  │        ├─ staticwebassets.build.json
│  │        ├─ staticwebassets.build.json.cache
│  │        ├─ staticwebassets.references.upToDateCheck.txt
│  │        └─ staticwebassets.removed.txt
│  ├─ Program.cs
│  ├─ Properties
│  │  └─ launchSettings.json
│  └─ WeatherForecast.cs
├─ App.Domain
│  ├─ App.Core.csproj
│  ├─ Class1.cs
│  ├─ Entities
│  │  ├─ Product.cs
│  │  └─ User.cs
│  ├─ Interfaces
│  │  ├─ IDbConnectionFactory.cs
│  │  ├─ IProductRepository.cs
│  │  ├─ IRepository.cs
│  │  ├─ IUnitOfWork.cs
│  │  └─ IUserRepository.cs
│  └─ obj
│     ├─ App.Core.csproj.nuget.dgspec.json
│     ├─ App.Core.csproj.nuget.g.props
│     ├─ App.Core.csproj.nuget.g.targets
│     ├─ App.Domain.csproj.nuget.dgspec.json
│     ├─ App.Domain.csproj.nuget.g.props
│     ├─ App.Domain.csproj.nuget.g.targets
│     ├─ Debug
│     │  └─ net8.0
│     │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│     │     ├─ App.Core.assets.cache
│     │     ├─ App.Core.GeneratedMSBuildEditorConfig.editorconfig
│     │     ├─ App.Core.GlobalUsings.g.cs
│     │     ├─ App.Domain.AssemblyInfo.cs
│     │     ├─ App.Domain.AssemblyInfoInputs.cache
│     │     ├─ App.Domain.assets.cache
│     │     ├─ App.Domain.GeneratedMSBuildEditorConfig.editorconfig
│     │     ├─ App.Domain.GlobalUsings.g.cs
│     │     ├─ ref
│     │     └─ refint
│     ├─ project.assets.json
│     └─ project.nuget.cache
├─ App.Infrastructure
│  ├─ App.Infrastructure.csproj
│  ├─ Class1.cs
│  ├─ DapperRepositories
│  │  ├─ BaseRepository.cs
│  │  ├─ ProductRepository.cs
│  │  └─ UserRepository.cs
│  ├─ Data
│  │  ├─ DataInitializer.cs
│  │  └─ SqlConnectionFactory.cs
│  ├─ obj
│  │  ├─ App.Infrastructure.csproj.nuget.g.props
│  │  ├─ App.Infrastructure.csproj.nuget.g.targets
│  │  └─ Debug
│  │     └─ net8.0
│  │        ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │        ├─ App.Infr.D9A1D18F.Up2Date
│  │        ├─ App.Infrastructure.GeneratedMSBuildEditorConfig.editorconfig
│  │        ├─ App.Infrastructure.GlobalUsings.g.cs
│  │        ├─ ref
│  │        └─ refint
│  └─ UnitofWork
│     └─ DapperUnitOfWork.cs
├─ App.Services
│  ├─ App.BL.csproj
│  ├─ Class1.cs
│  ├─ obj
│  │  ├─ App.BL.csproj.nuget.dgspec.json
│  │  ├─ App.BL.csproj.nuget.g.props
│  │  ├─ App.BL.csproj.nuget.g.targets
│  │  ├─ App.Services.csproj.nuget.dgspec.json
│  │  ├─ App.Services.csproj.nuget.g.props
│  │  ├─ App.Services.csproj.nuget.g.targets
│  │  ├─ Debug
│  │  │  └─ net8.0
│  │  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │  │     ├─ App.BL.assets.cache
│  │  │     ├─ App.BL.csproj.Up2Date
│  │  │     ├─ App.BL.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ App.BL.GlobalUsings.g.cs
│  │  │     ├─ App.Services.AssemblyInfo.cs
│  │  │     ├─ App.Services.AssemblyInfoInputs.cache
│  │  │     ├─ App.Services.assets.cache
│  │  │     ├─ App.Services.GeneratedMSBuildEditorConfig.editorconfig
│  │  │     ├─ App.Services.GlobalUsings.g.cs
│  │  │     ├─ ref
│  │  │     └─ refint
│  │  ├─ project.assets.json
│  │  └─ project.nuget.cache
│  └─ Services
│     ├─ ProductService.cs
│     └─ UserService.cs
├─ App.Web
│  ├─ .editorconfig
│  ├─ angular.json
│  ├─ App.Web.esproj
│  ├─ CHANGELOG.md
│  ├─ karma.conf.js
│  ├─ obj
│  │  └─ Debug
│  │     ├─ App.Web.esproj.CoreCompileInputs.cache
│  │     └─ package.g.props
│  ├─ package-lock.json
│  ├─ package.json
│  ├─ public
│  │  └─ favicon.ico
│  ├─ README.md
│  ├─ src
│  │  ├─ app
│  │  │  ├─ app-routing.module.ts
│  │  │  ├─ app.component.css
│  │  │  ├─ app.component.html
│  │  │  ├─ app.component.spec.ts
│  │  │  ├─ app.component.ts
│  │  │  └─ app.module.ts
│  │  ├─ index.html
│  │  ├─ main.ts
│  │  └─ styles.css
│  ├─ tsconfig.app.json
│  ├─ tsconfig.json
│  └─ tsconfig.spec.json
├─ appsettings.Development.json
├─ appsettings.json
├─ Architecture V4.csproj
├─ Architecture V4.csproj.user
├─ Architecture V4.sln
├─ Controllers
│  ├─ HomeController.cs
│  ├─ ProductController.cs
│  └─ UserController.cs
├─ Models
│  └─ ErrorViewModel.cs
├─ obj
│  ├─ Architecture V4.csproj.nuget.dgspec.json
│  ├─ Architecture V4.csproj.nuget.g.props
│  ├─ Architecture V4.csproj.nuget.g.targets
│  ├─ Debug
│  │  └─ net8.0
│  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │     ├─ Architecture V4.AssemblyInfo.cs
│  │     ├─ Architecture V4.AssemblyInfoInputs.cache
│  │     ├─ Architecture V4.assets.cache
│  │     ├─ Architecture V4.GeneratedMSBuildEditorConfig.editorconfig
│  │     ├─ Architecture V4.GlobalUsings.g.cs
│  │     ├─ Architecture V4.RazorAssemblyInfo.cache
│  │     ├─ Architecture V4.RazorAssemblyInfo.cs
│  │     ├─ ref
│  │     ├─ refint
│  │     ├─ rpswa.dswa.cache.json
│  │     ├─ staticwebassets
│  │     └─ staticwebassets.removed.txt
│  ├─ project.assets.json
│  └─ project.nuget.cache
├─ Program.cs
├─ Properties
│  └─ launchSettings.json
├─ README.md
├─ Todo.txt
├─ Views
│  ├─ Home
│  │  ├─ Index.cshtml
│  │  └─ Privacy.cshtml
│  ├─ Shared
│  │  ├─ Error.cshtml
│  │  ├─ _Layout.cshtml
│  │  ├─ _Layout.cshtml.css
│  │  └─ _ValidationScriptsPartial.cshtml
│  ├─ _ViewImports.cshtml
│  └─ _ViewStart.cshtml
└─ wwwroot
   ├─ css
   │  └─ site.css
   ├─ favicon.ico
   ├─ js
   │  └─ site.js
   └─ lib
      ├─ bootstrap
      │  ├─ dist
      │  │  ├─ css
      │  │  │  ├─ bootstrap-grid.css
      │  │  │  ├─ bootstrap-grid.css.map
      │  │  │  ├─ bootstrap-grid.min.css
      │  │  │  ├─ bootstrap-grid.min.css.map
      │  │  │  ├─ bootstrap-grid.rtl.css
      │  │  │  ├─ bootstrap-grid.rtl.css.map
      │  │  │  ├─ bootstrap-grid.rtl.min.css
      │  │  │  ├─ bootstrap-grid.rtl.min.css.map
      │  │  │  ├─ bootstrap-reboot.css
      │  │  │  ├─ bootstrap-reboot.css.map
      │  │  │  ├─ bootstrap-reboot.min.css
      │  │  │  ├─ bootstrap-reboot.min.css.map
      │  │  │  ├─ bootstrap-reboot.rtl.css
      │  │  │  ├─ bootstrap-reboot.rtl.css.map
      │  │  │  ├─ bootstrap-reboot.rtl.min.css
      │  │  │  ├─ bootstrap-reboot.rtl.min.css.map
      │  │  │  ├─ bootstrap-utilities.css
      │  │  │  ├─ bootstrap-utilities.css.map
      │  │  │  ├─ bootstrap-utilities.min.css
      │  │  │  ├─ bootstrap-utilities.min.css.map
      │  │  │  ├─ bootstrap-utilities.rtl.css
      │  │  │  ├─ bootstrap-utilities.rtl.css.map
      │  │  │  ├─ bootstrap-utilities.rtl.min.css
      │  │  │  ├─ bootstrap-utilities.rtl.min.css.map
      │  │  │  ├─ bootstrap.css
      │  │  │  ├─ bootstrap.css.map
      │  │  │  ├─ bootstrap.min.css
      │  │  │  ├─ bootstrap.min.css.map
      │  │  │  ├─ bootstrap.rtl.css
      │  │  │  ├─ bootstrap.rtl.css.map
      │  │  │  ├─ bootstrap.rtl.min.css
      │  │  │  └─ bootstrap.rtl.min.css.map
      │  │  └─ js
      │  │     ├─ bootstrap.bundle.js
      │  │     ├─ bootstrap.bundle.js.map
      │  │     ├─ bootstrap.bundle.min.js
      │  │     ├─ bootstrap.bundle.min.js.map
      │  │     ├─ bootstrap.esm.js
      │  │     ├─ bootstrap.esm.js.map
      │  │     ├─ bootstrap.esm.min.js
      │  │     ├─ bootstrap.esm.min.js.map
      │  │     ├─ bootstrap.js
      │  │     ├─ bootstrap.js.map
      │  │     ├─ bootstrap.min.js
      │  │     └─ bootstrap.min.js.map
      │  └─ LICENSE
      ├─ jquery
      │  ├─ dist
      │  │  ├─ jquery.js
      │  │  ├─ jquery.min.js
      │  │  └─ jquery.min.map
      │  └─ LICENSE.txt
      ├─ jquery-validation
      │  ├─ dist
      │  │  ├─ additional-methods.js
      │  │  ├─ additional-methods.min.js
      │  │  ├─ jquery.validate.js
      │  │  └─ jquery.validate.min.js
      │  └─ LICENSE.md
      └─ jquery-validation-unobtrusive
         ├─ jquery.validate.unobtrusive.js
         ├─ jquery.validate.unobtrusive.min.js
         └─ LICENSE.txt

```