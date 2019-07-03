#include <ios>

#include <QDebug>
#include <QTextCodec>

#include "../../src/module/http_server/parse_uri.hpp"
#include "../../src/module/http_server/parse_http.hpp"

using namespace izh_bs::viaus::module::http_server;


template<typename T>
std::ostream & operator<<(std::ostream & o, const std::vector<T> & v)
{
    if (0 < v.size())
        o << v[0];

    for (size_t i = 1; i < v.size(); i++)
        o << ", " << v[i];

    return o;
}


static bool global_success = true;

/** success if parse success */
template <typename Expr>
void test(Expr const & expr, char const * input)
{
    using boost::spirit::qi::parse;

    char const * f = input;
    char const * l = f + strlen(f);

    typename Expr::attr_type attr;
    bool ok = parse(f, l, expr, attr) && (f == l);
    global_success &= ok;

    std::cout << ok << (f == l) << " \"" << input << "\" \"" << attr << '"' << std::endl;
}

/** success if parse success and matched attribute equal \a attr_must_be. */
template <typename Attr>
void test_(const qi::rule<const char *, Attr()> & expr, char const * input, const Attr & attr_must_be)
{
    using boost::spirit::qi::parse;

    char const * f = input;
    char const * l = f + strlen(f);

    Attr attr;
    bool ok = parse(f, l, expr, attr) && (f == l);
    ok &= attr == attr_must_be;
    global_success &= ok;

    std::cout << ok << (f == l) << " \"" << input << "\" \"" << attr << '"' << std::endl;
}

/** success if parse success and matched attribute equal \a attr_must_be. */
template <typename Attr, typename Expr>
void test(const Expr & expr, char const * input, const Attr & attr_must_be)
{
    test_<Attr>(expr, input, attr_must_be);
}

/** success if parse success and matched attribute equal \a attr_must_be. */
template <typename Expr, int N>
void test(const Expr & expr, char const * input, const char (&attr_must_be)[N])
{
    test_<std::string>(expr, input, attr_must_be);
}

/** success if parse fail */
template <typename Attr, typename Expr>
void fail_(Expr const & expr, char const * input)
{
    using boost::spirit::qi::parse;

    char const * f = input;
    char const * l = f + strlen(f);

    Attr attr;
    bool ok = ! (parse(f, l, expr, attr) && (f == l));
    global_success &= ok;

    std::cout << ok << (f == l) << " \"" << input << '"' << std::endl;
}

/** success if parse fail */
template <typename Attr, typename Expr>
void fail(Expr const & expr, char const * input)
{
    fail_<Attr>(expr, input);
}

/** success if parse fail */
template <typename Expr>
void fail(Expr const & expr, char const * input)
{
    fail_<typename Expr::attr_type>(expr, input);
}


