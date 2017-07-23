<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="DANH_SACH_THI_SINH">
    <div class="DANH_SACH_HOC_SINH" id="Th_Danh_Sach_Thi_Sinh">
      <xsl:apply-templates   select="THI_SINH"  />

    </div>
  </xsl:template>
  <xsl:template match="THI_SINH">
    <details  class="HOC_SINH"  >
      <summary>
        <span>
          <strong>
            <xsl:value-of select="@Ho_ten"/>(<xsl:value-of select="@SBD"/>)
          </strong>
          
        </span>
      </summary>
      <div style="color:black">
        <br /> Điểm Toán: <xsl:value-of select="@Diem_Toan"/>
        <br /> Điểm Văn: <xsl:value-of select="@Diem_Van"/>
        <br /> Điểm Anh Văn: <xsl:value-of select="@Diem_Anh_van"/>
        <br /> Điểm Thưởng: <xsl:value-of select="@Diem_Thuong"/>
        <br /> Điểm Xét Tuyển: <xsl:value-of select="@Diem_Xet_tuyen"/>
        <xsl:for-each select="TRUONG_CAP_2">
          <br />   <xsl:value-of  select="@Ten"/>  -  <xsl:value-of  select="@Ma_so"/>
        </xsl:for-each>
        <xsl:for-each select="TRUONG_CAP_3">
        <br />   <xsl:value-of  select="@Ten"/>  -  <xsl:value-of  select="@Ma_so"/>
      </xsl:for-each>

      </div>



    </details >
  </xsl:template>


</xsl:stylesheet>
