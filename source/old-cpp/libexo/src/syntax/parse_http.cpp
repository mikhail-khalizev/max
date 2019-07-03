#include "parse_http.hpp"

namespace izh_bs {
namespace viaus {
namespace module {
namespace http_server {


std::ostream & operator<<(std::ostream & o, const proto_version & v)
{
    return o << v.major << '.' << v.minor;
}

std::ostream & operator<<(std::ostream & o, const proto & p)
{
    return o << p.name << '/' << p.ver;
}


/* #rule
 * 1#element  =  *LWS element *( *LWS ","   *LWS element   )
 *                      skip(LWS)[element % ',']
 *
 * удаление начальных и конечных L: *L e *(hold[ +L e ]) *L
 */




/* @todo Оптимизировать. Вместо std::string в каждом rule использовать
 * общий std::string, индексы начала/конца подстрочек хранить отдельно. */

template class http_rules<const char *>;


} /* namespace http_server */
} /* namespace module */
} /* namespace viaus */
} /* namespace izh_bs */
