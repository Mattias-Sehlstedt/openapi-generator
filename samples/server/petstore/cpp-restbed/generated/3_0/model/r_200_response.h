/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.15.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * r_200_response.h
 *
 * Model for testing model name starting with number
 */

#ifndef r_200_response_H_
#define r_200_response_H_



#include <string>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// Model for testing model name starting with number
/// </summary>
class  r_200_response 
{
public:
    r_200_response() = default;
    explicit r_200_response(boost::property_tree::ptree const& pt);
    virtual ~r_200_response() = default;

    r_200_response(const r_200_response& other) = default; // copy constructor
    r_200_response(r_200_response&& other) noexcept = default; // move constructor

    r_200_response& operator=(const r_200_response& other) = default; // copy assignment
    r_200_response& operator=(r_200_response&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// r_200_response members

    /// <summary>
    /// 
    /// </summary>
    int32_t getName() const;
    void setName(int32_t value);

    /// <summary>
    /// 
    /// </summary>
    std::string getRClass() const;
    void setRClass(std::string value);

protected:
    int32_t m_Name = 0;
    std::string m_r_class = "";
};

std::vector<r_200_response> creater_200_responseVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<r_200_response>(const r_200_response& val) {
    return val.toPropertyTree();
}

template<>
inline r_200_response fromPt<r_200_response>(const boost::property_tree::ptree& pt) {
    r_200_response ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* r_200_response_H_ */
