#ifndef IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_URI_HPP_INCLUDED
#define IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_URI_HPP_INCLUDED

#include <boost/fusion/tuple.hpp>
#include "parse.hpp"

namespace izh_bs {
namespace viaus {
namespace module {
namespace http_server {

namespace qi = boost::spirit::qi;
namespace phx = boost::phoenix;


/* rfc3986 - Uniform Resource Identifier (URI): Generic Syntax */


template <typename iterator>
struct uri_rules
{
    qi::rule<iterator, char()> pct_encoded;
    qi::rule<iterator, char()> reserved;
    qi::rule<iterator, char()> gen_delims;
    qi::rule<iterator, char()> sub_delims;
    qi::rule<iterator, char()> sub_delims_extra;
    qi::rule<iterator, char()> unreserved;
    qi::rule<iterator, char()> unreserved_to_lower;

    qi::rule<iterator> hier_part;
    qi::rule<iterator> scheme;
    qi::rule<iterator> authority;
    qi::rule<iterator> userinfo;
    qi::rule<iterator> host;
    qi::rule<iterator> IP_literal;
    qi::rule<iterator, boost::fusion::vector<uint, std::string>()> IPvFuture;
    qi::rule<iterator, std::vector<quint16>(), qi::locals<int> > IPv6address;
    qi::rule<iterator, quint16()> h16;
    qi::rule<iterator> IPv4address;
    qi::rule<iterator, uint> dec_octet;
    qi::rule<iterator> reg_name;
    qi::rule<iterator> port;
    qi::rule<iterator> path_abempty;
    qi::rule<iterator> path_absolute;
    qi::rule<iterator> path_rootless;
    qi::rule<iterator> path_empty;
    qi::rule<iterator> segment;
    qi::rule<iterator> segment_nz;
    qi::rule<iterator> pchar;
    qi::rule<iterator> query;
    qi::rule<iterator> absolute_URI;

