<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DANH_SACH_DIEN_THOAI">
    <div class="row">
      <xsl:apply-templates   select="DIEN_THOAI"  />
    </div>
  </xsl:template>
  <xsl:template match="DIEN_THOAI">
    <div class="col s3">
      <div class="card hoverable">
        <div class="card-image">
          <xsl:for-each select="NHOM_DIEN_THOAI">
            <xsl:if test = "@Ma_so = 'IPHONE'">
              <img src="iphone.jpg"/>
            </xsl:if>
            <xsl:if test = "@Ma_so = 'ANDROID'">
              <img src="android.jpg"/>
            </xsl:if>             
          </xsl:for-each>          
        </div>
        <div class="card-content center-align">
          <p class="ten-dien-thoai center-align"><xsl:value-of select="@Ten"/></p>
          <p class="don-gia center-align"><xsl:value-of select="@Don_gia_Ban"/></p>
        </div>
        <div class="card-action">
          <xsl:variable name="Ma_so" select="@Ma_so" />          
          <a class="valign-wrapper" href="Trang-Dat-Hang.cshtml?id={$Ma_so}">
            <i class="material-icons mr-1">shopping_cart</i>
            <p>Đặt Hàng</p>
          </a>
        </div>
      </div>
    </div>
  </xsl:template>


</xsl:stylesheet>
