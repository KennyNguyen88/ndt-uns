<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DIEN_THOAI">
    <div class="row">
      <div class="col s12">
        <div class="card-panel">
          <div class="row">
            <div class="col s3">
              <xsl:for-each select="NHOM_DIEN_THOAI">
                <xsl:if test = "@Ma_so = 'IPHONE'">
                  <img class="responsive-img" src="iphone.jpg"/>
                </xsl:if>
                <xsl:if test = "@Ma_so = 'ANDROID'">
                  <img class="responsive-img" src="android.jpg"/>
                </xsl:if>
              </xsl:for-each>
            </div>
            <div class="col s9">
              <p class="ten-dien-thoai">
                <xsl:value-of select="@Ten"/>
              </p>
              <div class="row">

                <div class="col s12 don-gia">
                  Đơn giá
                  <div class="input-field inline s12">
                    <xsl:variable name="DonGia">
                      <xsl:value-of select="@Don_gia_Ban"/>
                    </xsl:variable>
                    <input class="center-align" id="don-gia" type="number" value="{$DonGia}"/>
                  </div>
                </div>
                <div class="col s12">
                  <button type="submit" class="waves-effect waves-light btn">Cập Nhật</button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </xsl:template>
</xsl:stylesheet>
