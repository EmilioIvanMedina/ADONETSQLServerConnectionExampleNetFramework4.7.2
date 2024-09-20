begin tran
use websitedatabase
declare @newMenuItemId int, @newPageTitleId int, @newContactType int

insert into menu_item values ('Home', 'Principal view')
select @newMenuItemId = scope_identity()

insert into page_title values('ASP.NET', 'ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.', 'Learn more &raquo;','https://asp.net', @newMenuItemId)
select @newPageTitleId = scope_identity()

insert into page_sub_title values(@newPageTitleId, 'Getting started', 'ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and gives you full control over markup for enjoyable, agile development.', 'Learn more &raquo;', 'https://go.microsoft.com/fwlink/?LinkId=301865')
insert into page_sub_title values(@newPageTitleId, 'Get more libraries', 'NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.', 'Learn more &raquo;', 'https://go.microsoft.com/fwlink/?LinkId=301866')
insert into page_sub_title values(@newPageTitleId, 'Web Hosting', 'You can easily find a web hosting company that offers the right mix of features and price for your applications.', 'Learn more &raquo;', 'https://go.microsoft.com/fwlink/?LinkId=301867')

insert into menu_item values ('About', 'About the web page view')
select @newMenuItemId = scope_identity()

insert into page_title values('Your application description page.', 'Use this area to provide additional information.', null, null, @newMenuItemId)
select @newPageTitleId = scope_identity()

insert into menu_item values ('Contact', 'Contact links view')
select @newMenuItemId = scope_identity()

insert into page_title values('Contact', null, null, null, @newMenuItemId)
select @newPageTitleId = scope_identity()

insert into page_sub_title values(@newPageTitleId, 'Your contact page', 'One Microsoft Way<br />Redmond, WA 98052-6399<br /><abbr title="Phone">P:</abbr>425.555.0100', null, null)

insert into contact_type values('email')
select @newContactType = scope_identity()

insert into contact values (@newContactType, 'Support', 'support@example.com' )
insert into contact values (@newContactType, 'Marketing', 'marketing@example.com' )

insert into contact_type values('phone')

rollback tran