<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
		<head>
		<style>
			h1 {
				font-family: "Times New Roman", Times, serif;
				font-size: 40px;
				font-weight: 400;
				line-height: 30px;		
			}

			b {
			font-family: "Times New Roman", Times, serif;
			font-size: 15px;
			line-height: 20px;
			}
		</style>
		</head>  
			<body>
			<h1>Persons</h1>
			<table border="1">
				<tr> 
					<td>First Name</td> 
					<td>Last Name</td> 
					<td>ID</td> 
					<td>Work Phone</td> 
					<td>Cell Phone</td> 
					<td>Provider</td> 
					<td>Category</td>
				</tr>
				<xsl:for-each select="Persons/Person">
					<xsl:sort select="Name/Last" />
					<tr style="font-size: 10pt; font-family: Arial">
						<td><xsl:value-of select="Name/First"/></td>
						<td><xsl:value-of select="Name/Last"/></td>
						<td><xsl:value-of select="Credential/Id"/></td>
						<td><xsl:value-of select="Phone/Work"/></td>
						<td><xsl:value-of select="Phone/Cell"/></td>
						<td><xsl:value-of select="Phone/Cell/@Provider"/></td>
						<td><xsl:value-of select="Category"/></td>
					</tr>
				</xsl:for-each>
			</table>
		</body> </html>
	</xsl:template>
</xsl:stylesheet>