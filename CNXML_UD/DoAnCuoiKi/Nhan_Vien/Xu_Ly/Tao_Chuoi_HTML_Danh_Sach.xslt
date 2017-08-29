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
              <li class="don-gia">
                Đơn giá: <xsl:value-of select="@Don_gia"/>
              </li>
              <li class="so-luong">
                Số lượng: <xsl:value-of select="@So_luong"/>
              </li>
              <li class="tong-tien">
                Tiền: <xsl:value-of select="@Tien"/>
              </li>
              <xsl:for-each select="Khach_hang">
                <li>
                  Khách Hàng: <xsl:value-of select="@Ho_ten"/>
                </li>
                <li>
                  <xsl:value-of select="@Dia_chi"/>
                </li>
                <li>
                  Điện Thoại: <xsl:value-of select="@Dien_thoai"/>
                </li>
              </xsl:for-each>
            </ul>
            <div class="col s12 center-align">
              <form action="Trang-Chinh.cshtml" method="post">
                <xsl:for-each select="TT_Dien_Thoai">
                  <!--TODO Ma dt, so dt khach hang-->
                  <xsl:variable name="Ma_Dt" select="@Ma_So_Dien_Thoai" />
                  <input name="Ma_Dt" value="{$Ma_Dt}" type="hidden"/>
                </xsl:for-each>
                <xsl:for-each select="Khach_hang">
                  <xsl:variable name="So_Dt" select="@Dien_thoai" />                  
                  <input name="So_Dt" value="{$So_Dt}" type="hidden"/>                  
                </xsl:for-each>
                <xsl:for-each select="Nhan_vien">
                  <xsl:variable name="Ma_Nv" select="@Ma_so" />
                  <input name="Ma_Nv" value="{$Ma_Nv}" type="hidden"/>
                </xsl:for-each>
                <button type="submit" class="waves-effect waves-light btn">Xác Nhận</button>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </xsl:template>

</xsl:stylesheet>
