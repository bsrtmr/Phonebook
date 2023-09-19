Proje, Visual Studio'da .Net Core 6 ile yazıldı ve .Net Core 6'da bulunan swagger ile dokümente edildi.
ORM aracı olarak Entity Framework kullanıldı.
Veri tabanı olarak PostgreSql kullanıldı, Db klasörüne backup dosyası eklendi.

User.API ile rehberde kişi ve kişinin iletişim bilgileri ile ilgili işlemler yapılıyor. https://localhost:7241/swagger/index.html  Url'i ile bu servise ulaşım sağlanabilir.


Reporting.API ile rehbere kayıtlı kişilerin konumları ile ilgili veriyi getiriyoruz. https://localhost:7076/swagger/index.html Url'i ile bu servise ulaşım sağlanabilir.


Reporting servisteki işlemleri Kafka consumer ile dinleme işlemi yapılmaya çalışıldı.

Kafka kurulumu için aşağıdaki adımlar izlendi:

Kafkayı https://kafka.apache.org/quickstart dan indirdikten sonra 

tar -xzf kafka_2.13-3.5.0.tgz
cd kafka_2.13-3.5.0

komutları çalıştırıldı.

Kafka'nın java ve zookeper dependency'leri bulunğu için zookeeper ve java kurulumu yapıldı.

Zookeper kurulumu için:
C:\kafka_2.13-3.5.0>cd bin
C:\kafka_2.13-3.5.0\bin>cd windows
C:\kafka_2.13-3.5.0\bin\windows>zookeeper-server-start.bat ../../config/zookeeper.properties

Kafka kurulumu için:
C:\kafka_2.13-3.5.0>cd bin
C:\kafka_2.13-3.5.0\bin>cd windows
C:\kafka_2.13-3.5.0\bin\windows>kafka-server-start.bat ../../config/server.properties

