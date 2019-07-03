#ifndef TYPE
#	warning TYPE not define. Skip.
#else

TYPE(float)
TYPE(double)
TYPE(long double)

#if 1
TYPE(__float80)
#endif

#if 1
TYPE(__float128)
#endif


#endif
