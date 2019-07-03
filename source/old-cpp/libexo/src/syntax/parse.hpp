#ifndef IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HPP_INCLUDED
#define IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HPP_INCLUDED

#include <boost/config/warning_disable.hpp>
// @todo
#include <boost/spirit/include/qi.hpp>
#include <boost/spirit/include/phoenix.hpp>
#include <boost/fusion/include/adapt_struct.hpp>
#include <QtGlobal>

#undef major
#undef minor

namespace izh_bs {
namespace viaus {
namespace module {
namespace http_server {

namespace qi = boost::spirit::qi;
namespace ascii = boost::spirit::ascii;


/* rfc2616 - Hypertext Transfer Protocol -- HTTP/1.1 */
static const qi::byte_type      & OCTET   = qi::byte_;     /* rfc2616 - 2.2 Basic Rules */
static const ascii::char_type   & CHAR    = ascii::char_;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::upper_type  & UPALPHA = ascii::upper;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::lower_type  & LOALPHA = ascii::lower;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::alpha_type  & ALPHA   = ascii::alpha;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::digit_type  & DIGIT   = ascii::digit;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::cntrl_type  & CTL     = ascii::cntrl;  /* rfc2616 - 2.2 Basic Rules */
static const ascii::xdigit_type & HEX     = ascii::xdigit; /* rfc2616 - 2.2 Basic Rules */

const qi::uint_parser<char, 16, 2, 2> hex_2;
const qi::uint_parser<quint16, 16, 1, 4> hex_1_4;

template<typename iterator>
inline qi::rule<iterator, char()> & ALPHA_to_lower()
{
    using namespace boost::spirit::qi;
    static rule<iterator, char()> ret =
              LOALPHA[_val = _1]
            | UPALPHA[_val = _1 - 'A' + 'a'];
    return ret;
}


} /* namespace http_server */
} /* namespace module */
} /* namespace viaus */
} /* namespace izh_bs */

#endif // IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HPP_INCLUDED
