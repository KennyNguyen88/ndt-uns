<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DANH_SACH_PHIEU_DAT">
    <div class="row">
      <xsl:apply-templates select="PHIEU_DAT"  />
    </div>
  </xsl:template>
  
  <xsl:template match="PHIEU_DAT">
    <div class="col s6">
      <div class="card-panel">
        <div class="row">
          <div class="col s3">
            <xsl:for-each select="TT_Dien_Thoai">
              <xsl:if test = "@Ma_Nhom_Dien_Thoai = 'IPHONE'">
                <img class="responsive-img" src="iphone.jpg"/>
              </xsl:if>
              <xsl:if test = "@Ma_Nhom_Dien_Thoai = 'ANDROID'">
                <img class="responsive-img" src="android.jpg"/>
              </xsl:if>
            </xsl:for-each>
          </div>
          <div class="col s9">
            <ul>
              <li class="ten-dien-thoai">
                <xsl:for-each select="TT_Dien_Thoai">
                  <xsl:value-of select="@Ten_Dien_Thoai"/>
                </xsl:for-each>
              </li>
              <li class="don-gia">Đơn giá: <xsl:value-of select="@Don_gia"/>
            </li>
              <li class="so-luong">Số lượng: <xsl:value-of select="@So_luong"/>
            </li>
              <li class="tong-tien">Tiền: <xsl:value-of select="@Tien"/>
            </li>
              <xsl:for-each select="Khach_hang">
                <li>Khách Hàng: <xsl:value-of select="@Ho_ten"/>
              </li>
                <li>
                  <xsl:value-of select="@Dia_chi"/>
                </li>
                <li>Điện Thoại: <xsl:value-of select="@Dien_thoai"/>
              </li>
              </xsl:for-each>              
            </ul>
            <div class="col s12 center-align">
              <!--TODO Ma dt, so dt khach hang-->
              <a href="Trang-Chinh.cshtml?Ma_Dt=">Giao Hàng</a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </xsl:template>
  
</xsl:stylesheet>
