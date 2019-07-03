#ifndef IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HTTP_HPP_INCLUDED
#define IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HTTP_HPP_INCLUDED

#include "parse.hpp"

namespace izh_bs {
namespace viaus {
namespace module {
namespace http_server {


struct proto_version
{
    uint major;
    uint minor;

    proto_version();
    proto_version(uint major, uint minor);
};

bool operator<(const proto_version &, const proto_version &);
bool operator==(const proto_version &, const proto_version &);
std::ostream & operator<<(std::ostream &, const proto_version &);

boost::spirit::qi::as<proto_version> const as_proto_version;


struct proto
{
    std::string name;
    proto_version ver;

    proto();
    proto(std::string name, uint major, uint minor);
};

bool operator==(const proto &, const proto &);
std::ostream & operator<<(std::ostream &, const proto &);


} /* namespace http_server */
} /* namespace module */
} /* namespace viaus */
} /* namespace izh_bs */


#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Weffc++"
BOOST_FUSION_ADAPT_STRUCT(
    izh_bs::viaus::module::http_server::proto_version,
    (uint, major)
    (uint, minor)
)
BOOST_FUSION_ADAPT_STRUCT(
    izh_bs::viaus::module::http_server::proto,
    (std::string, name)
    (izh_bs::viaus::module::http_server::proto_version, ver)
)
#pragma GCC diagnostic pop


namespace izh_bs {
namespace viaus {
namespace module {
namespace http_server {

namespace qi = boost::spirit::qi;


/* rfc2616 - Hypertext Transfer Protocol -- HTTP/1.1 */

template <typename iterator>
struct http_rules
{
    const qi::rule<iterator> CR;
    const qi::rule<iterator> LF;
    const qi::rule<iterator> SP;
    const qi::rule<iterator> HT;
    const qi::rule<iterator> DQM; /* in rfc2616 writed as <"> */
    qi::rule<iterator> CRLF;
    qi::rule<iterator> LWS;

    /** A CRLF is allowed in the definition of TEXT only as part of a
     * header field continuation. It is expected that the folding LWS
     * will be replaced with a single SP before interpretation of the
     * TEXT value. */
    qi::rule<iterator, char()> TEXT;
    qi::rule<iterator, char()> TEXT_without_LWS;
    qi::rule<iterator, std::string()> token;
    qi::rule<iterator> separators;
    qi::rule<iterator, std::string()> comment;
    qi::rule<iterator, char()> ctext;
    qi::rule<iterator, char()> ctext_without_LWS;
    qi::rule<iterator, std::string()> quoted_string;
    qi::rule<iterator, char()> qdtext;
    qi::rule<iterator, char()> quoted_pair;
    qi::rule<iterator, proto()> HTTP_Version;

