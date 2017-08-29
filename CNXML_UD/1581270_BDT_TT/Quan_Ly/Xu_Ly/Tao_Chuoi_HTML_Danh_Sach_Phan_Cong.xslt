<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DANH_SACH_DIEN_THOAI">
    <div class="row">
      <xsl:apply-templates select="DIEN_THOAI"  />
    </div>
  </xsl:template>

  <xsl:template match="DIEN_THOAI">
    <div class="row">
      <div class="col s12">
        <div class="card-panel">
          <div class="row">
            <div class="col s12">
              <h5>
                <xsl:value-of select="@Ten"/>
              </h5>
            </div>
          </div>
          <div class="row">
            <xsl:for-each select="PHIEU_DAT">
              <xsl:if test = "@Trang_thai = 'CHO_PHAN_CONG'">
                <div class="col s3">
                  <div class="card">
                    <div class="card-image">
                      <div class="status blue white-text">Chờ Phân Công</div>
                    </div>
                    <div class="card-content">
                      <ul>
                        <li class="ngay">
                          Ngày đặt hàng: <xsl:value-of select="@Ngay"/>
                        </li>
                        <li class="so-luong">
                          Số lượng: <xsl:value-of select="@So_luong"/>
                        </li>
                        <xsl:for-each select="Khach_hang">
                          <li>
                            Địa Chỉ: 55 Kiều cao Hạ,Phường 6,Quận Thủ đức, Ho Chi Minh City, Ho Chi
                            Minh, Vietnam
                          </li>
                        </xsl:for-each>

                      </ul>
                    </div>
                    <div class="card-action">
                      <a class="valign-wrapper" href="#">
                        <i class="material-icons mr-1">people</i>
                        <p>Phân công</p>
                      </a>
                    </div>
                  </div>
                </div>
              </xsl:if>
            </xsl:for-each>
          </div>
        </div>
      </div>
    </div>
  </xsl:template>
</xsl:stylesheet>