    uri_rules()
        : pct_encoded()
        , reserved()
        , gen_delims()
        , sub_delims()
        , sub_delims_extra()
        , unreserved()
        , unreserved_to_lower()
        , hier_part()
        , scheme()
        , authority()
        , userinfo()
        , host()
        , IP_literal()
        , IPvFuture()
        , IPv6address()
        , h16()
        , IPv4address()
        , dec_octet()
        , reg_name()
        , port()
        , path_abempty()
        , path_absolute()
        , path_rootless()
        , path_empty()
        , segment()
        , segment_nz()
        , pchar()
        , query()
        , absolute_URI()
    {
        using namespace boost::spirit::qi;


        pct_encoded %= '%' >> hex_2;         /* rfc3986 - 2.1. Percent-Encoding */

        reserved %= gen_delims | sub_delims; /* rfc3986 - 2.2. Reserved Characters */
        gen_delims %= char_(":/?#[]@");      /* rfc3986 - 2.2. Reserved Characters */
        sub_delims %= char_("!$&’()*+,;=");  /* rfc3986 - 2.2. Reserved Characters */
        sub_delims_extra %= char_("!$&’()*+,;=:");

        unreserved %= ALPHA | DIGIT | char_("-._ ");  /* rfc3986 - 2.3. Unreserved Characters */
        unreserved_to_lower %= ALPHA_to_lower<iterator>() | DIGIT | char_("-._ ");

        /* 3. Syntax Components
         * URI = scheme ":" hier-part [ "?" query ] [ "#" fragment ]
         * hier-part = "//" authority path-abempty
         *              / path-absolute
         *              / path-rootless
         *              / path-empty
         */

        scheme %= ALPHA_to_lower<iterator>() >>
                 *(
                      ALPHA_to_lower<iterator>()
                      | DIGIT
                      | char_("+-.")
                  );                         /* rfc3986 - 3.1. Scheme */


        /* 3.2. Authority
         * authority = [ userinfo "@" ] host [ ":" port ]
         *
         * 3.2.1. User Information
         * userinfo = *( unreserved / pct-encoded / sub-delims / ":" )
         *
         * 3.2.2. Host
         * host = IP-literal / IPv4address / reg-name
         * IP-literal = "[" ( IPv6address / IPvFuture ) "]"
         */

        IPvFuture %= 'v' >> qi::hex >> '.' >> +(unreserved_to_lower | sub_delims_extra); /* rfc3986 - 3.2.2. Host */

        // @todo Оптимизировать.
        IPv6address %= /* rfc3986 - 3.2.2. Host */
                          hold[                                                                                                       repeat(7)[ h16 >> ':' ] >> h16 ]
                        | hold[                                                                    "::" >> repeat(1     )[attr(0)] >> repeat(6)[ h16 >> ':' ] >> h16 ]
                        | hold[                -(h16[_a++]                                    ) >> "::" >> repeat(2 - _a)[attr(0)] >> repeat(5)[ h16 >> ':' ] >> h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 1)[ ':' >> h16[_a++] ]) >> "::" >> repeat(3 - _a)[attr(0)] >> repeat(4)[ h16 >> ':' ] >> h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 2)[ ':' >> h16[_a++] ]) >> "::" >> repeat(4 - _a)[attr(0)] >> repeat(3)[ h16 >> ':' ] >> h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 3)[ ':' >> h16[_a++] ]) >> "::" >> repeat(5 - _a)[attr(0)] >> repeat(2)[ h16 >> ':' ] >> h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 4)[ ':' >> h16[_a++] ]) >> "::" >> repeat(6 - _a)[attr(0)] >>            h16 >> ':'   >> h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 5)[ ':' >> h16[_a++] ]) >> "::" >> repeat(7 - _a)[attr(0)] >>                            h16 ]
                        | hold[ eps[_a = 0] >> -(h16[_a++] >> repeat(0, 6)[ ':' >> h16[_a++] ]) >> "::" >> repeat(8 - _a)[attr(0)]                                   ];

        h16 %= hex_1_4; /* rfc3986 - 3.2.2. Host */

         /*
         * IPv4address = dec-octet "." dec-octet "." dec-octet "." dec-octet
         * dec-octet = DIGIT             ; 0-9
         *           | %x31-39 DIGIT     ; 10-99
         *           | "1" 2DIGIT        ; 100-199
         *           | "2" %x30-34 DIGIT ; 200-249
         *           | "25" %x30-35      ; 250-255
         */

        // dec_octet = /* rfc3986 - 3.2.2. Host */
// not compiled ?       DIGIT[_val = _1] >> DIGIT[_val += _1];


         /* reg-name = *( unreserved / pct-encoded / sub-delims )
         *
         * 3.2.3. Port
         * port = *DIGIT
         *
         * 3.3. Path
         * path = path-abempty  ; begins with "/" or is empty
         *      | path-absolute ; begins with "/" but not "//"
         *      | path-noscheme ; begins with a non-colon segment
         *      | path-rootless ; begins with a segment
         *      | path-empty    ; zero characters
         *
         * path-abempty  = *( "/" segment )
         * path-absolute = "/" [ segment-nz *( "/" segment ) ]
         * path-noscheme = segment-nz-nc *( "/" segment )
         * path-rootless = segment-nz *( "/" segment )
         * path-empty    = 0<pchar>
         * segment = *pchar
         * segment-nz = 1*pchar
         * segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
         * pchar = unreserved / pct-encoded / sub-delims / ":" / "@"
         *
         * 3.4. Query
         * query = *( pchar / "/" / "?" )
         *
         * 3.5. Fragment
         * fragment = *( pchar / "/" / "?" )
         *
         * 4.1. URI Reference
         * URI-reference = URI / relative-ref
         *
         * 4.2. Relative Reference
         * relative-ref = relative-part [ "?" query ] [ "#" fragment ]
         * relative-part = "//" authority path-abempty
         *               / path-absolute
         *               / path-noscheme
         *               / path-empty
         *
         * 4.3. Absolute URI
         * absolute-URI = scheme ":" hier-part [ "?" query ]
         *
         */
    }
};


} /* namespace http_server */
} /* namespace module */
} /* namespace viaus */
} /* namespace izh_bs */

#endif // IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_URI_HPP_INCLUDED