    http_rules()
        : CR('\r')                    /* rfc2616 - 2.2 Basic Rules */
        , LF('\n')                    /* rfc2616 - 2.2 Basic Rules */
        , SP(' ')                     /* rfc2616 - 2.2 Basic Rules */
        , HT('\t')                    /* rfc2616 - 2.2 Basic Rules */
        , DQM('"')                    /* rfc2616 - 2.2 Basic Rules */
        , CRLF()
        , LWS()
        , TEXT()
        , TEXT_without_LWS()
        , token()
        , separators()
        , comment()
        , ctext()
        , ctext_without_LWS()
        , quoted_string()
        , qdtext()
        , quoted_pair()
        , HTTP_Version()
    {
        using namespace boost::spirit::qi;

        CRLF = -CR >> LF;             /* rfc2616 - 2.2 Basic Rules & 19.3 Tolerant Applications */
        LWS = -CRLF >> +(SP | HT);                                 /* rfc2616 - 2.2 Basic Rules */

        TEXT %= ( + LWS)[_val = ' '] | (OCTET - CTL);              /* rfc2616 - 2.2 Basic Rules - модифицирован */
        /*         \___ Модифицирован, чтоб несколько LWS воспринимались как один ' '. */
        TEXT_without_LWS %= OCTET - CTL /* it's includes CR LF. */ - SP - HT;

        token %= lexeme[ +(CHAR - CTL - separators) ];             /* rfc2616 - 2.2 Basic Rules */
        separators %= char_("()<>@,;:\\\"/[]?={} \t");             /* rfc2616 - 2.2 Basic Rules */

        comment %=  char_('(') >>
                    *LWS >>
                    ( +(quoted_pair | ctext_without_LWS) | comment ) >>
                   *(
                        hold[
                            *LWS >>
                            attr(' ') >>
                            ( +(quoted_pair | ctext_without_LWS) | comment )
                        ]
                    ) >>
                    *LWS >>
                    char_(')');                                    /* rfc2616 - 2.2 Basic Rules - модифицирован */
        ctext %= TEXT - '(' - ')';                                 /* rfc2616 - 2.2 Basic Rules */
        ctext_without_LWS %= TEXT_without_LWS - '(' - ')';

        quoted_string %= lexeme[ DQM >> *(quoted_pair | qdtext) >> DQM ];    /* rfc2616 - 2.2 Basic Rules */
        qdtext %= TEXT - DQM;                                      /* rfc2616 - 2.2 Basic Rules */
        quoted_pair %= '\\' >> CHAR;                               /* rfc2616 - 2.2 Basic Rules */

        HTTP_Version %= string("HTTP") >> '/'
                >> as_proto_version[uint_ >> '.' >> uint_];        /* rfc2616 - 3.1 HTTP Version */


        /* 3.2.2 http URL
         * http_URL = "http:" "//" host [ ":" port ] [ path-absolute [ "?" query ]]

           3.2.3 URI Comparison
        When comparing two URIs to decide if they match or not, a client SHOULD use a case-sensitive octet-by-octet
        comparison of the entire URIs, with these exceptions:
        • A port that is empty or not given is equivalent to the default port for that URI-reference;
        • Comparisons of host names MUST be case-insensitive;
        • Comparisons of scheme names MUST be case-insensitive;
        • An empty path-absolute is equivalent to an path-absolute of “/”.
        Characters other than those in the “reserved” and “unsafe” sets (see RFC 2396 [42]) are equivalent to their “ "%"
        HEX HEX” encoding.
        For example, the following three URIs are equivalent:
        http://abc.com:80/~smith/home.html
        http://ABC.com/%7Esmith/home.html
        http://ABC.com:/%7esmith/home.html

        * 3.3.1 Full Date
        * HTTP-date = rfc1123-date | rfc850-date | asctime-date
        * rfc1123-date =  wkday "," SP date1 SP time SP "GMT"
        * rfc850-date = weekday "," SP date2 SP time SP "GMT"
        * asctime-date = wkday SP date3 SP time SP 4DIGIT
        * date1 = 2DIGIT SP month SP 4DIGIT
                 ; day month year (e.g., 02 Jun 1982)
        * date2 = 2DIGIT "-" month "-" 2DIGIT
                 ; day-month-year (e.g., 02-Jun-82)
        * date3 = month SP ( 2DIGIT | ( SP 1DIGIT ))
                 ; month day (e.g., Jun 2)
        * time = 2DIGIT ":" 2DIGIT ":" 2DIGIT
                 ; 00:00:00 - 23:59:59
        * wkday = "Mon" | "Tue" | "Wed" | "Thu" | "Fri" | "Sat" | "Sun"
        * weekday = "Monday" | "Tuesday" | "Wednesday" | "Thursday" | "Friday" | "Saturday" | "Sunday"
        * month = "Jan" | "Feb" | "Mar" | "Apr" | "May" | "Jun" | "Jul" | "Aug" | "Sep" | "Oct" | "Nov" | "Dec"

        * 3.3.2 Delta Seconds
        * delta-seconds = 1*DIGIT

        * 3.4 Character Sets
        * charset = token     HTTP character sets are identified by case-insensitive tokens.

        * 3.5 Content Codings
        * content-coding = token     case-insensitive.
        *    used in  Accept-Encoding (section 14.3) and Content-Encoding (section 14.11)
        *    gzip, compress, deflate, identity

        * 3.6 Transfer Codings
        * transfer-coding = "chunked" | transfer-extension
        * transfer-extension = token *( ";" parameter )
        * parameter = attribute "=" value
        * attribute = token
        * value = token | quoted-string
        *    All transfer-coding values are case-insensitive.
        *    HTTP/1.1 uses transfer-coding values in the TE header field (section 14.39)
        *  and in the Transfer-Encoding header field (section 14.41).
        *    Whenever a transfer-coding is applied to a message-body, the set of transfer-codings MUST include “chunked”,
        unless the message is terminated by closing the connection. When the “chunked” transfer-coding is used, it MUST
        be the last transfer-coding applied to the message-body.
        *    “chunked” (section 3.6.1), “identity” (section 3.6.2), “gzip” (section 3.5), “compress” (section 3.5), and “deflate” (section 3.5).

        * 3.6.1 Chunked Transfer Coding
        * Chunked-Body = *chunk last-chunk trailer CRLF
        * chunk = chunk-size [ chunk-extension ] CRLF chunk-data CRLF
        * chunk-size = 1*HEX
        * last-chunk = 1*("0") [ chunk-extension ] CRLF
        * chunk-extension = *( ";" chunk-ext-name [ "=" chunk-ext-val ] )
        * chunk-ext-name = token
        * chunk-ext-val = token | quoted-string
        * chunk-data = chunk-size(OCTET)
        * trailer = *(entity-header CRLF)

        * 3.7 Media Types
        * media-type = type "/" subtype *( ";" parameter )
        * type = token
        * subtype = token
        *    The type, subtype, and parameter attribute names are case-insensitive.

        * 3.8 Product Tokens
        * product = token ["/" product-version]
        * product-version = token

        * 3.9 Quality Values
        * qvalue = ( "0" [ "." 0*3DIGIT ] )
        *        | ( "1" [ "." 0*3("0") ] )

        * 3.10 Language Tags
        *    uses language tags within the Accept-Language and Content-Language fields.
        * language-tag = primary-tag *( "-" subtag )
        * primary-tag = 1*8ALPHA
        * subtag = 1*8ALPHA
        *    all tags are case-insensitive.
        *
        * 3.11 Entity Tags
        *    HTTP/1.1 uses entity tags in the ETag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        *    The definition of how they are used and compared as cache validators is in section 13.3.3.
        * entity-tag = [ weak ] opaque-tag
        * weak = "W/"
        * opaque-tag = quoted-string
        *
        * 3.12 Range Units
        * range-unit = bytes-unit | other-range-unit
        * bytes-unit = "bytes"
        * other-range-unit = token
        *
        * 4.1 Message Types
        * HTTP-message = Request | Response ; HTTP/1.1 messages
        * generic-message = start-line
        *                   (message-header CRLF)
        *                   CRLF
        *                   [ message-body ]
        * start-line = Request-Line | Status-Line
        *    In the interest of robustness, servers SHOULD ignore any empty line(s) received where a Request-Line is expected.
        *
        *
        *
        *
        *
        * 4.2 Message Headers
        * message-header = field-name ":" [ field-value ]
        * field-name = token  ; case-insensitive.
        * field-value = *( LWS | field-content )
        * field-content = *TEXT | <combinations of token, separators, and quoted-string>
        *    Field names are case-insensitive.
        *    The field-content does not include any leading or trailing LWS.
        *    Multiple message-header fields with the same field-name MAY be present in a message if and only if the entire
        *  field-value for that header field is defined as a comma-separated list [i.e., #(values)].
        *
        * 4.3 Message Body
        * message-body = entity-body
        *              | <entity-body encoded as per Transfer-Encoding>
        *
        * The presence of a message-body in a request is signaled by the inclusion of a Content-Length or Transfer-
        * Encoding header field in the request’s message-headers.
        *
        * 4.5 General Header Fields
        * general-header = Cache-Control
        *    | Connection
        *    | Date
        *    | Pragma
        *    | Trailer
        *    | Transfer-Encoding
        *    | Upgrade
        *    | Via
        *    | Warning
        *
        * 5 Request
        * Request = Request-Line
        *           *(( general-header
        *            | request-header
        *            | entity-header ) CRLF)
        *           CRLF
        *           [ message-body ]
        *
        * 5.1 Request-Line
        * Request-Line = Method SP Request-URI SP HTTP-Version CRLF
        *
        *   19.3 Tolerant Applications
        *   Clients SHOULD be tolerant in parsing the Status-Line and servers tolerant when parsing the Request-
        *   Line. In particular, they SHOULD accept any amount of SP or HT characters between fields, even though only a
        *   single SP is required.
        *
        *
        * 5.1.1 Method
        * Method = "OPTIONS" ; Section 9.2
            | "GET" ; Section 9.3
            | "HEAD" ; Section 9.4
            | "POST" ; Section 9.5
            | "PUT" ; Section 9.6
            | "DELETE" ; Section 9.7
            | "TRACE" ; Section 9.8
            | "CONNECT" ; Section 9.9
            | extension-method
        * extension-method = token
        *
        * 5.1.2 Request-URI
        * Request-URI = "*" | absolute-URI | path-absolute | authority
        *
        * 5.3 Request Header Fields
        * request-header = Accept ; Section 14.1
                | Accept-Charset ; Section 14.2
                | Accept-Encoding ; Section 14.3
                | Accept-Language ; Section 14.4
                | Authorization ; Section 14.8
                | Expect ; Section 14.20
                | From ; Section 14.22
                | Host ; Section 14.23
                | If-Match ; Section 14.24
                | If-Modified-Since ; Section 14.25
                | If-None-Match ; Section 14.26
                | If-Range ; Section 14.27
                | If-Unmodified-Since ; Section 14.28
                | Max-Forwards ; Section 14.31
                | Proxy-Authorization ; Section 14.34
                | Range ; Section 14.35
                | Referer ; Section 14.36
                | TE ; Section 14.39
                | User-Agent
        *
        * 6 Response
        * Response = Status-Line
                     *(( general-header
                      | response-header
                      | entity-header ) CRLF)
                     CRLF
                     [ message-body ]
        *
        * 6.1 Status-Line
        * Status-Line = HTTP-Version SP Status-Code SP Reason-Phrase CRLF
        *
        *   19.3 Tolerant Applications
        *   Clients SHOULD be tolerant in parsing the Status-Line and servers tolerant when parsing the Request-
        *   Line. In particular, they SHOULD accept any amount of SP or HT characters between fields, even though only a
        *   single SP is required.
        *
        *
        * 6.1.1 Status Code and Reason Phrase
        * extension-code = 3DIGIT
        * Reason-Phrase = *<TEXT, excluding CR, LF>
        *
        * 6.2 Response Header Fields
        * response-header = Accept-Ranges
        *       | Age ; Section 14.6
                | ETag ; Section 14.19
                | Location ; Section 14.30
                | Proxy-Authenticate ; Section 14.33
                | Retry-After ; Section 14.37
                | Server ; Section 14.38
                | Vary ; Section 14.44
                | WWW-Authenticate
        *
        * 7.1 Entity Header Fields
        * entity-header =
        *         Allow
                | Content-Encoding
                | Content-Language
                | Content-Length
                | Content-Location
                | Content-MD5
                | Content-Range
                | Content-Type
                | Expires
                | Last-Modified
                | extension-header
        * extension-header = message-header
        *
        * 7.2 Entity Body
        * entity-body = *OCTET
        *
        * 7.2.1 Type
        * entity-body := Content-Encoding( Content-Type( data ) )
        *
        * 14.1 Accept
        * Accept = "Accept" ":" #( media-range [ accept-params ] )
        * media-range = ( "*" "/" "*"
        *               | ( type "/" "*" )
        *               | ( type "/" subtype )
        *               ) *( ";" parameter )
        * accept-params = ";" "q" "=" qvalue *( accept-extension )
        * accept-extension = ";" token [ "=" ( token | quoted-string ) ]
        *
        * 14.2 Accept-Charset
        * Accept-Charset = "Accept-Charset" ":" 1#( ( charset | "*" )[ ";" "q" "=" qvalue ] )
        *
        * 14.3 Accept-Encoding
        * Accept-Encoding = "Accept-Encoding" ":"
        *                   1#( codings [ ";" "q" "=" qvalue ] )
        * codings = ( content-coding | "*" )
        *
        * 14.4 Accept-Language
        * Accept-Language = "Accept-Language" ":"
        *                   1#( language-range [ ";" "q" "=" qvalue ] )
        * language-range = ( ( 1*8ALPHA *( "-" 1*8ALPHA ) ) | "*" )
        *
        * 14.5 Accept-Ranges
        * Accept-Ranges = "Accept-Ranges" ":" acceptable-ranges
        * acceptable-ranges = 1#range-unit | "none"
        *
        * 14.6 Age
        * Age = "Age" ":" age-value
        * age-value = delta-seconds
        *
        * 14.7 Allow
        * Allow = "Allow" ":" #Method
        *
        * 14.8 Authorization
        * Authorization = "Authorization" ":" credentials
        *
        * 14.9 Cache-Control
        * Cache-Control = "Cache-Control" ":" 1#cache-directive
        * cache-directive = cache-request-directive | cache-response-directive
        *
        * cache-request-directive =
        *         "no-cache"
        *       | "no-store"
        *       | "max-age" "=" delta-seconds
        *       | "max-stale" [ "=" delta-seconds ]
        *       | "min-fresh" "=" delta-seconds
        *       | "no-transform"
        *       | "only-if-cached"
        *       | cache-extension
        * cache-response-directive =
        *         "public"
        *       | "private" [ "=" <"> 1#field-name <"> ]
        *       | "no-cache" [ "=" <"> 1#field-name <"> ]
        *       | "no-store"
        *       | "no-transform"
        *       | "must-revalidate"
        *       | "proxy-revalidate"
        *       | "max-age" "=" delta-seconds
        *       | "s-maxage" "=" delta-seconds
        *       | cache-extension
        * cache-extension = token [ "=" ( token | quoted-string ) ]
        *
        * 14.10 Connection
        * Connection = "Connection" ":" 1#(connection-token)
        * connection-token = token
        *
        * 14.11 Content-Encoding
        * Content-Encoding = "Content-Encoding" ":" 1#content-coding
        *
        * 14.12 Content-Language
        * Content-Language = "Content-Language" ":" 1#language-tag
        *
        * 14.13 Content-Length
        * Content-Length = "Content-Length" ":" 1*DIGIT
        *
        * 14.14 Content-Location
        * Content-Location = "Content-Location" ":" ( absolute-URI | relativeURI )
        *
        * 14.15 Content-MD5
        * Content-MD5 = "Content-MD5" ":" md5-digest
        * md5-digest = <base64 of 128 bit MD5 digest as per RFC 1864>
        *
        * 14.16 Content-Range
        * Content-Range = "Content-Range" ":" content-range-spec
        * content-range-spec  = byte-content-range-spec
        * byte-content-range-spec = bytes-unit SP byte-range-resp-spec "/" ( instance-length | "*" )
        * byte-range-resp-spec = (first-byte-pos "-" last-byte-pos) | "*"
        * instance-length = 1*DIGIT
        *
        * 14.17 Content-Type
        * Content-Type = "Content-Type" ":" media-type
        *
        * 14.18 Date
        * Date = "Date" ":" HTTP-date
        *
        * 14.19 ETag
        * ETag = "ETag" ":" entity-tag
        *
        * 14.20 Expect
        * Expect = "Expect" ":" 1#expectation
        * expectation = "100-continue" | expectation-extension
        * expectation-extension = token [ "=" ( token | quoted-string ) *expect-params ]
        * expect-params = ";" token [ "=" ( token | quoted-string ) ]
        *
        * 14.21 Expires
        * Expires = "Expires" ":" HTTP-date
        *
        * 14.22 From
        * From = "From" ":" mailbox
        *
        * 14.23 Host
        * Host = "Host" ":" host [ ":" port ] ; Section 3.2.2
        *
        * 14.24 If-Match
        * If-Match = "If-Match" ":" ( "*" | 1#entity-tag )
        *
        * 14.25 If-Modified-Since
        * If-Modified-Since = "If-Modified-Since" ":" HTTP-date
        *
        * 14.26 If-None-Match
        * If-None-Match = "If-None-Match" ":" ( "*" | 1#entity-tag )
        *
        * 14.27 If-Range
        * If-Range = "If-Range" ":" ( entity-tag | HTTP-date )
        *
        * 14.28 If-Unmodified-Since
        * If-Unmodified-Since = "If-Unmodified-Since" ":" HTTP-date
        *
        * 14.29 Last-Modified
        * Last-Modified = "Last-Modified" ":" HTTP-date
        *
        * 14.30 Location
        * Location = "Location" ":" absolute-URI
        *
        * 14.31 Max-Forwards
        * Max-Forwards = "Max-Forwards" ":" 1*DIGIT
        *
        * 14.32 Pragma
        * Pragma = "Pragma" ":" 1#pragma-directive
        * pragma-directive = "no-cache" | extension-pragma
        * extension-pragma = token [ "=" ( token | quoted-string ) ]
        *
        * 14.33 Proxy-Authenticate
        * Proxy-Authenticate = "Proxy-Authenticate" ":" 1#challenge
        *
        * 14.34 Proxy-Authorization
        * Proxy-Authorization = "Proxy-Authorization" ":" credentials
        *
        * 14.35.1 Byte Ranges
        * ranges-specifier = byte-ranges-specifier
        * byte-ranges-specifier = bytes-unit "=" byte-range-set
        * byte-range-set = 1#( byte-range-spec | suffix-byte-range-spec )
        * byte-range-spec = first-byte-pos "-" [last-byte-pos]
        * first-byte-pos = 1*DIGIT
        * last-byte-pos = 1*DIGIT
        * suffix-byte-range-spec = "-" suffix-length
        * suffix-length = 1*DIGIT
        *
        * 14.35.2 Range Retrieval Requests
        * Range = "Range" ":" ranges-specifier
        *
        * 14.36 Referer
        * Referer = "Referer" ":" ( absolute-URI | relativeURI )
        *
        * 14.37 Retry-After
        * Retry-After = "Retry-After" ":" ( HTTP-date | delta-seconds )
        *
        * 14.38 Server
        * Server = "Server" ":" 1*( product | comment )
        *
        * 14.39 TE
        * TE = "TE" ":" #( t-codings )
        * t-codings = "trailers" | ( transfer-extension [ accept-params ] )
        *
        * 14.40 Trailer
        * Trailer = "Trailer" ":" 1#field-name
        *
        * 14.41 Transfer-Encoding
        * Transfer-Encoding = "Transfer-Encoding" ":" 1#transfer-coding
        *
        * 14.42 Upgrade
        * Upgrade = "Upgrade" ":" 1#product
        *
        * 14.43 User-Agent
        * User-Agent = "User-Agent" ":" 1*( product | comment )
        *
        * 14.44 Vary
        * Vary = "Vary" ":" ( "*" | 1#field-name )
        *
        * 14.45 Via
        * Via = "Via" ":" 1#( received-protocol received-by [ comment ] )
        * received-protocol = [ protocol-name "/" ] protocol-version
        * protocol-name = token
        * protocol-version = token
        * received-by = ( host [ ":" port ] ) | pseudonym
        * pseudonym = token
        *
        * 14.46 Warning
        * Warning = "Warning" ":" 1#warning-value
        * warning-value = warn-code SP warn-agent SP warn-text [SP warn-date]
        * warn-code = 3DIGIT
        * warn-agent = ( host [ ":" port ] ) | pseudonym
        *               ; the name or pseudonym of the server adding
        *               ; the Warning header, for use in debugging
        * warn-text = quoted-string
        * warn-date = <"> HTTP-date <">
        *
        * 14.47 WWW-Authenticate
        * WWW-Authenticate = "WWW-Authenticate" ":" 1#challenge
        *
        * 19.4.1 MIME-Version
        * MIME-Version = "MIME-Version" ":" 1*DIGIT "." 1*DIGIT
        *
        * 19.5.1 Content-Disposition
        *    see RFC 2183.
        * content-disposition = "Content-Disposition" ":" disposition-type *( ";" disposition-parm )
        * disposition-type = "attachment" | disp-extension-token
        * disposition-parm = filename-parm | disp-extension-parm
        * filename-parm = "filename" "=" quoted-string
        * disp-extension-token = token
        * disp-extension-parm = token "=" ( token | quoted-string )
        *
        *  filename encoded by RFC 2184. but see http://greenbytes.de/tech/tc2231/
        *
        */
    }
};

extern template class http_rules<const char *>;




inline proto_version::proto_version()
    : major()
    , minor()
{}

inline proto_version::proto_version(uint major_, uint minor_)
    : major(major_)
    , minor(minor_)
{}

inline bool operator<(const proto_version & a, const proto_version & b)
{
    if (a.major != b.major)
        return a.major < b.major;
    else
        return a.minor < b.minor;
}

inline bool operator==(const proto_version & a, const proto_version & b)
{
    return a.major == b.major &&
           a.minor == b.minor;
}


inline proto::proto()
    : name()
    , ver()
{}

inline proto::proto(std::string name_, uint major_, uint minor_)
    : name(name_)
    , ver(proto_version(major_, minor_))
{}

inline bool operator==(const proto & a, const proto & b)
{
    return a.name == b.name &&
           a.ver  == b.ver;
}


} /* namespace http_server */
} /* namespace module */
} /* namespace viaus */
} /* namespace izh_bs */

#endif // IZH_BS_VIAUS_MODULE_HTTP_SERVER_PARSE_HTTP_HPP_INCLUDED
