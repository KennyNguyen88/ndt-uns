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

    <div class="col s12 m6 l4 xl3">
      <div class="card">
        <div class="card-image">
          <xsl:if test ="@Trang_thai = 'CHO_PHAN_CONG'">
            <div class="status blue white-text">
              <xsl:for-each select="TT_Dien_Thoai">
                <xsl:value-of select="@Ten_Dien_Thoai"/>
              </xsl:for-each>
            </div>
          </xsl:if>
          <xsl:if test ="@Trang_thai = 'CHO_GIAO'">
            <div class="status orange white-text">
              <xsl:for-each select="TT_Dien_Thoai">
                <xsl:value-of select="@Ten_Dien_Thoai"/>
              </xsl:for-each>
            </div>
          </xsl:if>
          <xsl:if test ="@Trang_thai = 'DA_GIAO'">
            <div class="status green white-text">
              <xsl:for-each select="TT_Dien_Thoai">
                <xsl:value-of select="@Ten_Dien_Thoai"/>
              </xsl:for-each>
            </div>
          </xsl:if>
        </div>
        <div class="card-content">
          <ul>
            <li class="ngay">Ngày đặt hàng: <xsl:value-of select="@Ngay"/>
          </li>
            <li class="so-luong">
              Số lượng: <xsl:value-of select="@So_luong"/>
            </li>            
          </ul>
        </div>
      </div>
    </div>
        
  </xsl:template>

</xsl:stylesheet>
