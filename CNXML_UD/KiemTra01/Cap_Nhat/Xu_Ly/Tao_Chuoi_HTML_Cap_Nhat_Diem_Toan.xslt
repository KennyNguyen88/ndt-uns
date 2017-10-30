<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="THI_SINH">
    <xsl:variable name="SBD" select="@SBD" />
    <xsl:variable name="Diem_Toan" select="@Diem_Toan" />
    <form   action="MH_Cap_Nhat_Diem_Toan.cshtml"  method="post"    class="HOC_SINH">
      <strong>
        <xsl:value-of select="@Ho_ten"/>
      </strong>      
      <br /><input name="Th_Diem_Toan"  class="NHAP_LIEU_DIA_CHI"     value="{$Diem_Toan}" />
      <br /><input name="Th_SBD"   type="hidden"   value="{$SBD}" />
    </form>

  </xsl:template>


</xsl:stylesheet>
