/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import org.apache.commons.lang3.builder.EqualsBuilder;
import org.apache.commons.lang3.builder.HashCodeBuilder;
import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.StringJoiner;
import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import java.math.BigDecimal;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import org.openapitools.client.ApiClient;
/**
 * BananaReq
 */
@JsonPropertyOrder({
  BananaReq.JSON_PROPERTY_LENGTH_CM,
  BananaReq.JSON_PROPERTY_SWEET
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.15.0-SNAPSHOT")
public class BananaReq {
  public static final String JSON_PROPERTY_LENGTH_CM = "lengthCm";
  @javax.annotation.Nonnull
  private BigDecimal lengthCm;

  public static final String JSON_PROPERTY_SWEET = "sweet";
  @javax.annotation.Nullable
  private Boolean sweet;

  public BananaReq() { 
  }

  public BananaReq lengthCm(@javax.annotation.Nonnull BigDecimal lengthCm) {
    this.lengthCm = lengthCm;
    return this;
  }

  /**
   * Get lengthCm
   * @return lengthCm
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_LENGTH_CM)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public BigDecimal getLengthCm() {
    return lengthCm;
  }


  @JsonProperty(JSON_PROPERTY_LENGTH_CM)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setLengthCm(@javax.annotation.Nonnull BigDecimal lengthCm) {
    this.lengthCm = lengthCm;
  }


  public BananaReq sweet(@javax.annotation.Nullable Boolean sweet) {
    this.sweet = sweet;
    return this;
  }

  /**
   * Get sweet
   * @return sweet
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_SWEET)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Boolean getSweet() {
    return sweet;
  }


  @JsonProperty(JSON_PROPERTY_SWEET)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setSweet(@javax.annotation.Nullable Boolean sweet) {
    this.sweet = sweet;
  }


  /**
   * Return true if this bananaReq object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    return EqualsBuilder.reflectionEquals(this, o, false, null, true);
  }

  @Override
  public int hashCode() {
    return HashCodeBuilder.reflectionHashCode(this);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BananaReq {\n");
    sb.append("    lengthCm: ").append(toIndentedString(lengthCm)).append("\n");
    sb.append("    sweet: ").append(toIndentedString(sweet)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @return URL query string
   */
  public String toUrlQueryString() {
    return toUrlQueryString(null);
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    String suffix = "";
    String containerSuffix = "";
    String containerPrefix = "";
    if (prefix == null) {
      // style=form, explode=true, e.g. /pet?name=cat&type=manx
      prefix = "";
    } else {
      // deepObject style e.g. /pet?id[name]=cat&id[type]=manx
      prefix = prefix + "[";
      suffix = "]";
      containerSuffix = "]";
      containerPrefix = "[";
    }

    StringJoiner joiner = new StringJoiner("&");

    // add `lengthCm` to the URL query string
    if (getLengthCm() != null) {
      joiner.add(String.format("%slengthCm%s=%s", prefix, suffix, ApiClient.urlEncode(ApiClient.valueToString(getLengthCm()))));
    }

    // add `sweet` to the URL query string
    if (getSweet() != null) {
      joiner.add(String.format("%ssweet%s=%s", prefix, suffix, ApiClient.urlEncode(ApiClient.valueToString(getSweet()))));
    }

    return joiner.toString();
  }

    public static class Builder {

    private BananaReq instance;

    public Builder() {
      this(new BananaReq());
    }

    protected Builder(BananaReq instance) {
      this.instance = instance;
    }

    public BananaReq.Builder lengthCm(BigDecimal lengthCm) {
      this.instance.lengthCm = lengthCm;
      return this;
    }
    public BananaReq.Builder sweet(Boolean sweet) {
      this.instance.sweet = sweet;
      return this;
    }


    /**
    * returns a built BananaReq instance.
    *
    * The builder is not reusable.
    */
    public BananaReq build() {
      try {
        return this.instance;
      } finally {
        // ensure that this.instance is not reused
        this.instance = null;
      }
    }

    @Override
    public String toString() {
      return getClass() + "=(" + instance + ")";
    }
  }

  /**
  * Create a builder with no initialized field.
  */
  public static BananaReq.Builder builder() {
    return new BananaReq.Builder();
  }

  /**
  * Create a builder with a shallow copy of this instance.
  */
  public BananaReq.Builder toBuilder() {
    return new BananaReq.Builder()
      .lengthCm(getLengthCm())
      .sweet(getSweet());
  }

}

