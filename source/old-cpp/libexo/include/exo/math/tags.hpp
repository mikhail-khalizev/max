#ifndef EXO_MATH_TAGS_HPP_INCLUDED
#define EXO_MATH_TAGS_HPP_INCLUDED

namespace exo {
namespace math {
namespace tag {


struct uncheck_construct {};


/* See http://en.wikipedia.org/wiki/Rounding */

/** Округление к меньшему. */
struct round_down {};

/** Округление к большему. */
struct round_up {};

/** Округление к меньшему по модулю. */
struct round_towards_zero {};

/** Округление к большему по модулю. */
struct round_away_from_zero {};

/** Округление к ближайшему. */
struct round_to_nearest {};


typedef round_to_nearest round_default;


} /* namespace tags */
} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_TAGS_HPP_INCLUDED */
