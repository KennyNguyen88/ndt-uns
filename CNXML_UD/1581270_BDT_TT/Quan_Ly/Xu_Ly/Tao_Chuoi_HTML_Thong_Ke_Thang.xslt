<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DANH_SACH_NGAY">
    <xsl:for-each select="Tong_Thu">
    <h3 class="center-align">
      Tháng <xsl:value-of select="@Thang"/> - Tổng thu <span class="text-red">
        <xsl:value-of select="@Tien"/>
      </span>
    </h3>
    </xsl:for-each>
    <div class="row">
      <div class="col s12">
        <xsl:apply-templates select="Thong_Ke_Ngay"  />
      </div>
    </div>    
  </xsl:template>
  <xsl:template match="Thong_Ke_Ngay">
    <div class="card-panel">
      <div class="row mb-0 valign-wrapper">
        <div class="col s2 valign-wrapper">
          <i class="small material-icons">date_range</i>
          <span class="thong-ke">
            <xsl:value-of select="@Ngay"/>
          </span>
        </div>
        <div class="col s8 don-gia"> <xsl:value-of select="@Doanh_Thu"/>
      </div>
        <div class="col s2 right-align thong-ke">
          <xsl:value-of select="@Ti_Le"/>%</div>
      </div>
    </div>
  </xsl:template>
</xsl:stylesheet>
