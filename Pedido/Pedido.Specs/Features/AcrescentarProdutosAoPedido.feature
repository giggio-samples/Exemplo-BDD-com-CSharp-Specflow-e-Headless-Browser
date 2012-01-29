#language: pt

@web
Funcionalidade: Acrescentar produtos ao pedido

Cenário: Acrescentando um produto
	Dado um pedido novo
	Quando eu acrescento o produto Brinquedo
	Então o produto "Brinquedo" aparece no pedido

Cenário: Acrescentando outro produto
	Dado um pedido novo
	Quando eu acrescento o produto Carrinho
	Então o produto "Carrinho" aparece no pedido
	E o produto "Brinquedo" não aparece no pedido