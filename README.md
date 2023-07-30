# Web API Şablon 
- Farklı projelerde tekrarlanan işlevleri tekrar baştan yazmak yerine, tekrar amaçlı olan bölümleri içeren bir web API projesidir. Yani bu proje bir web API projesi için temel yapıyı ve işlevselliği sağlar.

- .NET 7 ile geliştirilmiştir.

- Mimari olarak Onion Architecture kullanılmıştır. Onion Architecture, projenin katmanlara ayrılmasını ve bu katmanların bağımsız olmasını sağlayan bir tasarım yaklaşımıdır. Bu yaklaşım, katmanlar arasındaki bağımlılıkları azaltarak daha esnek ve bakımı kolay bir yapı oluşturmayı amaçlar.

## Onion Architecture
Katmanlar hakkında,

- Core Katmanı: Temel iş mantığı ve varlık sınıflarının bulunduğu katmandır.

- Infrastructure Katmanı: Veri tabanı erişimi, harici servislerle iletişim ve diğer dış bağlantıları sağlayan katmandır.

- Application Katmanı: İş mantığının uygulandığı, Core ve Infrastructure katmanları arasında arabirim görevi gören katmandır.

- Presentation Katmanı: Kullanıcı arayüzü ve istemci ile iletişimi sağlayan katmandır.
 ##
     
 ##
 # Web API Template
- It is a web API project that contains repurposed parts instead of rewriting functionality that is repeated in different projects. So this project provides the basic structure and functionality for a web API project.

- It is developed with .NET 7.

- Onion Architecture is used as architecture. Onion Architecture is a design approach that allows the project to be divided into layers and these layers to be independent. This approach aims to create a more flexible and maintainable structure by reducing dependencies between layers.

## Onion Architecture
About layers,

- Core Layer: The layer containing the core business logic and entity classes.

- Infrastructure Layer: The layer that provides database access, communication with external services and other external connections.

- Application Layer: The layer where business logic is implemented and acts as an interface between the Core and Infrastructure layers.

- Presentation Layer: The layer that provides the user interface and communication with the client.
