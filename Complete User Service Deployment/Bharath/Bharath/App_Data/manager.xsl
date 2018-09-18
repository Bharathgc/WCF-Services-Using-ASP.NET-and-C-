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
			<h1>Users :</h1>
			<table border="1">
				<tr> 
					<td>First Name</td> 
					<td>Last Name</td> 
					<td>Username</td>
					<td>Password</td>
					<td>Email ID</td> 
				</tr>
				<xsl:for-each select="Pagemembers/member">
					<xsl:sort select="Name/Last" />
          <xsl:if test="Desgination = 'User'">
					<tr style="font-size: 10pt; font-family: Arial">
						<td><xsl:value-of select="Name/FirstName"/></td>
						<td><xsl:value-of select="Name/LastName"/></td>
						<td><xsl:value-of select="Username"/></td>
						<td><xsl:value-of select="Password"/></td>
						<td><xsl:value-of select="Emailid"/></td>
					</tr>
          </xsl:if>
        </xsl:for-each>
			</table>
			<h1>Staff :</h1>
			<table border="1">
				<tr> 
					<td>First Name</td> 
					<td>Last Name</td> 
					<td>Username</td>
					<td>Password</td>
					<td>Email ID</td> 
				</tr>
				<xsl:for-each select="Pagemembers/member">
					<xsl:sort select="Name/Last" />
          <xsl:if test="Desgination = 'Staff'">
					<tr style="font-size: 10pt; font-family: Arial">
						<td><xsl:value-of select="Name/FirstName"/></td>
						<td><xsl:value-of select="Name/LastName"/></td>
						<td><xsl:value-of select="Username"/></td>
						<td><xsl:value-of select="Password"/></td>
						<td><xsl:value-of select="Emailid"/></td>
					</tr>
          </xsl:if>
        </xsl:for-each>
			</table>
		</body> </html>
	</xsl:template>
</xsl:stylesheet>