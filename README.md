# .net6-webApi-Vue-Study
初学.net6 和 webApi 结合Vue练习

### 返回值类型
    · 特定类型
    · IActionResult 返回状态码
    · ActionResult 返回状态码和数据模型（类型）

### Minimal APIs
    app.MapGet
    app.MapPost
    app.MapPut
    app.MapDelete
    方法其实就是一个委托，委托本质就是一个方法

### 路由约束
    路由约束限制路由的匹配规则
    app.MapGet("/{id:regex(^[a-z0-9]+$)}", delegate(string id) {return id;});

### 依赖注入
    IOC: Inversion of control 控制反转
    依赖注入是实现控制反转的一种手段或方式
    DI：Dependency Injection 
        应用程序‘依赖’IOC容器
        应用程序需要IOC容器来提供对象需要的外部资源
        将应用程序依赖的某个对象注入到IOC容器中
        注入的就是某个对象需要的外部资源（包括对象、资源、常量数据）
    IOC容器：在ASP NET Core6中指的是 ServiceCollection -> 服务收集器    
    在Minimal APIs 里也可以使用注入的类

    报错记录：Unable to resolve service for type: ... 就是没有注册

### 服务生命周期
    Transient 瞬时生命周期：每次使用的时候都会new一个对象
    Singleton 单例生命周期：只需在第一次时new
    Scoped 作用域生命周期: 线程单例，每次请求就是一个线程

### 指令
    ctor:快速创建函数