static void test_ipv6(uri_rules<const char *> & uri_parsers)
{
    std::vector<quint16> addr(8);
    addr[0] = 0x2001;
    addr[1] = 0x0db8;
    addr[2] = 0x11a3;
    addr[3] = 0x09d7;
    addr[4] = 0x1f34;
    addr[5] = 0x8a2e;
    addr[6] = 0x07a0;
    addr[7] = 0x765d;
    test(uri_parsers.IPv6address, "2001:0db8:11a3:09d7:1f34:8a2e:07a0:765d", addr);

    addr[0] = 0x2001;
    addr[1] = 0xdb8;
    addr[2] = 0;
    addr[3] = 0;
    addr[4] = 0;
    addr[5] = 0xff00;
    addr[6] = 0x42;
    addr[7] = 0x8329;
    test(uri_parsers.IPv6address, "2001:db8:0:0:0:ff00:42:8329", addr);
    test(uri_parsers.IPv6address, "2001:db8::ff00:42:8329", addr);

    addr[0] = 0;
    addr[1] = 0;
    addr[2] = 0;
    addr[3] = 0;
    addr[4] = 0;
    addr[5] = 0;
    addr[6] = 0;
    addr[7] = 1;
    test(uri_parsers.IPv6address, "0000:0000:0000:0000:0000:0000:0000:0001", addr);
    test(uri_parsers.IPv6address, "::1", addr);

    addr[0] = 0xfc00;
    addr[1] = 0;
    addr[2] = 0;
    addr[3] = 0;
    addr[4] = 0;
    addr[5] = 0;
    addr[6] = 0;
    addr[7] = 0;
    test(uri_parsers.IPv6address, "fc00::", addr);

    addr[0] = 0x2001;
    addr[1] = 0xdb8;
    addr[2] = 0;
    addr[3] = 0;
    addr[4] = 0;
    addr[5] = 0;
    addr[6] = 0;
    addr[7] = 0;
    test(uri_parsers.IPv6address, "2001:db8::", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444:5555:6666:7777:8888", addr);

    addr[0] = 0;
    test(uri_parsers.IPv6address, "::2222:3333:4444:5555:6666:7777:8888", addr);

    addr[1] = 0;
    test(uri_parsers.IPv6address, "::3333:4444:5555:6666:7777:8888", addr);

    addr[2] = 0;
    test(uri_parsers.IPv6address, "::4444:5555:6666:7777:8888", addr);

    addr[3] = 0;
    test(uri_parsers.IPv6address, "::5555:6666:7777:8888", addr);

    addr[4] = 0;
    test(uri_parsers.IPv6address, "::6666:7777:8888", addr);

    addr[5] = 0;
    test(uri_parsers.IPv6address, "::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[1] = 0;
    test(uri_parsers.IPv6address, "1111::3333:4444:5555:6666:7777:8888", addr);

    addr[2] = 0;
    test(uri_parsers.IPv6address, "1111::4444:5555:6666:7777:8888", addr);

    addr[3] = 0;
    test(uri_parsers.IPv6address, "1111::5555:6666:7777:8888", addr);

    addr[4] = 0;
    test(uri_parsers.IPv6address, "1111::6666:7777:8888", addr);

    addr[5] = 0;
    test(uri_parsers.IPv6address, "1111::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[2] = 0;
    test(uri_parsers.IPv6address, "1111:2222::4444:5555:6666:7777:8888", addr);

    addr[3] = 0;
    test(uri_parsers.IPv6address, "1111:2222::5555:6666:7777:8888", addr);

    addr[4] = 0;
    test(uri_parsers.IPv6address, "1111:2222::6666:7777:8888", addr);

    addr[5] = 0;
    test(uri_parsers.IPv6address, "1111:2222::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111:2222::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[3] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333::5555:6666:7777:8888", addr);

    addr[4] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333::6666:7777:8888", addr);

    addr[5] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[4] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444::6666:7777:8888", addr);

    addr[5] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[5] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444:5555::7777:8888", addr);

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444:5555::8888", addr);

    addr[0] = 0x1111;
    addr[1] = 0x2222;
    addr[2] = 0x3333;
    addr[3] = 0x4444;
    addr[4] = 0x5555;
    addr[5] = 0x6666;
    addr[6] = 0x7777;
    addr[7] = 0x8888;

    addr[6] = 0;
    test(uri_parsers.IPv6address, "1111:2222:3333:4444:5555:6666::8888", addr);


    fail(uri_parsers.IPv6address, "1111:2222:3333:4444:5555:6666:7777:8888:9999");
    fail(uri_parsers.IPv6address, "1111::2222:3333:4444:5555:6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222::3333:4444:5555:6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111::2222:3333:4444:5555:6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222:3333::4444:5555:6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222:3333:4444::5555:6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222:3333:4444:5555::6666:7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222:3333:4444:5555:6666::7777:8888");
    fail(uri_parsers.IPv6address, "1111:2222:3333:4444:5555:6666:7777::8888");
}


int main()
{
    QTextCodec::setCodecForTr(QTextCodec::codecForName("utf8"));
    QTextCodec::setCodecForCStrings(QTextCodec::codecForName("utf8"));

    uri_rules<const char *> uri_parsers;
    http_rules<const char *> http_parsers;


    test(uri_parsers.pct_encoded, "%20", ' ');
    test(uri_parsers.pct_encoded, "%0a", '\n');

    test(uri_parsers.IPvFuture, "v20.hh", boost::fusion::vector<uint, std::string>(32, std::string("hh")));
    test_ipv6(uri_parsers);
//    test(uri_parsers.dec_octet, "0", 0);
//    test(uri_parsers.dec_octet, "6", 6);
//    test(uri_parsers.dec_octet, "254", 254);
//    test(uri_parsers.dec_octet, "255", 255);
//    fail(uri_parsers.dec_octet, "256");
//    fail(uri_parsers.dec_octet, "257");


    test(ALPHA_to_lower<const char *>(), "p", 'p');
    test(ALPHA_to_lower<const char *>(), "P", 'p');
    fail<char>(ALPHA_to_lower<const char *>(), "8");
    test<std::string>(*ALPHA_to_lower<const char *>(), "aBcDefGH", "abcdefgh");

    // @tmp
    qi::rule<const char *, std::string()> ex;
    ex %= *( LOALPHA | UPALPHA[qi::_1 += -'A' + 'a']);
    test(ex, "aBcDefGH", "abcdefgh");

    // @tmp
    qi::rule<const char *, std::string()> ex2( *( LOALPHA | UPALPHA[qi::_1 += -'A' + 'a']) );
    test(ex2, "aBcDefGH", "");


    test(http_parsers.token, "tok", "tok");
    fail(http_parsers.token, " tok");
    fail(http_parsers.token, "tok ");
    fail(http_parsers.token, "to:k");
    fail(http_parsers.token, "to\nk");

    test(http_parsers.ctext, "t", 't');
    test(http_parsers.ctext, " \n  ", ' ');
    fail(http_parsers.ctext, "(");

    test(http_parsers.ctext_without_LWS, "t", 't');
    fail(http_parsers.ctext_without_LWS, " \n  ");
    fail(http_parsers.ctext_without_LWS, "(");

    test(http_parsers.comment, "(c)", "(c)");
    test(http_parsers.comment, "( c)", "(c)");
    test(http_parsers.comment, "(  c)", "(c)");
    test(http_parsers.comment, "(c )", "(c)");
    test(http_parsers.comment, "(c  )", "(c)");
    test(http_parsers.comment, "( c )", "(c)");
    test(http_parsers.comment, "(  c  )", "(c)");
    test(http_parsers.comment, "(   c    d  e     f   )", "(c d e f)");
    test(http_parsers.comment, "(\n   c   \n   \n     \n   d   \n )", "(c d)");
    test(http_parsers.comment, "(\\a\\\"\\b)", "(a\"b)");
    test(http_parsers.comment, "(b(c)d)", "(b (c) d)");
    test(http_parsers.comment, "( b ( c ) d )", "(b (c) d)");
    test(http_parsers.comment, "(   c   (    d    )     e   )", "(c (d) e)");
    test(http_parsers.comment, "(c(d))", "(c (d))");
    test(http_parsers.comment, "( c ( d ) )", "(c (d))");
    test(http_parsers.comment, "((c)d)", "((c) d)");
    test(http_parsers.comment, "( ( c ) d )", "((c) d)");
    test(http_parsers.comment, "((c))", "((c))");
    test(http_parsers.comment, "( ( c ) )", "((c))");
    fail(http_parsers.comment, "(()");
    fail(http_parsers.comment, "())");

    test(http_parsers.quoted_string, "\"abc\"", "abc");
    test(http_parsers.quoted_string, "\"ab  \n   c\"", "ab c");
    test(http_parsers.quoted_string, "\"a\\\"\\bc\"", "a\"bc");

    test(http_parsers.HTTP_Version, "HTTP/00.0",  proto("HTTP", 0, 0));
    test(http_parsers.HTTP_Version, "HTTP/0.00",  proto("HTTP", 0, 0));
    test(http_parsers.HTTP_Version, "HTTP/00.00", proto("HTTP", 0, 0));

    test(http_parsers.HTTP_Version, "HTTP/0.9",  proto("HTTP", 0, 9));
    test(http_parsers.HTTP_Version, "HTTP/0.09", proto("HTTP", 0, 9));
    test(http_parsers.HTTP_Version, "HTTP/00.9", proto("HTTP", 0, 9));

    test(http_parsers.HTTP_Version, "HTTP/1.00", proto("HTTP", 1, 0));
    test(http_parsers.HTTP_Version, "HTTP/01.0", proto("HTTP", 1, 0));

    test(http_parsers.HTTP_Version, "HTTP/1.01", proto("HTTP", 1, 1));
    test(http_parsers.HTTP_Version, "HTTP/01.1", proto("HTTP", 1, 1));
    test(http_parsers.HTTP_Version, "HTTP/1.1",  proto("HTTP", 1, 1));

    fail(http_parsers.HTTP_Version, "HTTP/.1");
    fail(http_parsers.HTTP_Version, "HTTP/1.");
    fail(http_parsers.HTTP_Version, "HTTP/1a.1");
    fail(http_parsers.HTTP_Version, "HTTP/1.1a");

    return global_success ? 0 : 1;
}
