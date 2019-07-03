#include <exo/util/identificator.hpp>


#define throw_assert(ex, str, ...) \
        if (!(ex)) \
        { \
            printf("%d: " str "\n", __LINE__, __VA_ARGS__); \
            ret_code = 1; \
            return; \
        } \

int ret_code = 0;


namespace exo {
namespace util {

static void internal_check()
{
    //SELF_TEST("exo::identificator_unsafe_manager")
    {
        identificator_unsafe_manager<int> im(9);

        for (int i = 0; i < 10; i++)
        {
            int val = im.create();
            throw_assert(val == i, "%d, %d.", val, i);
        }

        throw_assert(im.free.size() == 0, "%lu.", im.free.size());

        for (int i = 0; i < 10; i++)
        {
            im.release(i);
            throw_assert(im.free.size() == 1, "%lu.", im.free.size());
        }

        for (int i = 0; i < 10; i++)
        {
            int val = im.create();
            throw_assert(val == i, "%d, %d.", val, i);
        }

        throw_assert(im.free.size() == 0, "%lu.", im.free.size());

        for (int i = im.get_max(); 0 <= i; i--)
        {
            im.release(i);
            throw_assert(im.free.size() == 1, "%lu.", im.free.size());
        }

        for (int i = 0; i < 10; i++)
        {
            int val = im.create();
            throw_assert(val == i, "%d, %d.", val, i);
        }

        throw_assert(im.free.size() == 0, "%lu.", im.free.size());

        for (int i = 0; i < 10; i++)
        {
            im.release(i);
            throw_assert(im.free.size() == 1, "%lu.", im.free.size());
        }
    }

    // SELF_TEST("exo::identificator_unsafe_manager")
    {
        identificator_unsafe_manager<int> im(9);

        for (int i = 0; i < 10; i++)
            im.create();

        throw_assert(im.free.size() == 0, "%lu.", im.free.size());

        for (int i = 0; i < 10; i+=2)
            im.release(i);

        throw_assert(im.free.size() == 5, "%lu.", im.free.size());

        for (int i = 1; i < 10; i+=2)
            im.release(i);

        throw_assert(im.free.size() == 1, "%lu.", im.free.size());
    }

    //SELF_TEST("exo::identificator_unsafe_manager")
    {
        identificator_unsafe_manager<int> im(9);

        int id = im.create();

        bool ok = im.try_release(id);
        throw_assert(ok == true, "%u.", ok);

        ok = im.try_release(id);
        throw_assert(ok == false, "%u.", ok);
    }

    //SELF_TEST("exo::identificator_unsafe_manager")
    {
        identificator_unsafe_manager<int> im(9);

        int id0 = im.create();
        int id1 = im.create();

        im.release(id0);
        im.release(id1);

        int id2 = im.create();

        throw_assert(id0 == 0 && id1 == 1 && id2 == 2,
                "%d, %d, %d.", id0, id1, id2);
    }
}

} /* namespace util */
} /* namespace exo */


int main()
{
    exo::util::internal_check();
    return ret_code;
}

