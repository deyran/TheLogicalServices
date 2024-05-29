# .NET MAUI :  Acessando o SQLite

## Pacotes a serem instalados

1. sqlite-net-pcl						1.8.116
2. SQLitePCLRaw.bundle_green			2.1.6
3. SQLitePCLRaw.core					2.1.6
4. SQLitePCLRaw.provider.dynamic_cdecl	2.1.6
5. CommunityToolkit.Mvvm				8.2.1

## Criar classes modelo de domínio

## Atributos da biblioteca SQLite.Net

1. [Table]
2. [Column]
3. [PrimaryKey]
4. [NotNull]
5. [ForeignKey]
6. [Unique]
7. [AutoIncrement]

## Tipos de dados no SQLite

1. Integer
2. Real
3. Text
4. Blog	

## Mapeamento

1. No diretório MVVM/Models

```
using SQLite

[Table("Contato")]
public class Contato
{
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }

	[MaxLength(100), NotNull]
	public string Nome { get; set; }

	[MaxLength(200), NotNull]
	public string Email { get; set; }
}
```

2. DB Browser for SQLite

Permite criar, pesquisar e editar banco de dados SQLite

3. 