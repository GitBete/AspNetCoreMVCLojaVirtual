use lojavirtual
go

Select * from pedidos
where id = 12

Select * from pedidosituacoes
where pedidoid = 12

return

Update pedidos
Set Situacao = 'Entregue'
where id = 12

Update pedidosituacoes
Set Situacao = 'Entregue', Data = '2020-06-14 23:00:00.2186928'
where pedidoid = 12
and id = 54

delete pedidosituacoes
where pedidoid = 12
and id = 55