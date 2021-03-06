﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DIEN_THOAI">
    <xsl:variable name="Ma_so" select="@Ma_so" />
    <input type="hidden" name="ma-so-dien-thoai" value ="{$Ma_so}"/>
    <div class="row">
      <div class="col s12">
        <div class="card-panel">
          <div class="row">
            <div class="col s12 m6">
              <xsl:for-each select="NHOM_DIEN_THOAI">
                <xsl:if test = "@Ma_so = 'IPHONE'">
                  <img class="responsive-img" src="iphone.jpg"/>
                </xsl:if>
                <xsl:if test = "@Ma_so = 'ANDROID'">
                  <img class="responsive-img" src="android.jpg"/>
                </xsl:if>
              </xsl:for-each>
            </div>
            <div class="col s12 m6">
              <ul>
                <li class="ten-dien-thoai">
                  <xsl:value-of select="@Ten"/>
                </li>
                <li class="ngay">Số Ngày Giao Dự Kiến: 1</li>
                <li class="don-gia">
                  Đơn giá: <xsl:value-of select="@Don_gia_Ban"/>
                </li>
              </ul>
              <div class="row">
                <div class="col s12 so-luong">
                  Số lượng: 1
                </div>
                <div class="col s12">
                  <p class="tong-tien">
                    Tiền: <xsl:value-of select="@Don_gia_Ban"/>
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

  </xsl:template>
</xsl:stylesheet>
