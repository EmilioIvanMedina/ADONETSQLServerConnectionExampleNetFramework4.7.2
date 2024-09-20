begin tran
-- create database websitedatabase
use websitedatabase

create table menu_item 
(
    id_menu_item int identity(1,1) primary key,
    menu_item_text nvarchar(50) null,
    menu_item_description nvarchar(150) null
)

create table page_title
(
    id_page_title int identity(1,1) primary key,
    title nvarchar(50) null,
    title_description nvarchar(200) null,
    button_link_text nvarchar(50) null,
    linkUrl nvarchar(100) null,
    id_menu_item int,
    constraint fk_menuitem foreign key (id_menu_item) references menu_item(id_menu_item) on delete cascade
)

create INDEX IX_PageTitle_MenuItem on page_title(id_menu_item)

create table page_sub_title
(
    id_page_subtitle int identity(1,1) primary key, 
    id_page_title int,
    subtitle nvarchar(50) null,
    subtitle_description nvarchar(300) null,
    button_link_text nvarchar (50) null,
    linkUrl nvarchar(100) null,
    constraint fk_page_title foreign key (id_page_title) references page_title(id_page_title) on delete cascade
)

create INDEX IX_PageSubTitle_PageTitle on page_sub_title(id_page_title)

create table contact_type
(
    id_contact_type int identity(1,1) primary key,
    contact_type_description nvarchar(50) not null
)

create table contact
(
    id_contact int identity(1,1) primary key,
    id_contact_type int,
    contact nvarchar(50),
    contact_name nvarchar(50) not null,
    constraint fk_contacttype foreign key (id_contact_type) references contact_type(id_contact_type) on delete cascade
)

create index IX_Contact_ContacType on contact(id_contact_type)
rollback tran