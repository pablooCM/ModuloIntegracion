create database Ventas
use Ventas

create table solicitudes
(id_solicitud integer,
descripcion varchar(50),
primary key (id_solicitud)
)engine = InnoDB;

create table vendedores
(id_vendedor integer not null COMMENT 'PK',
cedula integer not null COMMENT 'cedula vendedor',
nombre varchar(20) not null COMMENT 'nombre del vendedor',
apellido1 varchar(20) not null COMMENT 'primer apellido del vendedor',
apellido2 varchar(20) not null COMMENT 'segundo apellido vendedor',
paisV varchar(20) not  null COMMENT 'pais donde vive el vendedor',
ciudadV varchar(20) not null COMMENT 'ciudad donde vive el vendedor',
correo varchar(20)  COMMENT 'correo electronico del vendedor',
categoria varchar(20) COMMENT 'categoria deacuerdo a las ventas realizadas',
-- contrato integer not null COMMENT 'num contrato',
primary key (id_vendedor)
-- foreign key(contrato) references venta(num_contrato)
)engine = InnoDB;

create table venta 
(num_contrato integer not null COMMENT 'PK',
cedula_cliente integer not null COMMENT 'Cedula del cliente',
id_servicio integer not null COMMENT 'id del servicio',
monto_pago integer not null COMMENT 'monto del pago',
pais varchar(20) not null COMMENT 'pais del servicio',
ciudad varchar(20) not null COMMENT 'ciudad',
fecha_inicio date not null COMMENT 'fecha que inicio el servicio',
solicitud integer not null COMMENT 'solicitud de la venta',
vendedor integer not null,
primary key(num_contrato),
foreign key(solicitud) references solicitudes (id_solicitud),
foreign Key(vendedor) references vendedores(id_vendedor)
)engine = InnoDB;

create table cobros
(id_servicio integer not null COMMENT 'identificador del cobro PK',
fecha_cobro date not null COMMENT 'fecha del cobro',
contratoV integer not null COMMENT 'contrato de vente',
estado varchar(20) COMMENT 'de acuerdo al tiempo que transcurre '
primary key(id_servicio),
foreign key (contratoV) references venta(num_contrato)
)engine = InnoDB;

create table pagos
(servicio integer not null COMMENT 'id para hacer el pago PK', 
fecha_pago date not null COMMENT 'fecha de pago',
primary key(servicio),
foreign key(servicio) references cobros(id_servicio)
)engine = InnoDB;

/*create table categoria 
(vendedor integer not null COMMENT 'id_vendedor PK',
categoria varchar(20) not null COMMENT 'categoria',
primary key(vendedor),
foreign key(vendedor) references vendedores(id_vendedor),
check(categoria  in ('junior', 'medio', 'superior', 'campeona', 'megavendedor')
)engine = InnoDB;*/

/*create table estadoCobro
(cobro integer not null COMMENT 'id_servicio PK',
estado varchar(30) not null COMMENT 'estado de cobror a tiempo, atrasado o cobro judicial', 
primary key(cobro),
foreign key(cobro) references cobros(id_servicio)
)engine = InnoDB;*/

