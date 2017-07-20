<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

  <xsl:template match="THI_SINH">
    <div class="HOC_SINH"  >
      <strong>
        <xsl:value-of select="@Ho_ten"/> - <xsl:value-of select="@SBD"/>
      </strong>
      <br /> <xsl:value-of select="@Diem_Toan"/>  
      <br /> <xsl:value-of select="@Diem_Van"/>
      <br /> <xsl:value-of select="@Diem_Anh_van"/>
      <br /> <xsl:value-of select="@Diem_Thuong"/>
      <br /> <xsl:value-of select="@Diem_Xet_tuyen"/>
      <xsl:for-each select="TRUONG_CAP_2">
        <br />   <xsl:value-of  select="@Ten"/>  -  <xsl:value-of  select="@Ma_so"/>
      </xsl:for-each>
    </div>
  </xsl:template>
  
</xsl:stylesheet>
